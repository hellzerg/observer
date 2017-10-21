using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class ExclusionsForm : Form
    {
        FolderBrowserDialog _dialog;

        public ExclusionsForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            Options.ApplyTheme(this);

            _dialog = new FolderBrowserDialog();
            _dialog.Description = "Choose your desired path to exclude";
            _dialog.RootFolder = Environment.SpecialFolder.MyComputer;
        }

        private void LoadExclusions()
        {
            listExclusions.Items.Clear();

            foreach (string x in Options.CurrentOptions.Exclusions)
            {
                listExclusions.Items.Add(x);
            }
        }

        private void AddExclusion()
        {
            if (!string.IsNullOrEmpty(txtExcludedPath.Text))
            {
                Options.CurrentOptions.Exclusions.Add(txtExcludedPath.Text);
                LoadExclusions();
                txtExcludedPath.Text = string.Empty;
            }
        }

        private void RemoveExclusion()
        {
            if (listExclusions.SelectedIndex > -1)
            {
                Options.CurrentOptions.Exclusions.RemoveAt(listExclusions.SelectedIndex);
                LoadExclusions();
            }
        }

        private void RemoveAllExclusions()
        {
            Options.CurrentOptions.Exclusions.Clear();
            LoadExclusions();
        }

        private void ExcludeForm_Load(object sender, EventArgs e)
        {
            LoadExclusions();   
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (_dialog.ShowDialog() == DialogResult.OK)
            {
                txtExcludedPath.Text = _dialog.SelectedPath;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Options.SaveSettings();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddExclusion();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveExclusion();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            RemoveAllExclusions();
        }
    }
}
