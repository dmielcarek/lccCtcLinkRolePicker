namespace lccCtcLinkRolePicker
{
    partial class lccForm1
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
            this.lccTbxMessages = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lccMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lccMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lccTbxSourcePath = new System.Windows.Forms.TextBox();
            this.lccLblSourcePath = new System.Windows.Forms.Label();
            this.lccBtnLoad = new System.Windows.Forms.Button();
            this.lccLbxPillars = new System.Windows.Forms.ListBox();
            this.lccLbxModules = new System.Windows.Forms.ListBox();
            this.lccLbxNames = new System.Windows.Forms.ListBox();
            this.lccLbxTitles = new System.Windows.Forms.ListBox();
            this.lccGbxPillars = new System.Windows.Forms.GroupBox();
            this.lccGbxModules = new System.Windows.Forms.GroupBox();
            this.lccGbxNames = new System.Windows.Forms.GroupBox();
            this.lccGbxTitles = new System.Windows.Forms.GroupBox();
            this.lccGbxDescriptions = new System.Windows.Forms.GroupBox();
            this.lccCbxLstDescriptions = new System.Windows.Forms.CheckedListBox();
            this.lccGbxMessages = new System.Windows.Forms.GroupBox();
            this.lccTbxDescriptionsFilter = new System.Windows.Forms.TextBox();
            this.lccLblDescriptionsWordFilter = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lccCbxDescriptionsFilterAnd = new System.Windows.Forms.CheckBox();
            this.lccTabControl = new System.Windows.Forms.TabControl();
            this.lccTabMain = new System.Windows.Forms.TabPage();
            this.lccTabAdditional = new System.Windows.Forms.TabPage();
            this.lccGbxAdditional = new System.Windows.Forms.GroupBox();
            this.lccTbxAdditional = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.lccGbxPillars.SuspendLayout();
            this.lccGbxModules.SuspendLayout();
            this.lccGbxNames.SuspendLayout();
            this.lccGbxTitles.SuspendLayout();
            this.lccGbxDescriptions.SuspendLayout();
            this.lccGbxMessages.SuspendLayout();
            this.lccTabControl.SuspendLayout();
            this.lccTabMain.SuspendLayout();
            this.lccTabAdditional.SuspendLayout();
            this.lccGbxAdditional.SuspendLayout();
            this.SuspendLayout();
            // 
            // lccTbxMessages
            // 
            this.lccTbxMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccTbxMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lccTbxMessages.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccTbxMessages.Location = new System.Drawing.Point(6, 44);
            this.lccTbxMessages.Multiline = true;
            this.lccTbxMessages.Name = "lccTbxMessages";
            this.lccTbxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lccTbxMessages.Size = new System.Drawing.Size(322, 150);
            this.lccTbxMessages.TabIndex = 0;
            this.lccTbxMessages.Text = "Please click \'Load\' to download/collate data.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lccMenuHelp,
            this.lccMenuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lccMenuHelp
            // 
            this.lccMenuHelp.Name = "lccMenuHelp";
            this.lccMenuHelp.Size = new System.Drawing.Size(44, 20);
            this.lccMenuHelp.Text = "Help";
            this.lccMenuHelp.Click += new System.EventHandler(this.lccMenuHelp_Click);
            // 
            // lccMenuAbout
            // 
            this.lccMenuAbout.Name = "lccMenuAbout";
            this.lccMenuAbout.Size = new System.Drawing.Size(52, 20);
            this.lccMenuAbout.Text = "About";
            this.lccMenuAbout.Click += new System.EventHandler(this.lccMenuAbout_Click);
            // 
            // lccTbxSourcePath
            // 
            this.lccTbxSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccTbxSourcePath.Location = new System.Drawing.Point(100, 35);
            this.lccTbxSourcePath.Name = "lccTbxSourcePath";
            this.lccTbxSourcePath.Size = new System.Drawing.Size(567, 23);
            this.lccTbxSourcePath.TabIndex = 2;
            // 
            // lccLblSourcePath
            // 
            this.lccLblSourcePath.AutoSize = true;
            this.lccLblSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccLblSourcePath.Location = new System.Drawing.Point(12, 35);
            this.lccLblSourcePath.Name = "lccLblSourcePath";
            this.lccLblSourcePath.Size = new System.Drawing.Size(86, 17);
            this.lccLblSourcePath.TabIndex = 3;
            this.lccLblSourcePath.Text = "Source Path";
            // 
            // lccBtnLoad
            // 
            this.lccBtnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccBtnLoad.Location = new System.Drawing.Point(695, 35);
            this.lccBtnLoad.Name = "lccBtnLoad";
            this.lccBtnLoad.Size = new System.Drawing.Size(75, 25);
            this.lccBtnLoad.TabIndex = 4;
            this.lccBtnLoad.Text = "Load";
            this.lccBtnLoad.UseVisualStyleBackColor = true;
            this.lccBtnLoad.Click += new System.EventHandler(this.lccBtnLoad_Click);
            // 
            // lccLbxPillars
            // 
            this.lccLbxPillars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lccLbxPillars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lccLbxPillars.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccLbxPillars.FormattingEnabled = true;
            this.lccLbxPillars.ItemHeight = 15;
            this.lccLbxPillars.Location = new System.Drawing.Point(11, 19);
            this.lccLbxPillars.Name = "lccLbxPillars";
            this.lccLbxPillars.Size = new System.Drawing.Size(110, 139);
            this.lccLbxPillars.TabIndex = 5;
            // 
            // lccLbxModules
            // 
            this.lccLbxModules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lccLbxModules.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccLbxModules.FormattingEnabled = true;
            this.lccLbxModules.ItemHeight = 15;
            this.lccLbxModules.Location = new System.Drawing.Point(11, 21);
            this.lccLbxModules.Name = "lccLbxModules";
            this.lccLbxModules.Size = new System.Drawing.Size(255, 139);
            this.lccLbxModules.TabIndex = 7;
            // 
            // lccLbxNames
            // 
            this.lccLbxNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccLbxNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lccLbxNames.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccLbxNames.FormattingEnabled = true;
            this.lccLbxNames.ItemHeight = 15;
            this.lccLbxNames.Location = new System.Drawing.Point(11, 22);
            this.lccLbxNames.Name = "lccLbxNames";
            this.lccLbxNames.Size = new System.Drawing.Size(255, 139);
            this.lccLbxNames.TabIndex = 8;
            // 
            // lccLbxTitles
            // 
            this.lccLbxTitles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lccLbxTitles.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccLbxTitles.FormattingEnabled = true;
            this.lccLbxTitles.ItemHeight = 15;
            this.lccLbxTitles.Location = new System.Drawing.Point(10, 21);
            this.lccLbxTitles.Name = "lccLbxTitles";
            this.lccLbxTitles.Size = new System.Drawing.Size(255, 139);
            this.lccLbxTitles.TabIndex = 9;
            // 
            // lccGbxPillars
            // 
            this.lccGbxPillars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lccGbxPillars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lccGbxPillars.Controls.Add(this.lccLbxPillars);
            this.lccGbxPillars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccGbxPillars.Location = new System.Drawing.Point(21, 222);
            this.lccGbxPillars.Name = "lccGbxPillars";
            this.lccGbxPillars.Size = new System.Drawing.Size(130, 175);
            this.lccGbxPillars.TabIndex = 10;
            this.lccGbxPillars.TabStop = false;
            this.lccGbxPillars.Text = "Pillars";
            // 
            // lccGbxModules
            // 
            this.lccGbxModules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lccGbxModules.Controls.Add(this.lccLbxModules);
            this.lccGbxModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccGbxModules.Location = new System.Drawing.Point(158, 222);
            this.lccGbxModules.Name = "lccGbxModules";
            this.lccGbxModules.Size = new System.Drawing.Size(275, 175);
            this.lccGbxModules.TabIndex = 11;
            this.lccGbxModules.TabStop = false;
            this.lccGbxModules.Text = "Modules";
            // 
            // lccGbxNames
            // 
            this.lccGbxNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccGbxNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lccGbxNames.Controls.Add(this.lccLbxNames);
            this.lccGbxNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccGbxNames.Location = new System.Drawing.Point(723, 219);
            this.lccGbxNames.Name = "lccGbxNames";
            this.lccGbxNames.Size = new System.Drawing.Size(275, 175);
            this.lccGbxNames.TabIndex = 12;
            this.lccGbxNames.TabStop = false;
            this.lccGbxNames.Text = "Names";
            // 
            // lccGbxTitles
            // 
            this.lccGbxTitles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lccGbxTitles.Controls.Add(this.lccLbxTitles);
            this.lccGbxTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccGbxTitles.Location = new System.Drawing.Point(442, 222);
            this.lccGbxTitles.Name = "lccGbxTitles";
            this.lccGbxTitles.Size = new System.Drawing.Size(275, 175);
            this.lccGbxTitles.TabIndex = 13;
            this.lccGbxTitles.TabStop = false;
            this.lccGbxTitles.Text = "Titles";
            // 
            // lccGbxDescriptions
            // 
            this.lccGbxDescriptions.BackColor = System.Drawing.Color.Black;
            this.lccGbxDescriptions.Controls.Add(this.lccCbxLstDescriptions);
            this.lccGbxDescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccGbxDescriptions.ForeColor = System.Drawing.Color.White;
            this.lccGbxDescriptions.Location = new System.Drawing.Point(21, 16);
            this.lccGbxDescriptions.Name = "lccGbxDescriptions";
            this.lccGbxDescriptions.Size = new System.Drawing.Size(630, 200);
            this.lccGbxDescriptions.TabIndex = 12;
            this.lccGbxDescriptions.TabStop = false;
            this.lccGbxDescriptions.Text = "Descriptions (aka Abilities) [ check some to perform \'AND\' filter ]";
            // 
            // lccCbxLstDescriptions
            // 
            this.lccCbxLstDescriptions.BackColor = System.Drawing.Color.Gray;
            this.lccCbxLstDescriptions.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccCbxLstDescriptions.ForeColor = System.Drawing.Color.White;
            this.lccCbxLstDescriptions.FormattingEnabled = true;
            this.lccCbxLstDescriptions.Location = new System.Drawing.Point(15, 28);
            this.lccCbxLstDescriptions.Name = "lccCbxLstDescriptions";
            this.lccCbxLstDescriptions.Size = new System.Drawing.Size(597, 166);
            this.lccCbxLstDescriptions.TabIndex = 8;
            // 
            // lccGbxMessages
            // 
            this.lccGbxMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccGbxMessages.Controls.Add(this.lccTbxMessages);
            this.lccGbxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccGbxMessages.Location = new System.Drawing.Point(667, 16);
            this.lccGbxMessages.Name = "lccGbxMessages";
            this.lccGbxMessages.Size = new System.Drawing.Size(341, 200);
            this.lccGbxMessages.TabIndex = 12;
            this.lccGbxMessages.TabStop = false;
            this.lccGbxMessages.Text = "Messages";
            // 
            // lccTbxDescriptionsFilter
            // 
            this.lccTbxDescriptionsFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccTbxDescriptionsFilter.Location = new System.Drawing.Point(294, 61);
            this.lccTbxDescriptionsFilter.Name = "lccTbxDescriptionsFilter";
            this.lccTbxDescriptionsFilter.Size = new System.Drawing.Size(373, 23);
            this.lccTbxDescriptionsFilter.TabIndex = 14;
            // 
            // lccLblDescriptionsWordFilter
            // 
            this.lccLblDescriptionsWordFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccLblDescriptionsWordFilter.Location = new System.Drawing.Point(12, 64);
            this.lccLblDescriptionsWordFilter.Name = "lccLblDescriptionsWordFilter";
            this.lccLblDescriptionsWordFilter.Size = new System.Drawing.Size(221, 19);
            this.lccLblDescriptionsWordFilter.TabIndex = 15;
            this.lccLblDescriptionsWordFilter.Text = "Descriptions Word(s) \'OR\' Filter";
            // 
            // lccCbxDescriptionsFilterAnd
            // 
            this.lccCbxDescriptionsFilterAnd.AutoSize = true;
            this.lccCbxDescriptionsFilterAnd.Location = new System.Drawing.Point(244, 66);
            this.lccCbxDescriptionsFilterAnd.Name = "lccCbxDescriptionsFilterAnd";
            this.lccCbxDescriptionsFilterAnd.Size = new System.Drawing.Size(45, 17);
            this.lccCbxDescriptionsFilterAnd.TabIndex = 16;
            this.lccCbxDescriptionsFilterAnd.Text = "And";
            this.lccCbxDescriptionsFilterAnd.UseVisualStyleBackColor = true;
            this.lccCbxDescriptionsFilterAnd.CheckedChanged += new System.EventHandler(this.lccCbxDescriptionsFilterAnd_CheckedChanged);
            // 
            // lccTabControl
            // 
            this.lccTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccTabControl.Controls.Add(this.lccTabMain);
            this.lccTabControl.Controls.Add(this.lccTabAdditional);
            this.lccTabControl.Location = new System.Drawing.Point(12, 90);
            this.lccTabControl.Name = "lccTabControl";
            this.lccTabControl.SelectedIndex = 0;
            this.lccTabControl.Size = new System.Drawing.Size(1022, 434);
            this.lccTabControl.TabIndex = 17;
            // 
            // lccTabMain
            // 
            this.lccTabMain.Controls.Add(this.lccGbxDescriptions);
            this.lccTabMain.Controls.Add(this.lccGbxPillars);
            this.lccTabMain.Controls.Add(this.lccGbxModules);
            this.lccTabMain.Controls.Add(this.lccGbxTitles);
            this.lccTabMain.Controls.Add(this.lccGbxMessages);
            this.lccTabMain.Controls.Add(this.lccGbxNames);
            this.lccTabMain.Location = new System.Drawing.Point(4, 22);
            this.lccTabMain.Name = "lccTabMain";
            this.lccTabMain.Padding = new System.Windows.Forms.Padding(3);
            this.lccTabMain.Size = new System.Drawing.Size(1014, 408);
            this.lccTabMain.TabIndex = 0;
            this.lccTabMain.Text = "Main Information";
            this.lccTabMain.UseVisualStyleBackColor = true;
            // 
            // lccTabAdditional
            // 
            this.lccTabAdditional.Controls.Add(this.lccGbxAdditional);
            this.lccTabAdditional.Location = new System.Drawing.Point(4, 22);
            this.lccTabAdditional.Name = "lccTabAdditional";
            this.lccTabAdditional.Padding = new System.Windows.Forms.Padding(3);
            this.lccTabAdditional.Size = new System.Drawing.Size(1014, 408);
            this.lccTabAdditional.TabIndex = 1;
            this.lccTabAdditional.Text = "Additional Information";
            this.lccTabAdditional.UseVisualStyleBackColor = true;
            // 
            // lccGbxAdditional
            // 
            this.lccGbxAdditional.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccGbxAdditional.Controls.Add(this.lccTbxAdditional);
            this.lccGbxAdditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccGbxAdditional.Location = new System.Drawing.Point(15, 16);
            this.lccGbxAdditional.Name = "lccGbxAdditional";
            this.lccGbxAdditional.Size = new System.Drawing.Size(976, 357);
            this.lccGbxAdditional.TabIndex = 13;
            this.lccGbxAdditional.TabStop = false;
            this.lccGbxAdditional.Text = "Additional Information";
            // 
            // lccTbxAdditional
            // 
            this.lccTbxAdditional.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lccTbxAdditional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lccTbxAdditional.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lccTbxAdditional.Location = new System.Drawing.Point(9, 34);
            this.lccTbxAdditional.Multiline = true;
            this.lccTbxAdditional.Name = "lccTbxAdditional";
            this.lccTbxAdditional.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lccTbxAdditional.Size = new System.Drawing.Size(949, 299);
            this.lccTbxAdditional.TabIndex = 0;
            this.lccTbxAdditional.Text = "No additional information at this time.";
            // 
            // lccForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 535);
            this.Controls.Add(this.lccTabControl);
            this.Controls.Add(this.lccCbxDescriptionsFilterAnd);
            this.Controls.Add(this.lccLblDescriptionsWordFilter);
            this.Controls.Add(this.lccTbxDescriptionsFilter);
            this.Controls.Add(this.lccBtnLoad);
            this.Controls.Add(this.lccLblSourcePath);
            this.Controls.Add(this.lccTbxSourcePath);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "lccForm1";
            this.Text = "lccCtcLinkRolePicker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.lccGbxPillars.ResumeLayout(false);
            this.lccGbxModules.ResumeLayout(false);
            this.lccGbxNames.ResumeLayout(false);
            this.lccGbxTitles.ResumeLayout(false);
            this.lccGbxDescriptions.ResumeLayout(false);
            this.lccGbxMessages.ResumeLayout(false);
            this.lccGbxMessages.PerformLayout();
            this.lccTabControl.ResumeLayout(false);
            this.lccTabMain.ResumeLayout(false);
            this.lccTabAdditional.ResumeLayout(false);
            this.lccGbxAdditional.ResumeLayout(false);
            this.lccGbxAdditional.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lccTbxMessages;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lccMenuAbout;
        private System.Windows.Forms.TextBox lccTbxSourcePath;
        private System.Windows.Forms.Label lccLblSourcePath;
        private System.Windows.Forms.Button lccBtnLoad;
        private System.Windows.Forms.ListBox lccLbxPillars;
        private System.Windows.Forms.ListBox lccLbxModules;
        private System.Windows.Forms.ListBox lccLbxNames;
        private System.Windows.Forms.ListBox lccLbxTitles;
        private System.Windows.Forms.GroupBox lccGbxPillars;
        private System.Windows.Forms.GroupBox lccGbxModules;
        private System.Windows.Forms.GroupBox lccGbxNames;
        private System.Windows.Forms.GroupBox lccGbxTitles;
        private System.Windows.Forms.GroupBox lccGbxDescriptions;
        private System.Windows.Forms.CheckedListBox lccCbxLstDescriptions;
        private System.Windows.Forms.GroupBox lccGbxMessages;
        private System.Windows.Forms.ToolStripMenuItem lccMenuHelp;
        private System.Windows.Forms.TextBox lccTbxDescriptionsFilter;
        private System.Windows.Forms.Label lccLblDescriptionsWordFilter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox lccCbxDescriptionsFilterAnd;
        private System.Windows.Forms.TabControl lccTabControl;
        private System.Windows.Forms.TabPage lccTabMain;
        private System.Windows.Forms.TabPage lccTabAdditional;
        private System.Windows.Forms.GroupBox lccGbxAdditional;
        private System.Windows.Forms.TextBox lccTbxAdditional;
    }
}

