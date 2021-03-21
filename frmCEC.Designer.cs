namespace CEC
{
    partial class frmCEC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCEC));
            this.mMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileMode = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileModeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileModeFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.MiFileCodePage = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileCodePageAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileCodePageCommon = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileCodePageCJK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelpContents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConversion = new System.Windows.Forms.Button();
            this.cmbConversionFrom = new System.Windows.Forms.ComboBox();
            this.cmbConversionTo = new System.Windows.Forms.ComboBox();
            this.grpConversionOption = new System.Windows.Forms.GroupBox();
            this.chkBig5ToGb2312S = new System.Windows.Forms.CheckBox();
            this.chkGb2312SToBig5 = new System.Windows.Forms.CheckBox();
            this.btnConversionPathBrowser = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtConversionPath = new System.Windows.Forms.TextBox();
            this.lblConversionTo = new System.Windows.Forms.Label();
            this.lblConversionFrom = new System.Windows.Forms.Label();
            this.ofdlgConversionPath = new System.Windows.Forms.OpenFileDialog();
            this.fbdlgConversionPath = new System.Windows.Forms.FolderBrowserDialog();
            this.chkMakeNewFile = new System.Windows.Forms.CheckBox();
            this.grpPreview = new System.Windows.Forms.GroupBox();
            this.chkPreviewDst = new System.Windows.Forms.CheckBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.chkPreviewSrc = new System.Windows.Forms.CheckBox();
            this.mMain.SuspendLayout();
            this.grpConversionOption.SuspendLayout();
            this.grpPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMain
            // 
            this.mMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.helpToolStripMenuItem});
            this.mMain.Location = new System.Drawing.Point(0, 0);
            this.mMain.Name = "mMain";
            this.mMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mMain.Size = new System.Drawing.Size(363, 24);
            this.mMain.TabIndex = 1;
            this.mMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileMode,
            this.MiFileCodePage,
            this.toolStripSeparator,
            this.miFileExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(36, 20);
            this.miFile.Text = "&File";
            // 
            // miFileMode
            // 
            this.miFileMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileModeFile,
            this.miFileModeFolder});
            this.miFileMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miFileMode.Name = "miFileMode";
            this.miFileMode.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.miFileMode.Size = new System.Drawing.Size(136, 22);
            this.miFileMode.Text = "&Mode";
            // 
            // miFileModeFile
            // 
            this.miFileModeFile.Checked = true;
            this.miFileModeFile.CheckOnClick = true;
            this.miFileModeFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miFileModeFile.Name = "miFileModeFile";
            this.miFileModeFile.Size = new System.Drawing.Size(102, 22);
            this.miFileModeFile.Text = "&File";
            this.miFileModeFile.CheckedChanged += new System.EventHandler(this.miFileModeFile_CheckedChanged);
            // 
            // miFileModeFolder
            // 
            this.miFileModeFolder.CheckOnClick = true;
            this.miFileModeFolder.Name = "miFileModeFolder";
            this.miFileModeFolder.Size = new System.Drawing.Size(102, 22);
            this.miFileModeFolder.Text = "F&older";
            this.miFileModeFolder.CheckedChanged += new System.EventHandler(this.miFileModeFolder_CheckedChanged);
            // 
            // MiFileCodePage
            // 
            this.MiFileCodePage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileCodePageAll,
            this.miFileCodePageCommon,
            this.miFileCodePageCJK});
            this.MiFileCodePage.Name = "MiFileCodePage";
            this.MiFileCodePage.Size = new System.Drawing.Size(136, 22);
            this.MiFileCodePage.Text = "&Code Page";
            // 
            // miFileCodePageAll
            // 
            this.miFileCodePageAll.CheckOnClick = true;
            this.miFileCodePageAll.Name = "miFileCodePageAll";
            this.miFileCodePageAll.Size = new System.Drawing.Size(114, 22);
            this.miFileCodePageAll.Text = "&All";
            this.miFileCodePageAll.CheckedChanged += new System.EventHandler(this.miFileCodePageAll_CheckedChanged);
            // 
            // miFileCodePageCommon
            // 
            this.miFileCodePageCommon.Checked = true;
            this.miFileCodePageCommon.CheckOnClick = true;
            this.miFileCodePageCommon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miFileCodePageCommon.Name = "miFileCodePageCommon";
            this.miFileCodePageCommon.Size = new System.Drawing.Size(114, 22);
            this.miFileCodePageCommon.Text = "&Common";
            this.miFileCodePageCommon.CheckedChanged += new System.EventHandler(this.miFileCodePageCommon_CheckedChanged);
            // 
            // miFileCodePageCJK
            // 
            this.miFileCodePageCJK.CheckOnClick = true;
            this.miFileCodePageCJK.Name = "miFileCodePageCJK";
            this.miFileCodePageCJK.Size = new System.Drawing.Size(114, 22);
            this.miFileCodePageCJK.Text = "C&JK ";
            this.miFileCodePageCJK.CheckedChanged += new System.EventHandler(this.miFileCodePageCJK_CheckedChanged);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(133, 6);
            // 
            // miFileExit
            // 
            this.miFileExit.Name = "miFileExit";
            this.miFileExit.Size = new System.Drawing.Size(136, 22);
            this.miFileExit.Text = "E&xit";
            this.miFileExit.Click += new System.EventHandler(this.miFileExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelpContents,
            this.toolStripSeparator5,
            this.miHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // miHelpContents
            // 
            this.miHelpContents.Name = "miHelpContents";
            this.miHelpContents.Size = new System.Drawing.Size(152, 22);
            this.miHelpContents.Text = "&Contents";
            this.miHelpContents.Click += new System.EventHandler(this.miHelpContents_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // miHelpAbout
            // 
            this.miHelpAbout.Name = "miHelpAbout";
            this.miHelpAbout.Size = new System.Drawing.Size(152, 22);
            this.miHelpAbout.Text = "&About...";
            this.miHelpAbout.Click += new System.EventHandler(this.miHelpAbout_Click);
            // 
            // btnConversion
            // 
            this.btnConversion.Location = new System.Drawing.Point(252, 181);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(106, 26);
            this.btnConversion.TabIndex = 2;
            this.btnConversion.Text = "&Conversion";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // cmbConversionFrom
            // 
            this.cmbConversionFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConversionFrom.FormattingEnabled = true;
            this.cmbConversionFrom.Location = new System.Drawing.Point(40, 36);
            this.cmbConversionFrom.Name = "cmbConversionFrom";
            this.cmbConversionFrom.Size = new System.Drawing.Size(304, 20);
            this.cmbConversionFrom.TabIndex = 3;
            // 
            // cmbConversionTo
            // 
            this.cmbConversionTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConversionTo.FormattingEnabled = true;
            this.cmbConversionTo.Location = new System.Drawing.Point(40, 58);
            this.cmbConversionTo.Name = "cmbConversionTo";
            this.cmbConversionTo.Size = new System.Drawing.Size(304, 20);
            this.cmbConversionTo.TabIndex = 4;
            // 
            // grpConversionOption
            // 
            this.grpConversionOption.Controls.Add(this.chkBig5ToGb2312S);
            this.grpConversionOption.Controls.Add(this.chkGb2312SToBig5);
            this.grpConversionOption.Controls.Add(this.btnConversionPathBrowser);
            this.grpConversionOption.Controls.Add(this.lblPath);
            this.grpConversionOption.Controls.Add(this.txtConversionPath);
            this.grpConversionOption.Controls.Add(this.lblConversionTo);
            this.grpConversionOption.Controls.Add(this.lblConversionFrom);
            this.grpConversionOption.Controls.Add(this.cmbConversionFrom);
            this.grpConversionOption.Controls.Add(this.cmbConversionTo);
            this.grpConversionOption.Location = new System.Drawing.Point(6, 27);
            this.grpConversionOption.Name = "grpConversionOption";
            this.grpConversionOption.Size = new System.Drawing.Size(352, 113);
            this.grpConversionOption.TabIndex = 5;
            this.grpConversionOption.TabStop = false;
            this.grpConversionOption.Text = "Conversion Option";
            // 
            // chkBig5ToGb2312S
            // 
            this.chkBig5ToGb2312S.AutoSize = true;
            this.chkBig5ToGb2312S.Location = new System.Drawing.Point(133, 87);
            this.chkBig5ToGb2312S.Name = "chkBig5ToGb2312S";
            this.chkBig5ToGb2312S.Size = new System.Drawing.Size(116, 16);
            this.chkBig5ToGb2312S.TabIndex = 9;
            this.chkBig5ToGb2312S.Text = "BIG5 -> GB2312S";
            this.chkBig5ToGb2312S.UseVisualStyleBackColor = true;
            this.chkBig5ToGb2312S.CheckedChanged += new System.EventHandler(this.chkBig5ToGb2312S_CheckedChanged);
            // 
            // chkGb2312SToBig5
            // 
            this.chkGb2312SToBig5.AutoSize = true;
            this.chkGb2312SToBig5.Location = new System.Drawing.Point(8, 87);
            this.chkGb2312SToBig5.Name = "chkGb2312SToBig5";
            this.chkGb2312SToBig5.Size = new System.Drawing.Size(116, 16);
            this.chkGb2312SToBig5.TabIndex = 8;
            this.chkGb2312SToBig5.Text = "GB2312S -> BIG5";
            this.chkGb2312SToBig5.UseVisualStyleBackColor = true;
            this.chkGb2312SToBig5.CheckedChanged += new System.EventHandler(this.chkGb2312SToBig5_CheckedChanged);
            // 
            // btnConversionPathBrowser
            // 
            this.btnConversionPathBrowser.Location = new System.Drawing.Point(290, 13);
            this.btnConversionPathBrowser.Name = "btnConversionPathBrowser";
            this.btnConversionPathBrowser.Size = new System.Drawing.Size(55, 21);
            this.btnConversionPathBrowser.TabIndex = 7;
            this.btnConversionPathBrowser.Text = "Browser";
            this.btnConversionPathBrowser.UseVisualStyleBackColor = true;
            this.btnConversionPathBrowser.Click += new System.EventHandler(this.btnConversionPathBrowser_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(6, 17);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(28, 12);
            this.lblPath.TabIndex = 7;
            this.lblPath.Text = "Path";
            // 
            // txtConversionPath
            // 
            this.txtConversionPath.Location = new System.Drawing.Point(40, 14);
            this.txtConversionPath.Name = "txtConversionPath";
            this.txtConversionPath.Size = new System.Drawing.Size(252, 19);
            this.txtConversionPath.TabIndex = 6;
            // 
            // lblConversionTo
            // 
            this.lblConversionTo.AutoSize = true;
            this.lblConversionTo.Location = new System.Drawing.Point(6, 61);
            this.lblConversionTo.Name = "lblConversionTo";
            this.lblConversionTo.Size = new System.Drawing.Size(18, 12);
            this.lblConversionTo.TabIndex = 6;
            this.lblConversionTo.Text = "To";
            // 
            // lblConversionFrom
            // 
            this.lblConversionFrom.AutoSize = true;
            this.lblConversionFrom.Location = new System.Drawing.Point(6, 40);
            this.lblConversionFrom.Name = "lblConversionFrom";
            this.lblConversionFrom.Size = new System.Drawing.Size(31, 12);
            this.lblConversionFrom.TabIndex = 5;
            this.lblConversionFrom.Text = "From";
            // 
            // chkMakeNewFile
            // 
            this.chkMakeNewFile.AutoSize = true;
            this.chkMakeNewFile.Location = new System.Drawing.Point(14, 186);
            this.chkMakeNewFile.Name = "chkMakeNewFile";
            this.chkMakeNewFile.Size = new System.Drawing.Size(102, 16);
            this.chkMakeNewFile.TabIndex = 6;
            this.chkMakeNewFile.Text = "Make New File.";
            this.chkMakeNewFile.UseVisualStyleBackColor = true;
            // 
            // grpPreview
            // 
            this.grpPreview.Controls.Add(this.chkPreviewDst);
            this.grpPreview.Controls.Add(this.btnPreview);
            this.grpPreview.Controls.Add(this.chkPreviewSrc);
            this.grpPreview.Location = new System.Drawing.Point(6, 142);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Size = new System.Drawing.Size(352, 36);
            this.grpPreview.TabIndex = 8;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "Preview";
            // 
            // chkPreviewDst
            // 
            this.chkPreviewDst.AutoSize = true;
            this.chkPreviewDst.Location = new System.Drawing.Point(133, 15);
            this.chkPreviewDst.Name = "chkPreviewDst";
            this.chkPreviewDst.Size = new System.Drawing.Size(118, 16);
            this.chkPreviewDst.TabIndex = 8;
            this.chkPreviewDst.Text = "Preview target file";
            this.chkPreviewDst.UseVisualStyleBackColor = true;
            this.chkPreviewDst.CheckedChanged += new System.EventHandler(this.chkPreviewDst_CheckedChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(280, 11);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(66, 20);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // chkPreviewSrc
            // 
            this.chkPreviewSrc.AutoSize = true;
            this.chkPreviewSrc.Location = new System.Drawing.Point(8, 15);
            this.chkPreviewSrc.Name = "chkPreviewSrc";
            this.chkPreviewSrc.Size = new System.Drawing.Size(122, 16);
            this.chkPreviewSrc.TabIndex = 7;
            this.chkPreviewSrc.Text = "Preview source file";
            this.chkPreviewSrc.UseVisualStyleBackColor = true;
            this.chkPreviewSrc.CheckedChanged += new System.EventHandler(this.chkPreviewSrc_CheckedChanged);
            // 
            // frmCEC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(363, 212);
            this.Controls.Add(this.grpPreview);
            this.Controls.Add(this.chkMakeNewFile);
            this.Controls.Add(this.grpConversionOption);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.mMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mMain;
            this.MaximizeBox = false;
            this.Name = "frmCEC";
            this.Text = "Character Encoding Conversion";
            this.Load += new System.EventHandler(this.frmCEC_Load);
            this.mMain.ResumeLayout(false);
            this.mMain.PerformLayout();
            this.grpConversionOption.ResumeLayout(false);
            this.grpConversionOption.PerformLayout();
            this.grpPreview.ResumeLayout(false);
            this.grpPreview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miFileMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem miFileExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miHelpContents;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem miHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem miFileModeFolder;
        private System.Windows.Forms.ToolStripMenuItem miFileModeFile;
        private System.Windows.Forms.Button btnConversion;
        private System.Windows.Forms.ComboBox cmbConversionFrom;
        private System.Windows.Forms.ComboBox cmbConversionTo;
        private System.Windows.Forms.GroupBox grpConversionOption;
        private System.Windows.Forms.Label lblConversionTo;
        private System.Windows.Forms.Label lblConversionFrom;
        private System.Windows.Forms.OpenFileDialog ofdlgConversionPath;
        private System.Windows.Forms.FolderBrowserDialog fbdlgConversionPath;
        private System.Windows.Forms.TextBox txtConversionPath;
        private System.Windows.Forms.Button btnConversionPathBrowser;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.CheckBox chkMakeNewFile;
        private System.Windows.Forms.ToolStripMenuItem MiFileCodePage;
        private System.Windows.Forms.ToolStripMenuItem miFileCodePageAll;
        private System.Windows.Forms.ToolStripMenuItem miFileCodePageCommon;
        private System.Windows.Forms.ToolStripMenuItem miFileCodePageCJK;
        private System.Windows.Forms.CheckBox chkBig5ToGb2312S;
        private System.Windows.Forms.CheckBox chkGb2312SToBig5;
        private System.Windows.Forms.GroupBox grpPreview;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.CheckBox chkPreviewSrc;
        private System.Windows.Forms.CheckBox chkPreviewDst;

    }
}

