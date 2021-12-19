using System.ComponentModel;
using System.Windows.Forms;
using CDBurnerXP.Controls;
using wyDay.Controls;

namespace Ketarin.Forms
{
    partial class ApplicationJobDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationJobDialog));
            this.bCancel = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.txtApplicationName = new System.Windows.Forms.TextBox();
            this.pnlDownloadSource = new System.Windows.Forms.Panel();
            this.lblBetaVersions = new System.Windows.Forms.Label();
            this.pnlBeta = new System.Windows.Forms.Panel();
            this.rbBetaDefault = new System.Windows.Forms.RadioButton();
            this.rbBetaAvoid = new System.Windows.Forms.RadioButton();
            this.rbAlwaysDownload = new System.Windows.Forms.RadioButton();
            this.bVariables = new System.Windows.Forms.Button();
            this.txtFileHippoId = new System.Windows.Forms.TextBox();
            this.rbFileHippo = new System.Windows.Forms.RadioButton();
            this.txtFixedUrl = new Ketarin.Forms.VariableTextBox();
            this.rbFixedUrl = new System.Windows.Forms.RadioButton();
            this.pnlTarget = new System.Windows.Forms.Panel();
            this.bBrowseFile = new System.Windows.Forms.Button();
            this.txtTarget = new Ketarin.Forms.VariableTextBox();
            this.rbFolder = new System.Windows.Forms.RadioButton();
            this.rbFileName = new System.Windows.Forms.RadioButton();
            this.chkDeletePrevious = new System.Windows.Forms.CheckBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new Ketarin.Forms.ApplicationJobDialog.NonValidatingComboBox();
            this.sepTarget = new CDBurnerXP.Controls.Separator();
            this.sepDownload = new CDBurnerXP.Controls.Separator();
            this.chkShareOnline = new System.Windows.Forms.CheckBox();
            this.lblSpoofReferer = new System.Windows.Forms.Label();
            this.txtSpoofReferer = new Ketarin.Forms.VariableTextBox();
            this.tcApplication = new System.Windows.Forms.TabControl();
            this.tpApplication = new System.Windows.Forms.TabPage();
            this.grpBoxRequired = new System.Windows.Forms.GroupBox();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.numNumberOfRevisions = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfRevisions = new System.Windows.Forms.Label();
            this.grpBoxInfo = new System.Windows.Forms.GroupBox();
            this.bAddInstruction = new wyDay.Controls.SplitButton();
            this.cmnuAddInstruction = new System.Windows.Forms.ContextMenu();
            this.mnuStartProcess = new System.Windows.Forms.MenuItem();
            this.mnuCloseProcess = new System.Windows.Forms.MenuItem();
            this.mnuCopyFile = new System.Windows.Forms.MenuItem();
            this.mnuCustomCommand = new System.Windows.Forms.MenuItem();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.instructionsListBox = new CDBurnerXP.Controls.AdvancedListBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.grpBoxOptional = new System.Windows.Forms.GroupBox();
            this.lblHashVariable = new System.Windows.Forms.Label();
            this.sepDownloads = new CDBurnerXP.Controls.Separator();
            this.chkDownloadExclusively = new System.Windows.Forms.CheckBox();
            this.cboHashType = new System.Windows.Forms.ComboBox();
            this.txtUseVariablesForChanges = new System.Windows.Forms.ComboBox();
            this.chkCheckForUpdatesOnly = new System.Windows.Forms.CheckBox();
            this.cboHashVariable = new System.Windows.Forms.ComboBox();
            this.lblUseVariableForChanges = new System.Windows.Forms.Label();
            this.chkIgnoreFileInformation = new System.Windows.Forms.CheckBox();
            this.lblCompareWithHash = new System.Windows.Forms.Label();
            this.txtUserAgent = new Ketarin.Forms.VariableTextBox();
            this.sepUpdateDetection = new CDBurnerXP.Controls.Separator();
            this.lblUserAgent = new System.Windows.Forms.Label();
            this.sepMiscellaneous = new CDBurnerXP.Controls.Separator();
            this.tpCommands = new System.Windows.Forms.TabPage();
            this.tableLayoutCommands = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCommandBefore = new System.Windows.Forms.Panel();
            this.txtExecuteBefore = new Ketarin.Forms.CommandControl();
            this.lblCommandBefore = new System.Windows.Forms.Label();
            this.pnlCommandAfter = new System.Windows.Forms.Panel();
            this.txtExecuteAfter = new Ketarin.Forms.CommandControl();
            this.lblExecuteCommand = new System.Windows.Forms.Label();
            this.bSaveAsDefault = new System.Windows.Forms.Button();
            this.pnlDownloadSource.SuspendLayout();
            this.pnlBeta.SuspendLayout();
            this.pnlTarget.SuspendLayout();
            this.tcApplication.SuspendLayout();
            this.tpApplication.SuspendLayout();
            this.grpBoxRequired.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfRevisions)).BeginInit();
            this.grpBoxInfo.SuspendLayout();
            this.grpBoxOptional.SuspendLayout();
            this.tpCommands.SuspendLayout();
            this.tableLayoutCommands.SuspendLayout();
            this.pnlCommandBefore.SuspendLayout();
            this.pnlCommandAfter.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(959, 887);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 100;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOK
            // 
            this.bOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOK.Location = new System.Drawing.Point(878, 887);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 99;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.AutoSize = true;
            this.lblApplicationName.Location = new System.Drawing.Point(6, 34);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(100, 13);
            this.lblApplicationName.TabIndex = 0;
            this.lblApplicationName.Text = "&Application name:";
            // 
            // txtApplicationName
            // 
            this.txtApplicationName.Location = new System.Drawing.Point(112, 31);
            this.txtApplicationName.MaxLength = 255;
            this.txtApplicationName.Name = "txtApplicationName";
            this.txtApplicationName.Size = new System.Drawing.Size(139, 22);
            this.txtApplicationName.TabIndex = 1;
            // 
            // pnlDownloadSource
            // 
            this.pnlDownloadSource.Controls.Add(this.lblBetaVersions);
            this.pnlDownloadSource.Controls.Add(this.pnlBeta);
            this.pnlDownloadSource.Controls.Add(this.bVariables);
            this.pnlDownloadSource.Controls.Add(this.txtFileHippoId);
            this.pnlDownloadSource.Controls.Add(this.rbFileHippo);
            this.pnlDownloadSource.Controls.Add(this.txtFixedUrl);
            this.pnlDownloadSource.Controls.Add(this.rbFixedUrl);
            this.pnlDownloadSource.Location = new System.Drawing.Point(10, 131);
            this.pnlDownloadSource.Name = "pnlDownloadSource";
            this.pnlDownloadSource.Size = new System.Drawing.Size(479, 80);
            this.pnlDownloadSource.TabIndex = 6;
            // 
            // lblBetaVersions
            // 
            this.lblBetaVersions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBetaVersions.AutoSize = true;
            this.lblBetaVersions.Location = new System.Drawing.Point(-2, 55);
            this.lblBetaVersions.Name = "lblBetaVersions";
            this.lblBetaVersions.Size = new System.Drawing.Size(77, 13);
            this.lblBetaVersions.TabIndex = 25;
            this.lblBetaVersions.Text = "&Beta versions:";
            // 
            // pnlBeta
            // 
            this.pnlBeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBeta.Controls.Add(this.rbBetaDefault);
            this.pnlBeta.Controls.Add(this.rbBetaAvoid);
            this.pnlBeta.Controls.Add(this.rbAlwaysDownload);
            this.pnlBeta.Location = new System.Drawing.Point(97, 53);
            this.pnlBeta.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBeta.Name = "pnlBeta";
            this.pnlBeta.Size = new System.Drawing.Size(243, 18);
            this.pnlBeta.TabIndex = 16;
            // 
            // rbBetaDefault
            // 
            this.rbBetaDefault.AutoSize = true;
            this.rbBetaDefault.Checked = true;
            this.rbBetaDefault.Location = new System.Drawing.Point(27, 0);
            this.rbBetaDefault.Name = "rbBetaDefault";
            this.rbBetaDefault.Size = new System.Drawing.Size(69, 17);
            this.rbBetaDefault.TabIndex = 26;
            this.rbBetaDefault.TabStop = true;
            this.rbBetaDefault.Text = "(&Default)";
            this.rbBetaDefault.UseVisualStyleBackColor = true;
            // 
            // rbBetaAvoid
            // 
            this.rbBetaAvoid.AutoSize = true;
            this.rbBetaAvoid.Location = new System.Drawing.Point(99, 0);
            this.rbBetaAvoid.Name = "rbBetaAvoid";
            this.rbBetaAvoid.Size = new System.Drawing.Size(54, 17);
            this.rbBetaAvoid.TabIndex = 27;
            this.rbBetaAvoid.Text = "A&void";
            this.rbBetaAvoid.UseVisualStyleBackColor = true;
            // 
            // rbAlwaysDownload
            // 
            this.rbAlwaysDownload.AutoSize = true;
            this.rbAlwaysDownload.Location = new System.Drawing.Point(160, 0);
            this.rbAlwaysDownload.Name = "rbAlwaysDownload";
            this.rbAlwaysDownload.Size = new System.Drawing.Size(79, 17);
            this.rbAlwaysDownload.TabIndex = 28;
            this.rbAlwaysDownload.Text = "Do&wnload";
            this.rbAlwaysDownload.UseVisualStyleBackColor = true;
            // 
            // bVariables
            // 
            this.bVariables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bVariables.Location = new System.Drawing.Point(265, 4);
            this.bVariables.Name = "bVariables";
            this.bVariables.Size = new System.Drawing.Size(75, 23);
            this.bVariables.TabIndex = 13;
            this.bVariables.Text = "&Variables";
            this.bVariables.UseVisualStyleBackColor = true;
            this.bVariables.Click += new System.EventHandler(this.bVariables_Click);
            // 
            // txtFileHippoId
            // 
            this.txtFileHippoId.Location = new System.Drawing.Point(113, 32);
            this.txtFileHippoId.Name = "txtFileHippoId";
            this.txtFileHippoId.Size = new System.Drawing.Size(136, 22);
            this.txtFileHippoId.TabIndex = 15;
            this.txtFileHippoId.TextChanged += new System.EventHandler(this.txtFileHippoId_TextChanged);
            this.txtFileHippoId.LostFocus += new System.EventHandler(this.txtFileHippoId_LostFocus);
            // 
            // rbFileHippo
            // 
            this.rbFileHippo.AutoSize = true;
            this.rbFileHippo.Location = new System.Drawing.Point(21, 33);
            this.rbFileHippo.Name = "rbFileHippo";
            this.rbFileHippo.Size = new System.Drawing.Size(92, 17);
            this.rbFileHippo.TabIndex = 14;
            this.rbFileHippo.Text = "File&Hippo ID:";
            this.rbFileHippo.UseVisualStyleBackColor = true;
            this.rbFileHippo.CheckedChanged += new System.EventHandler(this.rbFileHippo_CheckedChanged);
            // 
            // txtFixedUrl
            // 
            this.txtFixedUrl.Location = new System.Drawing.Point(113, 3);
            this.txtFixedUrl.Name = "txtFixedUrl";
            this.txtFixedUrl.Size = new System.Drawing.Size(136, 22);
            this.txtFixedUrl.TabIndex = 12;
            this.txtFixedUrl.TextChanged += new System.EventHandler(this.txtFixedUrl_TextChanged);
            // 
            // rbFixedUrl
            // 
            this.rbFixedUrl.AutoSize = true;
            this.rbFixedUrl.Checked = true;
            this.rbFixedUrl.Location = new System.Drawing.Point(21, 4);
            this.rbFixedUrl.Name = "rbFixedUrl";
            this.rbFixedUrl.Size = new System.Drawing.Size(48, 17);
            this.rbFixedUrl.TabIndex = 11;
            this.rbFixedUrl.TabStop = true;
            this.rbFixedUrl.Text = "&URL:";
            this.rbFixedUrl.UseVisualStyleBackColor = true;
            this.rbFixedUrl.CheckedChanged += new System.EventHandler(this.rbFixedUrl_CheckedChanged);
            // 
            // pnlTarget
            // 
            this.pnlTarget.Controls.Add(this.bBrowseFile);
            this.pnlTarget.Controls.Add(this.txtTarget);
            this.pnlTarget.Controls.Add(this.rbFolder);
            this.pnlTarget.Controls.Add(this.rbFileName);
            this.pnlTarget.Location = new System.Drawing.Point(5, 232);
            this.pnlTarget.Name = "pnlTarget";
            this.pnlTarget.Size = new System.Drawing.Size(390, 53);
            this.pnlTarget.TabIndex = 8;
            // 
            // bBrowseFile
            // 
            this.bBrowseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bBrowseFile.Location = new System.Drawing.Point(358, 26);
            this.bBrowseFile.Name = "bBrowseFile";
            this.bBrowseFile.Size = new System.Drawing.Size(32, 23);
            this.bBrowseFile.TabIndex = 24;
            this.bBrowseFile.Text = "...";
            this.bBrowseFile.UseVisualStyleBackColor = true;
            this.bBrowseFile.Click += new System.EventHandler(this.bBrowseFile_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarget.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTarget.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtTarget.Location = new System.Drawing.Point(4, 26);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(348, 22);
            this.txtTarget.TabIndex = 23;
            this.txtTarget.Text = "%TEMP%\\";
            // 
            // rbFolder
            // 
            this.rbFolder.AutoSize = true;
            this.rbFolder.Checked = true;
            this.rbFolder.Location = new System.Drawing.Point(87, 3);
            this.rbFolder.Name = "rbFolder";
            this.rbFolder.Size = new System.Drawing.Size(95, 17);
            this.rbFolder.TabIndex = 22;
            this.rbFolder.TabStop = true;
            this.rbFolder.Text = "Save in f&older";
            this.rbFolder.UseVisualStyleBackColor = true;
            this.rbFolder.CheckedChanged += new System.EventHandler(this.rbDirectory_CheckedChanged);
            // 
            // rbFileName
            // 
            this.rbFileName.AutoSize = true;
            this.rbFileName.Location = new System.Drawing.Point(3, 3);
            this.rbFileName.Name = "rbFileName";
            this.rbFileName.Size = new System.Drawing.Size(81, 17);
            this.rbFileName.TabIndex = 21;
            this.rbFileName.Text = "&Save to file";
            this.rbFileName.UseVisualStyleBackColor = true;
            this.rbFileName.CheckedChanged += new System.EventHandler(this.rbFileName_CheckedChanged);
            // 
            // chkDeletePrevious
            // 
            this.chkDeletePrevious.AutoSize = true;
            this.chkDeletePrevious.Checked = true;
            this.chkDeletePrevious.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeletePrevious.Location = new System.Drawing.Point(24, 407);
            this.chkDeletePrevious.Name = "chkDeletePrevious";
            this.chkDeletePrevious.Size = new System.Drawing.Size(239, 17);
            this.chkDeletePrevious.TabIndex = 17;
            this.chkDeletePrevious.Text = "Always &delete previously downloaded file";
            this.chkDeletePrevious.UseVisualStyleBackColor = true;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(7, 60);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(56, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "&Category:";
            // 
            // cboCategory
            // 
            this.cboCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(112, 57);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(139, 21);
            this.cboCategory.TabIndex = 3;
            // 
            // sepTarget
            // 
            this.sepTarget.Location = new System.Drawing.Point(5, 209);
            this.sepTarget.Name = "sepTarget";
            this.sepTarget.Size = new System.Drawing.Size(428, 23);
            this.sepTarget.TabIndex = 7;
            this.sepTarget.Text = "Download location";
            // 
            // sepDownload
            // 
            this.sepDownload.Location = new System.Drawing.Point(5, 105);
            this.sepDownload.Name = "sepDownload";
            this.sepDownload.Size = new System.Drawing.Size(291, 23);
            this.sepDownload.TabIndex = 5;
            this.sepDownload.Text = "Download source";
            // 
            // chkShareOnline
            // 
            this.chkShareOnline.AutoSize = true;
            this.chkShareOnline.Location = new System.Drawing.Point(24, 384);
            this.chkShareOnline.Name = "chkShareOnline";
            this.chkShareOnline.Size = new System.Drawing.Size(236, 17);
            this.chkShareOnline.TabIndex = 16;
            this.chkShareOnline.Text = "Sh&are this application online with others";
            this.chkShareOnline.UseVisualStyleBackColor = true;
            // 
            // lblSpoofReferer
            // 
            this.lblSpoofReferer.AutoSize = true;
            this.lblSpoofReferer.Location = new System.Drawing.Point(21, 137);
            this.lblSpoofReferer.Name = "lblSpoofReferer";
            this.lblSpoofReferer.Size = new System.Drawing.Size(107, 13);
            this.lblSpoofReferer.TabIndex = 3;
            this.lblSpoofReferer.Text = "Sp&oof HTTP referer:";
            // 
            // txtSpoofReferer
            // 
            this.txtSpoofReferer.Location = new System.Drawing.Point(130, 134);
            this.txtSpoofReferer.Name = "txtSpoofReferer";
            this.txtSpoofReferer.Size = new System.Drawing.Size(287, 22);
            this.txtSpoofReferer.TabIndex = 4;
            // 
            // tcApplication
            // 
            this.tcApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tcApplication.Controls.Add(this.tpApplication);
            this.tcApplication.Controls.Add(this.tpCommands);
            this.tcApplication.Location = new System.Drawing.Point(12, 12);
            this.tcApplication.Name = "tcApplication";
            this.tcApplication.SelectedIndex = 0;
            this.tcApplication.Size = new System.Drawing.Size(1047, 869);
            this.tcApplication.TabIndex = 0;
            // 
            // tpApplication
            // 
            this.tpApplication.Controls.Add(this.grpBoxRequired);
            this.tpApplication.Controls.Add(this.grpBoxInfo);
            this.tpApplication.Controls.Add(this.grpBoxOptional);
            this.tpApplication.Location = new System.Drawing.Point(4, 22);
            this.tpApplication.Name = "tpApplication";
            this.tpApplication.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplication.Size = new System.Drawing.Size(1039, 843);
            this.tpApplication.TabIndex = 0;
            this.tpApplication.Text = "App Settings ";
            this.tpApplication.UseVisualStyleBackColor = true;
            // 
            // grpBoxRequired
            // 
            this.grpBoxRequired.Controls.Add(this.lblApplicationName);
            this.grpBoxRequired.Controls.Add(this.sepDownload);
            this.grpBoxRequired.Controls.Add(this.chkEnabled);
            this.grpBoxRequired.Controls.Add(this.pnlTarget);
            this.grpBoxRequired.Controls.Add(this.numNumberOfRevisions);
            this.grpBoxRequired.Controls.Add(this.txtApplicationName);
            this.grpBoxRequired.Controls.Add(this.lblCategory);
            this.grpBoxRequired.Controls.Add(this.cboCategory);
            this.grpBoxRequired.Controls.Add(this.sepTarget);
            this.grpBoxRequired.Controls.Add(this.lblNumberOfRevisions);
            this.grpBoxRequired.Controls.Add(this.pnlDownloadSource);
            this.grpBoxRequired.Location = new System.Drawing.Point(30, 23);
            this.grpBoxRequired.Name = "grpBoxRequired";
            this.grpBoxRequired.Size = new System.Drawing.Size(495, 341);
            this.grpBoxRequired.TabIndex = 13;
            this.grpBoxRequired.TabStop = false;
            this.grpBoxRequired.Text = " Required ";
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Checked = true;
            this.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnabled.Location = new System.Drawing.Point(9, 84);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(68, 17);
            this.chkEnabled.TabIndex = 4;
            this.chkEnabled.Text = "&Enabled";
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // numNumberOfRevisions
            // 
            this.numNumberOfRevisions.Location = new System.Drawing.Point(266, 300);
            this.numNumberOfRevisions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberOfRevisions.Name = "numNumberOfRevisions";
            this.numNumberOfRevisions.Size = new System.Drawing.Size(53, 22);
            this.numNumberOfRevisions.TabIndex = 10;
            this.numNumberOfRevisions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumberOfRevisions
            // 
            this.lblNumberOfRevisions.AutoSize = true;
            this.lblNumberOfRevisions.Location = new System.Drawing.Point(-4, 303);
            this.lblNumberOfRevisions.Name = "lblNumberOfRevisions";
            this.lblNumberOfRevisions.Size = new System.Drawing.Size(264, 13);
            this.lblNumberOfRevisions.TabIndex = 9;
            this.lblNumberOfRevisions.Text = "Total &number of files to keep (original + backups):";
            // 
            // grpBoxInfo
            // 
            this.grpBoxInfo.Controls.Add(this.bAddInstruction);
            this.grpBoxInfo.Controls.Add(this.txtNotes);
            this.grpBoxInfo.Controls.Add(this.lblWebsite);
            this.grpBoxInfo.Controls.Add(this.label1);
            this.grpBoxInfo.Controls.Add(this.instructionsListBox);
            this.grpBoxInfo.Controls.Add(this.txtWebsite);
            this.grpBoxInfo.Controls.Add(this.lblNotes);
            this.grpBoxInfo.Location = new System.Drawing.Point(29, 389);
            this.grpBoxInfo.Name = "grpBoxInfo";
            this.grpBoxInfo.Size = new System.Drawing.Size(497, 425);
            this.grpBoxInfo.TabIndex = 12;
            this.grpBoxInfo.TabStop = false;
            this.grpBoxInfo.Text = " Info ";
            // 
            // bAddInstruction
            // 
            this.bAddInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAddInstruction.AutoSize = true;
            this.bAddInstruction.Location = new System.Drawing.Point(363, 374);
            this.bAddInstruction.Name = "bAddInstruction";
            this.bAddInstruction.SeparateDropdownButton = false;
            this.bAddInstruction.Size = new System.Drawing.Size(115, 23);
            this.bAddInstruction.SplitMenu = this.cmnuAddInstruction;
            this.bAddInstruction.TabIndex = 3;
            this.bAddInstruction.Text = "Add instruction";
            this.bAddInstruction.UseVisualStyleBackColor = true;
            // 
            // cmnuAddInstruction
            // 
            this.cmnuAddInstruction.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuStartProcess,
            this.mnuCloseProcess,
            this.mnuCopyFile,
            this.mnuCustomCommand});
            // 
            // mnuStartProcess
            // 
            this.mnuStartProcess.Index = 0;
            this.mnuStartProcess.Text = "&Start process...";
            this.mnuStartProcess.Click += new System.EventHandler(this.mnuStartProcess_Click);
            // 
            // mnuCloseProcess
            // 
            this.mnuCloseProcess.Index = 1;
            this.mnuCloseProcess.Text = "Cl&ose process...";
            this.mnuCloseProcess.Click += new System.EventHandler(this.mnuCloseProcess_Click);
            // 
            // mnuCopyFile
            // 
            this.mnuCopyFile.Index = 2;
            this.mnuCopyFile.Text = "&Copy file...";
            this.mnuCopyFile.Click += new System.EventHandler(this.mnuCopyFile_Click);
            // 
            // mnuCustomCommand
            // 
            this.mnuCustomCommand.Index = 3;
            this.mnuCustomCommand.Text = "C&ustom command...";
            this.mnuCustomCommand.Click += new System.EventHandler(this.mnuCustomCommand_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(24, 81);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(454, 128);
            this.txtNotes.TabIndex = 4;
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(21, 36);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(52, 13);
            this.lblWebsite.TabIndex = 0;
            this.lblWebsite.Text = "&Website:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "I&nstructions to follow for setup:";
            // 
            // instructionsListBox
            // 
            this.instructionsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionsListBox.AutoScroll = true;
            this.instructionsListBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructionsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructionsListBox.Location = new System.Drawing.Point(24, 223);
            this.instructionsListBox.Name = "instructionsListBox";
            this.instructionsListBox.SelectedPanel = null;
            this.instructionsListBox.Size = new System.Drawing.Size(454, 127);
            this.instructionsListBox.TabIndex = 0;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebsite.Location = new System.Drawing.Point(76, 33);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(402, 22);
            this.txtWebsite.TabIndex = 1;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(21, 65);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(40, 13);
            this.lblNotes.TabIndex = 3;
            this.lblNotes.Text = "N&otes:";
            // 
            // grpBoxOptional
            // 
            this.grpBoxOptional.Controls.Add(this.lblHashVariable);
            this.grpBoxOptional.Controls.Add(this.sepDownloads);
            this.grpBoxOptional.Controls.Add(this.chkDownloadExclusively);
            this.grpBoxOptional.Controls.Add(this.cboHashType);
            this.grpBoxOptional.Controls.Add(this.txtUseVariablesForChanges);
            this.grpBoxOptional.Controls.Add(this.chkCheckForUpdatesOnly);
            this.grpBoxOptional.Controls.Add(this.cboHashVariable);
            this.grpBoxOptional.Controls.Add(this.lblUseVariableForChanges);
            this.grpBoxOptional.Controls.Add(this.chkIgnoreFileInformation);
            this.grpBoxOptional.Controls.Add(this.lblCompareWithHash);
            this.grpBoxOptional.Controls.Add(this.chkDeletePrevious);
            this.grpBoxOptional.Controls.Add(this.txtSpoofReferer);
            this.grpBoxOptional.Controls.Add(this.txtUserAgent);
            this.grpBoxOptional.Controls.Add(this.sepUpdateDetection);
            this.grpBoxOptional.Controls.Add(this.chkShareOnline);
            this.grpBoxOptional.Controls.Add(this.lblUserAgent);
            this.grpBoxOptional.Controls.Add(this.sepMiscellaneous);
            this.grpBoxOptional.Controls.Add(this.lblSpoofReferer);
            this.grpBoxOptional.Location = new System.Drawing.Point(566, 21);
            this.grpBoxOptional.Name = "grpBoxOptional";
            this.grpBoxOptional.Size = new System.Drawing.Size(452, 446);
            this.grpBoxOptional.TabIndex = 11;
            this.grpBoxOptional.TabStop = false;
            this.grpBoxOptional.Text = " Optional ";
            // 
            // lblHashVariable
            // 
            this.lblHashVariable.AutoSize = true;
            this.lblHashVariable.Location = new System.Drawing.Point(242, 303);
            this.lblHashVariable.Name = "lblHashVariable";
            this.lblHashVariable.Size = new System.Drawing.Size(51, 13);
            this.lblHashVariable.TabIndex = 13;
            this.lblHashVariable.Text = "&Variable:";
            // 
            // sepDownloads
            // 
            this.sepDownloads.Location = new System.Drawing.Point(6, 36);
            this.sepDownloads.Name = "sepDownloads";
            this.sepDownloads.Size = new System.Drawing.Size(407, 23);
            this.sepDownloads.TabIndex = 0;
            this.sepDownloads.Text = "&Downloading";
            // 
            // chkDownloadExclusively
            // 
            this.chkDownloadExclusively.AutoSize = true;
            this.chkDownloadExclusively.Location = new System.Drawing.Point(24, 80);
            this.chkDownloadExclusively.Name = "chkDownloadExclusively";
            this.chkDownloadExclusively.Size = new System.Drawing.Size(404, 17);
            this.chkDownloadExclusively.TabIndex = 1;
            this.chkDownloadExclusively.Text = "Do not download this application &simultaneously with other applications";
            this.chkDownloadExclusively.UseVisualStyleBackColor = true;
            // 
            // cboHashType
            // 
            this.cboHashType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHashType.FormattingEnabled = true;
            this.cboHashType.Items.AddRange(new object[] {
            "(None)",
            "MD5",
            "CRC32",
            "SHA1",
            "SHA256",
            "SHA512"});
            this.cboHashType.Location = new System.Drawing.Point(167, 300);
            this.cboHashType.Name = "cboHashType";
            this.cboHashType.Size = new System.Drawing.Size(65, 21);
            this.cboHashType.TabIndex = 12;
            // 
            // txtUseVariablesForChanges
            // 
            this.txtUseVariablesForChanges.Location = new System.Drawing.Point(299, 273);
            this.txtUseVariablesForChanges.Name = "txtUseVariablesForChanges";
            this.txtUseVariablesForChanges.Size = new System.Drawing.Size(50, 21);
            this.txtUseVariablesForChanges.TabIndex = 10;
            // 
            // chkCheckForUpdatesOnly
            // 
            this.chkCheckForUpdatesOnly.AutoSize = true;
            this.chkCheckForUpdatesOnly.Location = new System.Drawing.Point(24, 103);
            this.chkCheckForUpdatesOnly.Name = "chkCheckForUpdatesOnly";
            this.chkCheckForUpdatesOnly.Size = new System.Drawing.Size(244, 17);
            this.chkCheckForUpdatesOnly.TabIndex = 2;
            this.chkCheckForUpdatesOnly.Text = "Do not download; &check for updates only.";
            this.chkCheckForUpdatesOnly.UseVisualStyleBackColor = true;
            // 
            // cboHashVariable
            // 
            this.cboHashVariable.Location = new System.Drawing.Point(299, 302);
            this.cboHashVariable.Name = "cboHashVariable";
            this.cboHashVariable.Size = new System.Drawing.Size(50, 21);
            this.cboHashVariable.TabIndex = 14;
            // 
            // lblUseVariableForChanges
            // 
            this.lblUseVariableForChanges.AutoSize = true;
            this.lblUseVariableForChanges.Location = new System.Drawing.Point(21, 276);
            this.lblUseVariableForChanges.Name = "lblUseVariableForChanges";
            this.lblUseVariableForChanges.Size = new System.Drawing.Size(272, 13);
            this.lblUseVariableForChanges.TabIndex = 9;
            this.lblUseVariableForChanges.Text = "&Use the following variable as indicator for changes:";
            // 
            // chkIgnoreFileInformation
            // 
            this.chkIgnoreFileInformation.AutoSize = true;
            this.chkIgnoreFileInformation.Location = new System.Drawing.Point(24, 250);
            this.chkIgnoreFileInformation.Name = "chkIgnoreFileInformation";
            this.chkIgnoreFileInformation.Size = new System.Drawing.Size(339, 17);
            this.chkIgnoreFileInformation.TabIndex = 8;
            this.chkIgnoreFileInformation.Text = "Ignore file infor&mation (do not re-download if file is missing)";
            this.chkIgnoreFileInformation.UseVisualStyleBackColor = true;
            // 
            // lblCompareWithHash
            // 
            this.lblCompareWithHash.AutoSize = true;
            this.lblCompareWithHash.Location = new System.Drawing.Point(21, 303);
            this.lblCompareWithHash.Name = "lblCompareWithHash";
            this.lblCompareWithHash.Size = new System.Drawing.Size(140, 13);
            this.lblCompareWithHash.TabIndex = 11;
            this.lblCompareWithHash.Text = "Compare with &hash value:";
            // 
            // txtUserAgent
            // 
            this.txtUserAgent.Location = new System.Drawing.Point(130, 160);
            this.txtUserAgent.Name = "txtUserAgent";
            this.txtUserAgent.Size = new System.Drawing.Size(287, 22);
            this.txtUserAgent.TabIndex = 6;
            // 
            // sepUpdateDetection
            // 
            this.sepUpdateDetection.Location = new System.Drawing.Point(5, 208);
            this.sepUpdateDetection.Name = "sepUpdateDetection";
            this.sepUpdateDetection.Size = new System.Drawing.Size(397, 23);
            this.sepUpdateDetection.TabIndex = 7;
            this.sepUpdateDetection.Text = "Update detection";
            // 
            // lblUserAgent
            // 
            this.lblUserAgent.AutoSize = true;
            this.lblUserAgent.Location = new System.Drawing.Point(21, 163);
            this.lblUserAgent.Name = "lblUserAgent";
            this.lblUserAgent.Size = new System.Drawing.Size(67, 13);
            this.lblUserAgent.TabIndex = 5;
            this.lblUserAgent.Text = "User Age&nt:";
            // 
            // sepMiscellaneous
            // 
            this.sepMiscellaneous.Location = new System.Drawing.Point(6, 348);
            this.sepMiscellaneous.Name = "sepMiscellaneous";
            this.sepMiscellaneous.Size = new System.Drawing.Size(396, 23);
            this.sepMiscellaneous.TabIndex = 15;
            this.sepMiscellaneous.Text = "Miscellaneous";
            // 
            // tpCommands
            // 
            this.tpCommands.Controls.Add(this.tableLayoutCommands);
            this.tpCommands.Location = new System.Drawing.Point(4, 22);
            this.tpCommands.Name = "tpCommands";
            this.tpCommands.Size = new System.Drawing.Size(1039, 843);
            this.tpCommands.TabIndex = 2;
            this.tpCommands.Text = "Commands";
            this.tpCommands.UseVisualStyleBackColor = true;
            // 
            // tableLayoutCommands
            // 
            this.tableLayoutCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutCommands.ColumnCount = 1;
            this.tableLayoutCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutCommands.Controls.Add(this.pnlCommandBefore, 0, 0);
            this.tableLayoutCommands.Controls.Add(this.pnlCommandAfter, 0, 1);
            this.tableLayoutCommands.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutCommands.Name = "tableLayoutCommands";
            this.tableLayoutCommands.RowCount = 2;
            this.tableLayoutCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutCommands.Size = new System.Drawing.Size(425, 342);
            this.tableLayoutCommands.TabIndex = 4;
            // 
            // pnlCommandBefore
            // 
            this.pnlCommandBefore.Controls.Add(this.txtExecuteBefore);
            this.pnlCommandBefore.Controls.Add(this.lblCommandBefore);
            this.pnlCommandBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCommandBefore.Location = new System.Drawing.Point(0, 3);
            this.pnlCommandBefore.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pnlCommandBefore.Name = "pnlCommandBefore";
            this.pnlCommandBefore.Size = new System.Drawing.Size(422, 165);
            this.pnlCommandBefore.TabIndex = 0;
            // 
            // txtExecuteBefore
            // 
            this.txtExecuteBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExecuteBefore.Application = null;
            this.txtExecuteBefore.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExecuteBefore.Location = new System.Drawing.Point(0, 16);
            this.txtExecuteBefore.Margin = new System.Windows.Forms.Padding(0);
            this.txtExecuteBefore.Name = "txtExecuteBefore";
            this.txtExecuteBefore.ShowBorder = false;
            this.txtExecuteBefore.Size = new System.Drawing.Size(422, 146);
            this.txtExecuteBefore.TabIndex = 1;
            this.txtExecuteBefore.VariableNames = new string[0];
            // 
            // lblCommandBefore
            // 
            this.lblCommandBefore.AutoSize = true;
            this.lblCommandBefore.Location = new System.Drawing.Point(-3, 0);
            this.lblCommandBefore.Name = "lblCommandBefore";
            this.lblCommandBefore.Size = new System.Drawing.Size(285, 13);
            this.lblCommandBefore.TabIndex = 0;
            this.lblCommandBefore.Text = "Execute the following command &before downloading:";
            // 
            // pnlCommandAfter
            // 
            this.pnlCommandAfter.Controls.Add(this.txtExecuteAfter);
            this.pnlCommandAfter.Controls.Add(this.lblExecuteCommand);
            this.pnlCommandAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCommandAfter.Location = new System.Drawing.Point(0, 171);
            this.pnlCommandAfter.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.pnlCommandAfter.Name = "pnlCommandAfter";
            this.pnlCommandAfter.Size = new System.Drawing.Size(422, 171);
            this.pnlCommandAfter.TabIndex = 1;
            // 
            // txtExecuteAfter
            // 
            this.txtExecuteAfter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExecuteAfter.Application = null;
            this.txtExecuteAfter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExecuteAfter.Location = new System.Drawing.Point(0, 21);
            this.txtExecuteAfter.Margin = new System.Windows.Forms.Padding(0);
            this.txtExecuteAfter.Name = "txtExecuteAfter";
            this.txtExecuteAfter.ShowBorder = false;
            this.txtExecuteAfter.Size = new System.Drawing.Size(422, 150);
            this.txtExecuteAfter.TabIndex = 3;
            this.txtExecuteAfter.VariableNames = new string[0];
            // 
            // lblExecuteCommand
            // 
            this.lblExecuteCommand.AutoSize = true;
            this.lblExecuteCommand.Location = new System.Drawing.Point(-3, 5);
            this.lblExecuteCommand.Name = "lblExecuteCommand";
            this.lblExecuteCommand.Size = new System.Drawing.Size(275, 13);
            this.lblExecuteCommand.TabIndex = 2;
            this.lblExecuteCommand.Text = "Execute the following command &after downloading:";
            // 
            // bSaveAsDefault
            // 
            this.bSaveAsDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bSaveAsDefault.Location = new System.Drawing.Point(32, 887);
            this.bSaveAsDefault.Name = "bSaveAsDefault";
            this.bSaveAsDefault.Size = new System.Drawing.Size(99, 23);
            this.bSaveAsDefault.TabIndex = 98;
            this.bSaveAsDefault.Text = "Save as &default";
            this.bSaveAsDefault.UseVisualStyleBackColor = true;
            this.bSaveAsDefault.Click += new System.EventHandler(this.bSaveAsDefault_Click);
            // 
            // ApplicationJobDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 940);
            this.Controls.Add(this.bSaveAsDefault);
            this.Controls.Add(this.tcApplication);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOK);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(423, 429);
            this.Name = "ApplicationJobDialog";
            this.SavePosition = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add App";
            this.pnlDownloadSource.ResumeLayout(false);
            this.pnlDownloadSource.PerformLayout();
            this.pnlBeta.ResumeLayout(false);
            this.pnlBeta.PerformLayout();
            this.pnlTarget.ResumeLayout(false);
            this.pnlTarget.PerformLayout();
            this.tcApplication.ResumeLayout(false);
            this.tpApplication.ResumeLayout(false);
            this.grpBoxRequired.ResumeLayout(false);
            this.grpBoxRequired.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfRevisions)).EndInit();
            this.grpBoxInfo.ResumeLayout(false);
            this.grpBoxInfo.PerformLayout();
            this.grpBoxOptional.ResumeLayout(false);
            this.grpBoxOptional.PerformLayout();
            this.tpCommands.ResumeLayout(false);
            this.tableLayoutCommands.ResumeLayout(false);
            this.pnlCommandBefore.ResumeLayout(false);
            this.pnlCommandBefore.PerformLayout();
            this.pnlCommandAfter.ResumeLayout(false);
            this.pnlCommandAfter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bCancel;
        private Button bOK;
        private Label lblApplicationName;
        private System.Windows.Forms.TextBox txtApplicationName;
        private Panel pnlDownloadSource;
        private VariableTextBox txtFixedUrl;
        private RadioButton rbFixedUrl;
        private Separator sepDownload;
        private Panel pnlTarget;
        private RadioButton rbFolder;
        private RadioButton rbFileName;
        private Separator sepTarget;
        private VariableTextBox txtTarget;
        private Button bBrowseFile;
        private System.Windows.Forms.TextBox txtFileHippoId;
        private RadioButton rbFileHippo;
        private CheckBox chkDeletePrevious;
        private Button bVariables;
        private Label lblCategory;
        private NonValidatingComboBox cboCategory;
        private CheckBox chkShareOnline;
        private Label lblSpoofReferer;
        private VariableTextBox txtSpoofReferer;
        private TabControl tcApplication;
        private TabPage tpApplication;
        private Label lblUseVariableForChanges;
        private ComboBox txtUseVariablesForChanges;
        private TabPage tpCommands;
        private Label lblCommandBefore;
        private Label lblExecuteCommand;
        private CheckBox chkDownloadExclusively;
        private Button bSaveAsDefault;
        private CheckBox chkCheckForUpdatesOnly;
        private CheckBox chkIgnoreFileInformation;
        private Label lblNotes;
        private System.Windows.Forms.TextBox txtWebsite;
        private Label lblWebsite;
        private System.Windows.Forms.TextBox txtNotes;
        private SplitButton bAddInstruction;
        private Label label1;
        private AdvancedListBox instructionsListBox;
        private ContextMenu cmnuAddInstruction;
        private MenuItem mnuCopyFile;
        private MenuItem mnuCustomCommand;
        private MenuItem mnuStartProcess;
        private TableLayoutPanel tableLayoutCommands;
        private Panel pnlCommandBefore;
        private Panel pnlCommandAfter;
        private Separator sepMiscellaneous;
        private Separator sepUpdateDetection;
        private Separator sepDownloads;
        private Panel pnlBeta;
        private RadioButton rbBetaAvoid;
        private RadioButton rbAlwaysDownload;
        private Label lblBetaVersions;
        private RadioButton rbBetaDefault;
        private VariableTextBox txtUserAgent;
        private Label lblUserAgent;
        private CommandControl txtExecuteBefore;
        private CommandControl txtExecuteAfter;
        private MenuItem mnuCloseProcess;
        private CheckBox chkEnabled;
        private Label lblHashVariable;
        private ComboBox cboHashType;
        private ComboBox cboHashVariable;
        private Label lblCompareWithHash;
        private NumericUpDown numNumberOfRevisions;
        private Label lblNumberOfRevisions;
        private GroupBox grpBoxInfo;
        private GroupBox grpBoxOptional;
        private GroupBox grpBoxRequired;
    }
}