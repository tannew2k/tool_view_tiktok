namespace tool_view_tiktok
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonStart = new System.Windows.Forms.Button();
            this.dataGridViewProfie = new System.Windows.Forms.DataGridView();
            this.SeclectProfile = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Open = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Likes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Follow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.IblPageNumber = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelNumberThereas = new System.Windows.Forms.Label();
            this.numericUpDownNumberThersas = new System.Windows.Forms.NumericUpDown();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonDetele = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonOpenFileCommentKeywords = new System.Windows.Forms.Button();
            this.textBoxPathFileCommentKeywords = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOpenFileSearchKeywords = new System.Windows.Forms.Button();
            this.textBoxPathFileSearchKeywords = new System.Windows.Forms.TextBox();
            this.labelSearchKeywords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownEndTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStartTime = new System.Windows.Forms.NumericUpDown();
            this.labelRunTime = new System.Windows.Forms.Label();
            this.textBoxApiCaptcha = new System.Windows.Forms.TextBox();
            this.labelApiCaptcha = new System.Windows.Forms.Label();
            this.buttonResetProfile = new System.Windows.Forms.Button();
            this.numericUpDownWindowHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWindowWidth = new System.Windows.Forms.NumericUpDown();
            this.labelWindowHeight = new System.Windows.Forms.Label();
            this.labelWindowWidth = new System.Windows.Forms.Label();
            this.numericUpDownDelayAction = new System.Windows.Forms.NumericUpDown();
            this.labelDelayAction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberThersas)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWindowHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWindowWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayAction)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(4, 8);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(134, 61);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // dataGridViewProfie
            // 
            this.dataGridViewProfie.AllowUserToAddRows = false;
            this.dataGridViewProfie.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProfie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProfie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.SeclectProfile, this.ID, this.NameProfile, this.Proxy, this.Open, this.Status, this.View, this.Likes, this.Follow, this.Comments, this.Shares });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProfie.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProfie.Location = new System.Drawing.Point(4, 197);
            this.dataGridViewProfie.Name = "dataGridViewProfie";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProfie.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProfie.RowHeadersVisible = false;
            this.dataGridViewProfie.Size = new System.Drawing.Size(1177, 331);
            this.dataGridViewProfie.TabIndex = 2;
            this.dataGridViewProfie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProfile_CellContentClick);
            // 
            // SeclectProfile
            // 
            this.SeclectProfile.HeaderText = "";
            this.SeclectProfile.Name = "SeclectProfile";
            this.SeclectProfile.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SeclectProfile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SeclectProfile.Width = 50;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NameProfile
            // 
            this.NameProfile.HeaderText = "Name Profile";
            this.NameProfile.MinimumWidth = 10;
            this.NameProfile.Name = "NameProfile";
            this.NameProfile.ReadOnly = true;
            this.NameProfile.Width = 235;
            // 
            // Proxy
            // 
            this.Proxy.HeaderText = "Proxy";
            this.Proxy.MinimumWidth = 10;
            this.Proxy.Name = "Proxy";
            this.Proxy.ReadOnly = true;
            this.Proxy.Width = 140;
            // 
            // Open
            // 
            this.Open.HeaderText = "Open";
            this.Open.MinimumWidth = 10;
            this.Open.Name = "Open";
            this.Open.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Open.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Open.Text = "Open";
            this.Open.UseColumnTextForButtonValue = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 80;
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Width = 90;
            // 
            // Likes
            // 
            this.Likes.HeaderText = "Likes";
            this.Likes.Name = "Likes";
            this.Likes.Width = 90;
            // 
            // Follow
            // 
            this.Follow.HeaderText = "Follow";
            this.Follow.Name = "Follow";
            this.Follow.Width = 90;
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            this.Comments.Width = 110;
            // 
            // Shares
            // 
            this.Shares.HeaderText = "Shares";
            this.Shares.Name = "Shares";
            this.Shares.Width = 90;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(457, 543);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(85, 32);
            this.buttonPrevious.TabIndex = 3;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(639, 543);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(85, 32);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // IblPageNumber
            // 
            this.IblPageNumber.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblPageNumber.Location = new System.Drawing.Point(548, 543);
            this.IblPageNumber.Name = "IblPageNumber";
            this.IblPageNumber.Size = new System.Drawing.Size(85, 32);
            this.IblPageNumber.TabIndex = 5;
            this.IblPageNumber.Text = "Page 0/0";
            this.IblPageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(144, 8);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(134, 61);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelNumberThereas
            // 
            this.labelNumberThereas.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberThereas.Location = new System.Drawing.Point(520, 6);
            this.labelNumberThereas.Name = "labelNumberThereas";
            this.labelNumberThereas.Size = new System.Drawing.Size(131, 26);
            this.labelNumberThereas.TabIndex = 7;
            this.labelNumberThereas.Text = "Number Thereas";
            this.labelNumberThereas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownNumberThersas
            // 
            this.numericUpDownNumberThersas.AutoSize = true;
            this.numericUpDownNumberThersas.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNumberThersas.Location = new System.Drawing.Point(651, 8);
            this.numericUpDownNumberThersas.Name = "numericUpDownNumberThersas";
            this.numericUpDownNumberThersas.Size = new System.Drawing.Size(180, 27);
            this.numericUpDownNumberThersas.TabIndex = 8;
            this.numericUpDownNumberThersas.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.buttonDetele);
            this.panelMain.Controls.Add(this.buttonExport);
            this.panelMain.Controls.Add(this.buttonOpenFileCommentKeywords);
            this.panelMain.Controls.Add(this.textBoxPathFileCommentKeywords);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.buttonOpenFileSearchKeywords);
            this.panelMain.Controls.Add(this.textBoxPathFileSearchKeywords);
            this.panelMain.Controls.Add(this.labelSearchKeywords);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.numericUpDownEndTime);
            this.panelMain.Controls.Add(this.numericUpDownStartTime);
            this.panelMain.Controls.Add(this.labelRunTime);
            this.panelMain.Controls.Add(this.textBoxApiCaptcha);
            this.panelMain.Controls.Add(this.labelApiCaptcha);
            this.panelMain.Controls.Add(this.buttonResetProfile);
            this.panelMain.Controls.Add(this.numericUpDownWindowHeight);
            this.panelMain.Controls.Add(this.numericUpDownWindowWidth);
            this.panelMain.Controls.Add(this.labelWindowHeight);
            this.panelMain.Controls.Add(this.labelWindowWidth);
            this.panelMain.Controls.Add(this.numericUpDownDelayAction);
            this.panelMain.Controls.Add(this.labelDelayAction);
            this.panelMain.Controls.Add(this.labelNumberThereas);
            this.panelMain.Controls.Add(this.buttonNext);
            this.panelMain.Controls.Add(this.numericUpDownNumberThersas);
            this.panelMain.Controls.Add(this.buttonStop);
            this.panelMain.Controls.Add(this.IblPageNumber);
            this.panelMain.Controls.Add(this.dataGridViewProfie);
            this.panelMain.Controls.Add(this.buttonPrevious);
            this.panelMain.Controls.Add(this.buttonStart);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1186, 594);
            this.panelMain.TabIndex = 9;
            // 
            // buttonDetele
            // 
            this.buttonDetele.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetele.Location = new System.Drawing.Point(4, 76);
            this.buttonDetele.Name = "buttonDetele";
            this.buttonDetele.Size = new System.Drawing.Size(134, 60);
            this.buttonDetele.TabIndex = 29;
            this.buttonDetele.Text = "Delete";
            this.buttonDetele.UseVisualStyleBackColor = true;
            this.buttonDetele.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Location = new System.Drawing.Point(144, 76);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(134, 61);
            this.buttonExport.TabIndex = 28;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonOpenFileCommentKeywords
            // 
            this.buttonOpenFileCommentKeywords.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFileCommentKeywords.Location = new System.Drawing.Point(1077, 153);
            this.buttonOpenFileCommentKeywords.Name = "buttonOpenFileCommentKeywords";
            this.buttonOpenFileCommentKeywords.Size = new System.Drawing.Size(101, 27);
            this.buttonOpenFileCommentKeywords.TabIndex = 27;
            this.buttonOpenFileCommentKeywords.Text = "Open File";
            this.buttonOpenFileCommentKeywords.UseVisualStyleBackColor = true;
            this.buttonOpenFileCommentKeywords.Click += new System.EventHandler(this.buttonOpenFileCommentKeywords_Click);
            // 
            // textBoxPathFileCommentKeywords
            // 
            this.textBoxPathFileCommentKeywords.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathFileCommentKeywords.Location = new System.Drawing.Point(767, 153);
            this.textBoxPathFileCommentKeywords.Name = "textBoxPathFileCommentKeywords";
            this.textBoxPathFileCommentKeywords.ReadOnly = true;
            this.textBoxPathFileCommentKeywords.Size = new System.Drawing.Size(315, 27);
            this.textBoxPathFileCommentKeywords.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Comment Keywords";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOpenFileSearchKeywords
            // 
            this.buttonOpenFileSearchKeywords.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFileSearchKeywords.Location = new System.Drawing.Point(456, 155);
            this.buttonOpenFileSearchKeywords.Name = "buttonOpenFileSearchKeywords";
            this.buttonOpenFileSearchKeywords.Size = new System.Drawing.Size(102, 27);
            this.buttonOpenFileSearchKeywords.TabIndex = 24;
            this.buttonOpenFileSearchKeywords.Text = "Open File";
            this.buttonOpenFileSearchKeywords.UseVisualStyleBackColor = true;
            this.buttonOpenFileSearchKeywords.Click += new System.EventHandler(this.buttonOpenFileKeywords_Click);
            // 
            // textBoxPathFileSearchKeywords
            // 
            this.textBoxPathFileSearchKeywords.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathFileSearchKeywords.Location = new System.Drawing.Point(144, 155);
            this.textBoxPathFileSearchKeywords.Name = "textBoxPathFileSearchKeywords";
            this.textBoxPathFileSearchKeywords.ReadOnly = true;
            this.textBoxPathFileSearchKeywords.Size = new System.Drawing.Size(315, 27);
            this.textBoxPathFileSearchKeywords.TabIndex = 23;
            // 
            // labelSearchKeywords
            // 
            this.labelSearchKeywords.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchKeywords.Location = new System.Drawing.Point(7, 153);
            this.labelSearchKeywords.Name = "labelSearchKeywords";
            this.labelSearchKeywords.Size = new System.Drawing.Size(131, 29);
            this.labelSearchKeywords.TabIndex = 22;
            this.labelSearchKeywords.Text = "Search Keywords";
            this.labelSearchKeywords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(912, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = ":";
            // 
            // numericUpDownEndTime
            // 
            this.numericUpDownEndTime.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownEndTime.Location = new System.Drawing.Point(931, 107);
            this.numericUpDownEndTime.Name = "numericUpDownEndTime";
            this.numericUpDownEndTime.Size = new System.Drawing.Size(247, 27);
            this.numericUpDownEndTime.TabIndex = 20;
            this.numericUpDownEndTime.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDownStartTime
            // 
            this.numericUpDownStartTime.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownStartTime.Location = new System.Drawing.Point(651, 108);
            this.numericUpDownStartTime.Name = "numericUpDownStartTime";
            this.numericUpDownStartTime.Size = new System.Drawing.Size(256, 27);
            this.numericUpDownStartTime.TabIndex = 19;
            this.numericUpDownStartTime.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // labelRunTime
            // 
            this.labelRunTime.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRunTime.Location = new System.Drawing.Point(520, 105);
            this.labelRunTime.Name = "labelRunTime";
            this.labelRunTime.Size = new System.Drawing.Size(134, 29);
            this.labelRunTime.TabIndex = 18;
            this.labelRunTime.Text = "Run Time";
            this.labelRunTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxApiCaptcha
            // 
            this.textBoxApiCaptcha.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApiCaptcha.Location = new System.Drawing.Point(651, 74);
            this.textBoxApiCaptcha.Name = "textBoxApiCaptcha";
            this.textBoxApiCaptcha.Size = new System.Drawing.Size(527, 27);
            this.textBoxApiCaptcha.TabIndex = 17;
            // 
            // labelApiCaptcha
            // 
            this.labelApiCaptcha.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApiCaptcha.Location = new System.Drawing.Point(520, 72);
            this.labelApiCaptcha.Name = "labelApiCaptcha";
            this.labelApiCaptcha.Size = new System.Drawing.Size(131, 28);
            this.labelApiCaptcha.TabIndex = 16;
            this.labelApiCaptcha.Text = "Api Captcha";
            this.labelApiCaptcha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonResetProfile
            // 
            this.buttonResetProfile.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetProfile.Location = new System.Drawing.Point(284, 8);
            this.buttonResetProfile.Name = "buttonResetProfile";
            this.buttonResetProfile.Size = new System.Drawing.Size(134, 61);
            this.buttonResetProfile.TabIndex = 15;
            this.buttonResetProfile.Text = "Reset Profile";
            this.buttonResetProfile.UseVisualStyleBackColor = true;
            this.buttonResetProfile.Click += new System.EventHandler(this.buttonResetProfile_Click);
            // 
            // numericUpDownWindowHeight
            // 
            this.numericUpDownWindowHeight.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWindowHeight.Location = new System.Drawing.Point(993, 41);
            this.numericUpDownWindowHeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericUpDownWindowHeight.Name = "numericUpDownWindowHeight";
            this.numericUpDownWindowHeight.Size = new System.Drawing.Size(185, 27);
            this.numericUpDownWindowHeight.TabIndex = 14;
            this.numericUpDownWindowHeight.Value = new decimal(new int[] { 800, 0, 0, 0 });
            // 
            // numericUpDownWindowWidth
            // 
            this.numericUpDownWindowWidth.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWindowWidth.Location = new System.Drawing.Point(993, 8);
            this.numericUpDownWindowWidth.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericUpDownWindowWidth.Name = "numericUpDownWindowWidth";
            this.numericUpDownWindowWidth.Size = new System.Drawing.Size(185, 27);
            this.numericUpDownWindowWidth.TabIndex = 13;
            this.numericUpDownWindowWidth.Value = new decimal(new int[] { 620, 0, 0, 0 });
            // 
            // labelWindowHeight
            // 
            this.labelWindowHeight.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindowHeight.Location = new System.Drawing.Point(847, 42);
            this.labelWindowHeight.Name = "labelWindowHeight";
            this.labelWindowHeight.Size = new System.Drawing.Size(140, 25);
            this.labelWindowHeight.TabIndex = 12;
            this.labelWindowHeight.Text = "Window Height";
            this.labelWindowHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWindowWidth
            // 
            this.labelWindowWidth.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindowWidth.Location = new System.Drawing.Point(847, 8);
            this.labelWindowWidth.Name = "labelWindowWidth";
            this.labelWindowWidth.Size = new System.Drawing.Size(140, 25);
            this.labelWindowWidth.TabIndex = 11;
            this.labelWindowWidth.Text = "Window Width";
            this.labelWindowWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownDelayAction
            // 
            this.numericUpDownDelayAction.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDelayAction.Location = new System.Drawing.Point(651, 41);
            this.numericUpDownDelayAction.Name = "numericUpDownDelayAction";
            this.numericUpDownDelayAction.Size = new System.Drawing.Size(180, 27);
            this.numericUpDownDelayAction.TabIndex = 10;
            this.numericUpDownDelayAction.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // labelDelayAction
            // 
            this.labelDelayAction.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelayAction.Location = new System.Drawing.Point(520, 38);
            this.labelDelayAction.Name = "labelDelayAction";
            this.labelDelayAction.Size = new System.Drawing.Size(131, 28);
            this.labelDelayAction.TabIndex = 9;
            this.labelDelayAction.Text = "Delay Action";
            this.labelDelayAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 618);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tool view tiktok";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberThersas)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWindowHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWindowWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayAction)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Follow;

        private System.Windows.Forms.Button buttonDetele;

        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;

        private System.Windows.Forms.Button buttonExport;

        private System.Windows.Forms.Button buttonOpenFileCommentKeywords;

        private System.Windows.Forms.TextBox textBoxPathFileCommentKeywords;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button buttonOpenFileSearchKeywords;

        private System.Windows.Forms.TextBox textBoxPathFileSearchKeywords;

        private System.Windows.Forms.ListBox listBoxPathFileKeywords;

        private System.Windows.Forms.Label labelSearchKeywords;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.NumericUpDown numericUpDownEndTime;

        private System.Windows.Forms.NumericUpDown numericUpDownStartTime;

        private System.Windows.Forms.Label labelRunTime;

        private System.Windows.Forms.TextBox textBoxApiCaptcha;

        private System.Windows.Forms.Label labelApiCaptcha;

        private System.Windows.Forms.DataGridViewTextBoxColumn View;
        private System.Windows.Forms.DataGridViewTextBoxColumn Likes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shares;

        private System.Windows.Forms.DataGridViewTextBoxColumn Status;

        private System.Windows.Forms.Button buttonResetProfile;

        private System.Windows.Forms.NumericUpDown numericUpDownWindowHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberThersas;

        private System.Windows.Forms.NumericUpDown numericUpDownWindowWidth;

        private System.Windows.Forms.Label labelWindowHeight;

        private System.Windows.Forms.Label labelWindowWidth;

        private System.Windows.Forms.Label labelDelayAction;

        private System.Windows.Forms.Panel panelMain;

        private System.Windows.Forms.NumericUpDown numericUpDownDelayAction;

        private System.Windows.Forms.Label labelNumberThereas;

        private System.Windows.Forms.Button buttonStop;

        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label IblPageNumber;

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataGridView dataGridViewProfie;

        #endregion

        private System.Windows.Forms.DataGridViewCheckBoxColumn SeclectProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proxy;
        private System.Windows.Forms.DataGridViewButtonColumn Open;
    }
}