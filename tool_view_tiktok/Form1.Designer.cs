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
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.IblPageNumber = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelNumberThereas = new System.Windows.Forms.Label();
            this.numericUpDownNumberThersas = new System.Windows.Forms.NumericUpDown();
            this.panelMain = new System.Windows.Forms.Panel();
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
            this.dataGridViewProfie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.SeclectProfile, this.ID, this.NameProfile, this.Proxy, this.Open });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProfie.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProfie.Location = new System.Drawing.Point(4, 168);
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
            this.dataGridViewProfie.Size = new System.Drawing.Size(1177, 360);
            this.dataGridViewProfie.TabIndex = 2;
            this.dataGridViewProfie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProfie_CellContentClick);
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
            // 
            // NameProfile
            // 
            this.NameProfile.HeaderText = "Name Profile";
            this.NameProfile.MinimumWidth = 10;
            this.NameProfile.Name = "NameProfile";
            this.NameProfile.Width = 250;
            // 
            // Proxy
            // 
            this.Proxy.HeaderText = "Proxy";
            this.Proxy.MinimumWidth = 10;
            this.Proxy.Name = "Proxy";
            this.Proxy.Width = 150;
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
            this.labelNumberThereas.Location = new System.Drawing.Point(442, 6);
            this.labelNumberThereas.Name = "labelNumberThereas";
            this.labelNumberThereas.Size = new System.Drawing.Size(131, 26);
            this.labelNumberThereas.TabIndex = 7;
            this.labelNumberThereas.Text = "Number Thereas";
            this.labelNumberThereas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownNumberThersas
            // 
            this.numericUpDownNumberThersas.AutoSize = true;
            this.numericUpDownNumberThersas.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNumberThersas.Location = new System.Drawing.Point(573, 8);
            this.numericUpDownNumberThersas.Name = "numericUpDownNumberThersas";
            this.numericUpDownNumberThersas.Size = new System.Drawing.Size(180, 27);
            this.numericUpDownNumberThersas.TabIndex = 8;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // buttonResetProfile
            // 
            this.buttonResetProfile.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetProfile.Location = new System.Drawing.Point(284, 7);
            this.buttonResetProfile.Name = "buttonResetProfile";
            this.buttonResetProfile.Size = new System.Drawing.Size(134, 63);
            this.buttonResetProfile.TabIndex = 15;
            this.buttonResetProfile.Text = "Reset Profile";
            this.buttonResetProfile.UseVisualStyleBackColor = true;
            this.buttonResetProfile.Click += new System.EventHandler(this.buttonResetProfile_Click);
            // 
            // numericUpDownWindowHeight
            // 
            this.numericUpDownWindowHeight.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWindowHeight.Location = new System.Drawing.Point(915, 41);
            this.numericUpDownWindowHeight.Name = "numericUpDownWindowHeight";
            this.numericUpDownWindowHeight.Size = new System.Drawing.Size(185, 27);
            this.numericUpDownWindowHeight.TabIndex = 14;
            // 
            // numericUpDownWindowWidth
            // 
            this.numericUpDownWindowWidth.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWindowWidth.Location = new System.Drawing.Point(915, 8);
            this.numericUpDownWindowWidth.Name = "numericUpDownWindowWidth";
            this.numericUpDownWindowWidth.Size = new System.Drawing.Size(185, 27);
            this.numericUpDownWindowWidth.TabIndex = 13;
            // 
            // labelWindowHeight
            // 
            this.labelWindowHeight.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindowHeight.Location = new System.Drawing.Point(769, 42);
            this.labelWindowHeight.Name = "labelWindowHeight";
            this.labelWindowHeight.Size = new System.Drawing.Size(140, 25);
            this.labelWindowHeight.TabIndex = 12;
            this.labelWindowHeight.Text = "WindowHeight";
            this.labelWindowHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWindowWidth
            // 
            this.labelWindowWidth.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindowWidth.Location = new System.Drawing.Point(769, 8);
            this.labelWindowWidth.Name = "labelWindowWidth";
            this.labelWindowWidth.Size = new System.Drawing.Size(140, 25);
            this.labelWindowWidth.TabIndex = 11;
            this.labelWindowWidth.Text = "Window Width";
            this.labelWindowWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownDelayAction
            // 
            this.numericUpDownDelayAction.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDelayAction.Location = new System.Drawing.Point(573, 41);
            this.numericUpDownDelayAction.Name = "numericUpDownDelayAction";
            this.numericUpDownDelayAction.Size = new System.Drawing.Size(180, 27);
            this.numericUpDownDelayAction.TabIndex = 10;
            // 
            // labelDelayAction
            // 
            this.labelDelayAction.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelayAction.Location = new System.Drawing.Point(442, 43);
            this.labelDelayAction.Name = "labelDelayAction";
            this.labelDelayAction.Size = new System.Drawing.Size(131, 26);
            this.labelDelayAction.TabIndex = 9;
            this.labelDelayAction.Text = "Delay Action";
            this.labelDelayAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1206, 618);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "tool view tiktok";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberThersas)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWindowHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWindowWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayAction)).EndInit();
            this.ResumeLayout(false);
        }

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