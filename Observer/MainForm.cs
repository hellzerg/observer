using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class MainForm : Form
    {
        FolderBrowserDialog _folderBrowserDialog;
        ListViewColumnSorter _columnSorter;
        List<Exclusion> _exclusions;

        object _lockObject;

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Options.ApplyTheme(this);

            _columnSorter = new ListViewColumnSorter();
            eventList.ListViewItemSorter = _columnSorter;

            _folderBrowserDialog = new FolderBrowserDialog();
            _folderBrowserDialog.Description = "Choose your desired path to observe";
            _folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            _exclusions = new List<Exclusion>();
            _lockObject = new object();

            txtPath.Text = Options.CurrentOptions.Path;

            LoadExclusions();

            checkCreated.Checked = Options.CurrentOptions.FileCreatedEvent;
            checkDeleted.Checked = Options.CurrentOptions.FileDeletedEvent;
            checkModified.Checked = Options.CurrentOptions.FileModifiedEvent;
            checkRenamed.Checked = Options.CurrentOptions.FileRenamedEvent;
            chkExclusions.Checked = Options.CurrentOptions.ExclusionsEnabled;

            this.Text = "Observer " + Program.GetCurrentVersionToString();
        }

        private void LoadExclusions()
        {
            _exclusions.Clear();

            foreach (string x in Options.CurrentOptions.Exclusions)
            {
                Exclusion pf = new Exclusion(x);
                _exclusions.Add(pf);
            }
        }

        private void HandleButtonState()
        {
            btnStart.Enabled = !btnStart.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
            btnExclusions.Enabled = !btnExclusions.Enabled;
            txtPath.Enabled = !txtPath.Enabled;
        }

        private void ExportLog()
        {
            if (eventList.Items.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Observer log - {0}, {1}\n\n", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());

                foreach (ListViewItem i in eventList.Items)
                {
                    sb.AppendFormat("Object: {0}\n", i.Text);
                    sb.AppendFormat("Last accessed: {0}\n", i.SubItems[1].Text);
                    sb.AppendFormat("Access count: {0}\n", i.SubItems[2].Text);
                    sb.AppendFormat("Access type: {0}\n\n", i.Tag.ToString());
                }

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.InitialDirectory = Application.StartupPath;
                dialog.DefaultExt = ".log";
                dialog.Filter = "Observer log files|*.log";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, sb.ToString());
                }
            }
        }

        private bool CheckExclusions(string path)
        {
            // ignore exclusions
            if (!Options.CurrentOptions.ExclusionsEnabled) return true;

            bool passed = true;
            
            foreach (Exclusion x in _exclusions)
            {
                if (path.Contains(x.Filter))
                {
                    passed = false;
                    break;
                }
            }

            return passed;
        }

        private void HandleFileSystemWatcherUpdate()
        {
            WorkEventArgs doWorkEventObject = WorkEvents.Instance.GetEventObject();
            if (doWorkEventObject != null)
            {
                string fileName = doWorkEventObject.FileName;
                if (CheckExclusions(Path.GetDirectoryName(fileName)))
                {
                    string eventTypeString = doWorkEventObject.EventType;

                    ListViewItem currItem = null;
                    lock (eventList)
                    {
                        try
                        {
                            foreach (ListViewItem lvi in eventList.Items)
                            {
                                if (lvi.Text == fileName && lvi.Tag.ToString() == eventTypeString)
                                {
                                    currItem = lvi;
                                    continue;
                                }
                            }
                        }
                        catch { }
                    }

                    WorkEventArgs wea = new WorkEventArgs(fileName, eventTypeString, currItem);

                    // DoWorkEventArgs dw = new DoWorkEventArgs(wea);

                    if (!changeEventBackgroundWorker.IsBusy)
                    {
                        changeEventBackgroundWorker.RunWorkerAsync(wea);
                    }
                    else
                    {
                        WorkEvents.Instance.Add(wea);
                    }
                }
            }
        }

        private void HandleFileSystemWatcherUpdate(EventType eventType, FileSystemEventArgs e)
        {
            string fileName = fileSystemWatcher.Path + e.Name;
            
            if (CheckExclusions(Path.GetDirectoryName(fileName)))
            {
                string eventTypeString = string.Empty;
                switch (eventType)
                {
                    case EventType.Modified:
                        {
                            if (!checkModified.Checked)
                            {
                                return;
                            }
                            eventTypeString = "Modified";

                            break;
                        }
                    case EventType.Created:
                        {
                            if (!checkCreated.Checked)
                            {
                                return;
                            }

                            eventTypeString = "Created";
                            break;
                        }
                    case EventType.Deleted:
                        {
                            if (!checkDeleted.Checked)
                            {
                                return;
                            }
                            eventTypeString = "Deleted";
                            break;
                        }
                    case EventType.Renamed:
                        {
                            if (!checkRenamed.Checked)
                            {
                                return;
                            }

                            eventTypeString = "Renamed";
                            break;
                        }
                }

                ListViewItem currItem = null;
                lock (eventList)
                {
                    try
                    {
                        foreach (ListViewItem lvi in eventList.Items)
                        {
                            if (lvi.Text == fileName && lvi.Tag.ToString() == eventTypeString)
                            {
                                currItem = lvi;
                                continue;
                            }
                        }
                    }
                    catch { }
                }

                WorkEventArgs wea = new WorkEventArgs(fileName, eventTypeString, currItem);

                // DoWorkEventArgs dw = new DoWorkEventArgs(wea);

                if (!changeEventBackgroundWorker.IsBusy)
                {
                    changeEventBackgroundWorker.RunWorkerAsync(wea);
                }
                else
                {
                    WorkEvents.Instance.Add(wea);
                }
            }
        }

        private void StartObserving()
        {
            eventList.Items.Clear();
            fileSystemWatcher.Path = txtPath.Text;
            fileSystemWatcher.EnableRaisingEvents = true;
            HandleButtonState();
            this.Text = "Observer " + Program.GetCurrentVersionToString() + " - Observing";
        }

        private void StopObserving()
        {
            fileSystemWatcher.EnableRaisingEvents = false;
            HandleButtonState();
            this.Text = "Observer " + Program.GetCurrentVersionToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SystemWideHotKey.RegisterHotKey(this, Keys.Shift | Keys.F12 | Keys.Control);
            eventList.Select();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemWideHotKey.UnregisterHotKey(this);
            
            Options.CurrentOptions.Path = txtPath.Text;
            Options.SaveSettings();
        }

        private void checkModified_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.FileModifiedEvent = checkModified.Checked;
        }

        private void checkCreated_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.FileCreatedEvent = checkCreated.Checked;
        }

        private void checkDeleted_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.FileDeletedEvent = checkDeleted.Checked;
        }

        private void checkRenamed_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.FileRenamedEvent = checkRenamed.Checked;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = _folderBrowserDialog.SelectedPath;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm f = new AboutForm();
            f.ShowDialog(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                if (txtPath.Text.Last() != '\\') txtPath.AppendText("\\");
                StartObserving();
            }
        }

        private void changeEventBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            lock (_lockObject)
            {
                WorkEventArgs wea = (WorkEventArgs)e.Argument;

                if (wea.CurrentItem != null)
                {
                    wea.CurrentItem.Text = wea.FileName;
                    wea.CurrentItem.SubItems[1].Text = DateTime.Now.ToLongTimeString();
                    Int64 currCount = Convert.ToInt64(wea.CurrentItem.SubItems[2].Text.ToString()) + 1;
                    wea.CurrentItem.SubItems[2].Text = currCount.ToString();
                }
                else
                {
                    ListViewItem mainItem = new ListViewItem(wea.FileName);
                    mainItem.Tag = wea.EventType;
                    mainItem.SubItems.Add(DateTime.Now.ToLongTimeString());
                    
                    mainItem.SubItems.Add("1");
                    mainItem.SubItems.Add(wea.EventType);
                    eventList.Items.Add(mainItem);
                }
            }
        }

        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            HandleFileSystemWatcherUpdate(EventType.Modified, e);
        }

        private void fileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            HandleFileSystemWatcherUpdate(EventType.Created, e);
        }

        private void fileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            HandleFileSystemWatcherUpdate(EventType.Deleted, e);
        }

        private void fileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            HandleFileSystemWatcherUpdate(EventType.Renamed, e);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopObserving();
        }

        private void eventList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (File.Exists(eventList.SelectedItems[0].SubItems[0].Text))
                {
                    Process.Start("explorer.exe", "/select, " + eventList.SelectedItems[0].SubItems[0].Text);
                }
                else
                {
                    if (Directory.Exists(eventList.SelectedItems[0].SubItems[0].Text))
                    {
                        Process.Start(eventList.SelectedItems[0].SubItems[0].Text);
                    }
                }
            }
            catch { }
        }

        private void eventList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == _columnSorter.SortColumn)
            {
                if (_columnSorter.Order == SortOrder.Ascending)
                {
                    _columnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    _columnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                _columnSorter.SortColumn = e.Column;
                _columnSorter.Order = SortOrder.Ascending;
            }

            eventList.Sort();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == SystemWideHotKey.WM_HOTKEY)
            {
                StopObserving();
            }
        }

        private void extraWorkTimer_Tick(object sender, EventArgs e)
        {
            extraWorkTimer.Stop();
            HandleFileSystemWatcherUpdate();
            extraWorkTimer.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExclusionsForm f = new ExclusionsForm();
            f.ShowDialog();

            LoadExclusions();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OptionsForm f = new OptionsForm(this);
            f.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportLog();
        }

        private void chkExclusions_CheckedChanged(object sender, EventArgs e)
        {
            Options.CurrentOptions.ExclusionsEnabled = chkExclusions.Checked;
        }
    }
}
