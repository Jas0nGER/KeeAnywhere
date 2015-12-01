﻿namespace KeeAnywhere.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.m_bannerImage = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.m_tabAccounts = new System.Windows.Forms.TabPage();
            this.m_btnAccountRemove = new System.Windows.Forms.Button();
            this.m_btnAccountAdd = new System.Windows.Forms.Button();
            this.m_lvAccounts = new System.Windows.Forms.ListView();
            this.lnklblHelpMeChooseAccountStorage = new System.Windows.Forms.LinkLabel();
            this.m_rbStorageLocation_Disk = new System.Windows.Forms.RadioButton();
            this.m_rbStorageLocation_WindowsCredentialManager = new System.Windows.Forms.RadioButton();
            this.lblAccountStorageLocation = new System.Windows.Forms.Label();
            this.m_tabGeneral = new System.Windows.Forms.TabPage();
            this.m_cbOfflineCache = new System.Windows.Forms.CheckBox();
            this.m_tabAbout = new System.Windows.Forms.TabPage();
            this.m_lnkContactAuthor = new System.Windows.Forms.LinkLabel();
            this.m_lnkReportBug = new System.Windows.Forms.LinkLabel();
            this.m_lblAboutVersion = new System.Windows.Forms.Label();
            this.m_lblAboutExplanation = new System.Windows.Forms.Label();
            this.m_lblAboutHeader = new System.Windows.Forms.Label();
            this.m_btnOK = new System.Windows.Forms.Button();
            this.m_btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.m_tabAccounts.SuspendLayout();
            this.m_tabGeneral.SuspendLayout();
            this.m_tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_bannerImage
            // 
            this.m_bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
            this.m_bannerImage.Name = "m_bannerImage";
            this.m_bannerImage.Size = new System.Drawing.Size(586, 60);
            this.m_bannerImage.TabIndex = 4;
            this.m_bannerImage.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.m_tabAccounts);
            this.tabControl1.Controls.Add(this.m_tabGeneral);
            this.tabControl1.Controls.Add(this.m_tabAbout);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 247);
            this.tabControl1.TabIndex = 5;
            // 
            // m_tabAccounts
            // 
            this.m_tabAccounts.Controls.Add(this.m_btnAccountRemove);
            this.m_tabAccounts.Controls.Add(this.m_btnAccountAdd);
            this.m_tabAccounts.Controls.Add(this.m_lvAccounts);
            this.m_tabAccounts.Controls.Add(this.lnklblHelpMeChooseAccountStorage);
            this.m_tabAccounts.Controls.Add(this.m_rbStorageLocation_Disk);
            this.m_tabAccounts.Controls.Add(this.m_rbStorageLocation_WindowsCredentialManager);
            this.m_tabAccounts.Controls.Add(this.lblAccountStorageLocation);
            this.m_tabAccounts.Location = new System.Drawing.Point(4, 22);
            this.m_tabAccounts.Name = "m_tabAccounts";
            this.m_tabAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabAccounts.Size = new System.Drawing.Size(554, 221);
            this.m_tabAccounts.TabIndex = 1;
            this.m_tabAccounts.Text = "Accounts";
            this.m_tabAccounts.UseVisualStyleBackColor = true;
            // 
            // m_btnAccountRemove
            // 
            this.m_btnAccountRemove.Location = new System.Drawing.Point(473, 67);
            this.m_btnAccountRemove.Name = "m_btnAccountRemove";
            this.m_btnAccountRemove.Size = new System.Drawing.Size(75, 23);
            this.m_btnAccountRemove.TabIndex = 10;
            this.m_btnAccountRemove.Text = "Remove";
            this.m_btnAccountRemove.UseVisualStyleBackColor = true;
            this.m_btnAccountRemove.Click += new System.EventHandler(this.OnAccountRemove);
            // 
            // m_btnAccountAdd
            // 
            this.m_btnAccountAdd.Location = new System.Drawing.Point(473, 38);
            this.m_btnAccountAdd.Name = "m_btnAccountAdd";
            this.m_btnAccountAdd.Size = new System.Drawing.Size(75, 23);
            this.m_btnAccountAdd.TabIndex = 8;
            this.m_btnAccountAdd.Text = "&Add...";
            this.m_btnAccountAdd.UseVisualStyleBackColor = true;
            this.m_btnAccountAdd.Click += new System.EventHandler(this.OnAccountAdd);
            // 
            // m_lvAccounts
            // 
            this.m_lvAccounts.Location = new System.Drawing.Point(7, 38);
            this.m_lvAccounts.Name = "m_lvAccounts";
            this.m_lvAccounts.Size = new System.Drawing.Size(460, 177);
            this.m_lvAccounts.TabIndex = 9;
            this.m_lvAccounts.UseCompatibleStateImageBehavior = false;
            this.m_lvAccounts.View = System.Windows.Forms.View.Details;
            // 
            // lnklblHelpMeChooseAccountStorage
            // 
            this.lnklblHelpMeChooseAccountStorage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklblHelpMeChooseAccountStorage.AutoSize = true;
            this.lnklblHelpMeChooseAccountStorage.Location = new System.Drawing.Point(392, 9);
            this.lnklblHelpMeChooseAccountStorage.Name = "lnklblHelpMeChooseAccountStorage";
            this.lnklblHelpMeChooseAccountStorage.Size = new System.Drawing.Size(156, 13);
            this.lnklblHelpMeChooseAccountStorage.TabIndex = 8;
            this.lnklblHelpMeChooseAccountStorage.TabStop = true;
            this.lnklblHelpMeChooseAccountStorage.Text = "I have no idea, help me choose";
            this.lnklblHelpMeChooseAccountStorage.UseMnemonic = false;
            this.lnklblHelpMeChooseAccountStorage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnHelpMeChooseAccountStorage);
            // 
            // m_rbStorageLocation_Disk
            // 
            this.m_rbStorageLocation_Disk.AutoSize = true;
            this.m_rbStorageLocation_Disk.Location = new System.Drawing.Point(313, 7);
            this.m_rbStorageLocation_Disk.Name = "m_rbStorageLocation_Disk";
            this.m_rbStorageLocation_Disk.Size = new System.Drawing.Size(46, 17);
            this.m_rbStorageLocation_Disk.TabIndex = 2;
            this.m_rbStorageLocation_Disk.TabStop = true;
            this.m_rbStorageLocation_Disk.Text = "Disk";
            this.m_rbStorageLocation_Disk.UseVisualStyleBackColor = true;
            // 
            // m_rbStorageLocation_WindowsCredentialManager
            // 
            this.m_rbStorageLocation_WindowsCredentialManager.AutoSize = true;
            this.m_rbStorageLocation_WindowsCredentialManager.Location = new System.Drawing.Point(143, 7);
            this.m_rbStorageLocation_WindowsCredentialManager.Name = "m_rbStorageLocation_WindowsCredentialManager";
            this.m_rbStorageLocation_WindowsCredentialManager.Size = new System.Drawing.Size(164, 17);
            this.m_rbStorageLocation_WindowsCredentialManager.TabIndex = 1;
            this.m_rbStorageLocation_WindowsCredentialManager.TabStop = true;
            this.m_rbStorageLocation_WindowsCredentialManager.Text = "Windows Credential Manager";
            this.m_rbStorageLocation_WindowsCredentialManager.UseVisualStyleBackColor = true;
            // 
            // lblAccountStorageLocation
            // 
            this.lblAccountStorageLocation.AutoSize = true;
            this.lblAccountStorageLocation.Location = new System.Drawing.Point(3, 9);
            this.lblAccountStorageLocation.Name = "lblAccountStorageLocation";
            this.lblAccountStorageLocation.Size = new System.Drawing.Size(134, 13);
            this.lblAccountStorageLocation.TabIndex = 0;
            this.lblAccountStorageLocation.Text = "Account Storage Location:";
            // 
            // m_tabGeneral
            // 
            this.m_tabGeneral.Controls.Add(this.m_cbOfflineCache);
            this.m_tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.m_tabGeneral.Name = "m_tabGeneral";
            this.m_tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabGeneral.Size = new System.Drawing.Size(554, 221);
            this.m_tabGeneral.TabIndex = 0;
            this.m_tabGeneral.Text = "General";
            this.m_tabGeneral.UseVisualStyleBackColor = true;
            // 
            // m_cbOfflineCache
            // 
            this.m_cbOfflineCache.AutoSize = true;
            this.m_cbOfflineCache.Location = new System.Drawing.Point(7, 7);
            this.m_cbOfflineCache.Name = "m_cbOfflineCache";
            this.m_cbOfflineCache.Size = new System.Drawing.Size(189, 17);
            this.m_cbOfflineCache.TabIndex = 0;
            this.m_cbOfflineCache.Text = "Cache Databases for offline usage";
            this.m_cbOfflineCache.UseVisualStyleBackColor = true;
            // 
            // m_tabAbout
            // 
            this.m_tabAbout.Controls.Add(this.m_lnkContactAuthor);
            this.m_tabAbout.Controls.Add(this.m_lnkReportBug);
            this.m_tabAbout.Controls.Add(this.m_lblAboutVersion);
            this.m_tabAbout.Controls.Add(this.m_lblAboutExplanation);
            this.m_tabAbout.Controls.Add(this.m_lblAboutHeader);
            this.m_tabAbout.Location = new System.Drawing.Point(4, 22);
            this.m_tabAbout.Name = "m_tabAbout";
            this.m_tabAbout.Size = new System.Drawing.Size(554, 221);
            this.m_tabAbout.TabIndex = 2;
            this.m_tabAbout.Text = "About";
            this.m_tabAbout.UseVisualStyleBackColor = true;
            // 
            // m_lnkContactAuthor
            // 
            this.m_lnkContactAuthor.AutoSize = true;
            this.m_lnkContactAuthor.Location = new System.Drawing.Point(12, 197);
            this.m_lnkContactAuthor.Name = "m_lnkContactAuthor";
            this.m_lnkContactAuthor.Size = new System.Drawing.Size(95, 13);
            this.m_lnkContactAuthor.TabIndex = 12;
            this.m_lnkContactAuthor.TabStop = true;
            this.m_lnkContactAuthor.Text = "Contact the author";
            this.m_lnkContactAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnContactAuthor);
            // 
            // m_lnkReportBug
            // 
            this.m_lnkReportBug.AutoSize = true;
            this.m_lnkReportBug.Location = new System.Drawing.Point(12, 175);
            this.m_lnkReportBug.Name = "m_lnkReportBug";
            this.m_lnkReportBug.Size = new System.Drawing.Size(69, 13);
            this.m_lnkReportBug.TabIndex = 11;
            this.m_lnkReportBug.TabStop = true;
            this.m_lnkReportBug.Text = "Report a bug";
            this.m_lnkReportBug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnReportBug);
            // 
            // m_lblAboutVersion
            // 
            this.m_lblAboutVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lblAboutVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblAboutVersion.Location = new System.Drawing.Point(12, 35);
            this.m_lblAboutVersion.Name = "m_lblAboutVersion";
            this.m_lblAboutVersion.Size = new System.Drawing.Size(524, 21);
            this.m_lblAboutVersion.TabIndex = 10;
            this.m_lblAboutVersion.Text = "Version";
            this.m_lblAboutVersion.UseMnemonic = false;
            // 
            // m_lblAboutExplanation
            // 
            this.m_lblAboutExplanation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lblAboutExplanation.Location = new System.Drawing.Point(12, 66);
            this.m_lblAboutExplanation.Name = "m_lblAboutExplanation";
            this.m_lblAboutExplanation.Size = new System.Drawing.Size(524, 91);
            this.m_lblAboutExplanation.TabIndex = 8;
            this.m_lblAboutExplanation.Text = resources.GetString("m_lblAboutExplanation.Text");
            this.m_lblAboutExplanation.UseMnemonic = false;
            // 
            // m_lblAboutHeader
            // 
            this.m_lblAboutHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lblAboutHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblAboutHeader.Location = new System.Drawing.Point(11, 12);
            this.m_lblAboutHeader.Name = "m_lblAboutHeader";
            this.m_lblAboutHeader.Size = new System.Drawing.Size(356, 23);
            this.m_lblAboutHeader.TabIndex = 7;
            this.m_lblAboutHeader.Text = "KeeAnywhere";
            this.m_lblAboutHeader.UseMnemonic = false;
            // 
            // m_btnOK
            // 
            this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnOK.Location = new System.Drawing.Point(418, 319);
            this.m_btnOK.Name = "m_btnOK";
            this.m_btnOK.Size = new System.Drawing.Size(75, 23);
            this.m_btnOK.TabIndex = 6;
            this.m_btnOK.Text = "OK";
            this.m_btnOK.UseVisualStyleBackColor = true;
            this.m_btnOK.Click += new System.EventHandler(this.OnBtnOkClick);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnCancel.Location = new System.Drawing.Point(499, 319);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
            this.m_btnCancel.TabIndex = 7;
            this.m_btnCancel.Text = "Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            this.m_btnCancel.Click += new System.EventHandler(this.OnBtnCancelClick);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.m_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_btnCancel;
            this.ClientSize = new System.Drawing.Size(586, 357);
            this.Controls.Add(this.m_btnOK);
            this.Controls.Add(this.m_btnCancel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.m_bannerImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KeeAnywhere Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.m_tabAccounts.ResumeLayout(false);
            this.m_tabAccounts.PerformLayout();
            this.m_tabGeneral.ResumeLayout(false);
            this.m_tabGeneral.PerformLayout();
            this.m_tabAbout.ResumeLayout(false);
            this.m_tabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox m_bannerImage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage m_tabGeneral;
        private System.Windows.Forms.TabPage m_tabAccounts;
        private System.Windows.Forms.TabPage m_tabAbout;
        private System.Windows.Forms.Button m_btnOK;
        private System.Windows.Forms.Button m_btnCancel;
        private System.Windows.Forms.CheckBox m_cbOfflineCache;
        private System.Windows.Forms.Label m_lblAboutExplanation;
        private System.Windows.Forms.Label m_lblAboutHeader;
        private System.Windows.Forms.RadioButton m_rbStorageLocation_Disk;
        private System.Windows.Forms.RadioButton m_rbStorageLocation_WindowsCredentialManager;
        private System.Windows.Forms.Label lblAccountStorageLocation;
        private System.Windows.Forms.LinkLabel lnklblHelpMeChooseAccountStorage;
        private System.Windows.Forms.ListView m_lvAccounts;
        private System.Windows.Forms.Button m_btnAccountRemove;
        private System.Windows.Forms.Button m_btnAccountAdd;
        private System.Windows.Forms.Label m_lblAboutVersion;
        private System.Windows.Forms.LinkLabel m_lnkContactAuthor;
        private System.Windows.Forms.LinkLabel m_lnkReportBug;
    }
}