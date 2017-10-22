namespace Observer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.checkModified = new System.Windows.Forms.CheckBox();
            this.checkCreated = new System.Windows.Forms.CheckBox();
            this.checkDeleted = new System.Windows.Forms.CheckBox();
            this.checkRenamed = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.eventList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.changeEventBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.extraWorkTimer = new System.Windows.Forms.Timer(this.components);
            this.btnExclusions = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.chkExclusions = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.ForeColor = System.Drawing.Color.White;
            this.txtPath.Location = new System.Drawing.Point(70, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(682, 34);
            this.txtPath.TabIndex = 1;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(893, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(86, 34);
            this.btnAbout.TabIndex = 83;
            this.btnAbout.Tag = "themeable";
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOptions.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Location = new System.Drawing.Point(801, 12);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(86, 34);
            this.btnOptions.TabIndex = 82;
            this.btnOptions.Tag = "themeable";
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(758, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(37, 34);
            this.btnBrowse.TabIndex = 81;
            this.btnBrowse.Tag = "themeable";
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // checkModified
            // 
            this.checkModified.AutoSize = true;
            this.checkModified.Checked = true;
            this.checkModified.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkModified.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkModified.Location = new System.Drawing.Point(12, 52);
            this.checkModified.Name = "checkModified";
            this.checkModified.Size = new System.Drawing.Size(120, 24);
            this.checkModified.TabIndex = 84;
            this.checkModified.Tag = "themeable";
            this.checkModified.Text = "File modified";
            this.checkModified.UseVisualStyleBackColor = true;
            this.checkModified.CheckedChanged += new System.EventHandler(this.checkModified_CheckedChanged);
            // 
            // checkCreated
            // 
            this.checkCreated.AutoSize = true;
            this.checkCreated.Checked = true;
            this.checkCreated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCreated.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkCreated.Location = new System.Drawing.Point(138, 52);
            this.checkCreated.Name = "checkCreated";
            this.checkCreated.Size = new System.Drawing.Size(110, 24);
            this.checkCreated.TabIndex = 85;
            this.checkCreated.Tag = "themeable";
            this.checkCreated.Text = "File created";
            this.checkCreated.UseVisualStyleBackColor = true;
            this.checkCreated.CheckedChanged += new System.EventHandler(this.checkCreated_CheckedChanged);
            // 
            // checkDeleted
            // 
            this.checkDeleted.AutoSize = true;
            this.checkDeleted.Checked = true;
            this.checkDeleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDeleted.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkDeleted.Location = new System.Drawing.Point(254, 52);
            this.checkDeleted.Name = "checkDeleted";
            this.checkDeleted.Size = new System.Drawing.Size(110, 24);
            this.checkDeleted.TabIndex = 86;
            this.checkDeleted.Tag = "themeable";
            this.checkDeleted.Text = "File deleted";
            this.checkDeleted.UseVisualStyleBackColor = true;
            this.checkDeleted.CheckedChanged += new System.EventHandler(this.checkDeleted_CheckedChanged);
            // 
            // checkRenamed
            // 
            this.checkRenamed.AutoSize = true;
            this.checkRenamed.Checked = true;
            this.checkRenamed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRenamed.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkRenamed.Location = new System.Drawing.Point(370, 52);
            this.checkRenamed.Name = "checkRenamed";
            this.checkRenamed.Size = new System.Drawing.Size(120, 24);
            this.checkRenamed.TabIndex = 87;
            this.checkRenamed.Tag = "themeable";
            this.checkRenamed.Text = "File renamed";
            this.checkRenamed.UseVisualStyleBackColor = true;
            this.checkRenamed.CheckedChanged += new System.EventHandler(this.checkRenamed_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStatus.Location = new System.Drawing.Point(7, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 28);
            this.lblStatus.TabIndex = 88;
            this.lblStatus.Tag = "themeable";
            this.lblStatus.Text = "Path:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // eventList
            // 
            this.eventList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.eventList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.eventList.ForeColor = System.Drawing.Color.White;
            this.eventList.FullRowSelect = true;
            this.eventList.Location = new System.Drawing.Point(12, 82);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(967, 463);
            this.eventList.TabIndex = 89;
            this.eventList.UseCompatibleStateImageBehavior = false;
            this.eventList.View = System.Windows.Forms.View.Details;
            this.eventList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.eventList_ColumnClick);
            this.eventList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.eventList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File/Folder";
            this.columnHeader1.Width = 656;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last accessed";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Access count";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Access type";
            this.columnHeader4.Width = 90;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(12, 554);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 34);
            this.btnStart.TabIndex = 90;
            this.btnStart.Tag = "themeable";
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(104, 554);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(86, 34);
            this.btnStop.TabIndex = 93;
            this.btnStop.Tag = "themeable";
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.IncludeSubdirectories = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Created);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Deleted);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
            // 
            // changeEventBackgroundWorker
            // 
            this.changeEventBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.changeEventBackgroundWorker_DoWork);
            // 
            // extraWorkTimer
            // 
            this.extraWorkTimer.Enabled = true;
            this.extraWorkTimer.Interval = 1000;
            this.extraWorkTimer.Tick += new System.EventHandler(this.extraWorkTimer_Tick);
            // 
            // btnExclusions
            // 
            this.btnExclusions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExclusions.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExclusions.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExclusions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnExclusions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnExclusions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExclusions.ForeColor = System.Drawing.Color.White;
            this.btnExclusions.Location = new System.Drawing.Point(196, 554);
            this.btnExclusions.Name = "btnExclusions";
            this.btnExclusions.Size = new System.Drawing.Size(96, 34);
            this.btnExclusions.TabIndex = 94;
            this.btnExclusions.Tag = "themeable";
            this.btnExclusions.Text = "Exclusions";
            this.btnExclusions.UseVisualStyleBackColor = false;
            this.btnExclusions.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(298, 554);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(96, 34);
            this.btnExport.TabIndex = 95;
            this.btnExport.Tag = "themeable";
            this.btnExport.Text = "Export log";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chkExclusions
            // 
            this.chkExclusions.AutoSize = true;
            this.chkExclusions.Checked = true;
            this.chkExclusions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExclusions.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chkExclusions.Location = new System.Drawing.Point(496, 52);
            this.chkExclusions.Name = "chkExclusions";
            this.chkExclusions.Size = new System.Drawing.Size(151, 24);
            this.chkExclusions.TabIndex = 96;
            this.chkExclusions.Tag = "themeable";
            this.chkExclusions.Text = "Enable exclusions";
            this.chkExclusions.UseVisualStyleBackColor = true;
            this.chkExclusions.CheckedChanged += new System.EventHandler(this.chkExclusions_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(991, 597);
            this.Controls.Add(this.chkExclusions);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnExclusions);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.eventList);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.checkRenamed);
            this.Controls.Add(this.checkDeleted);
            this.Controls.Add(this.checkCreated);
            this.Controls.Add(this.checkModified);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox checkModified;
        private System.Windows.Forms.CheckBox checkCreated;
        private System.Windows.Forms.CheckBox checkDeleted;
        private System.Windows.Forms.CheckBox checkRenamed;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListView eventList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.ComponentModel.BackgroundWorker changeEventBackgroundWorker;
        private System.Windows.Forms.Timer extraWorkTimer;
        private System.Windows.Forms.Button btnExclusions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkExclusions;
    }
}

