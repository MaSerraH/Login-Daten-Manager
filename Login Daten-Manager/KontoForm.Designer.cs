namespace Login_Daten_Manager
{
    partial class KontoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontoForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lDMdatenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._C__DBDataSet = new Login_Daten_Manager._C__DBDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnLöschen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNeuStart = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginpasswortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kommentare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDMdatenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__DBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(313, 707);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 38);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.loginnameDataGridViewTextBoxColumn,
            this.loginpasswortDataGridViewTextBoxColumn,
            this.Kommentare});
            this.dataGridView1.DataSource = this.lDMdatenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1242, 252);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lDMdatenBindingSource
            // 
            this.lDMdatenBindingSource.DataMember = "LDM_daten";
            this.lDMdatenBindingSource.DataSource = this._C__DBDataSet;
            // 
            // _C__DBDataSet
            // 
            this._C__DBDataSet.DataSetName = "_C__DBDataSet";
            this._C__DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(93, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 321);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(105, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name der Webseite:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(190, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loginname:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(145, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loginpasswort:";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(349, 83);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(259, 34);
            this.tb1.TabIndex = 6;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(349, 140);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(259, 34);
            this.tb2.TabIndex = 7;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(349, 212);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(259, 34);
            this.tb3.TabIndex = 8;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(729, 83);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(190, 34);
            this.tb4.TabIndex = 9;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(80, 300);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(155, 42);
            this.btnSpeichern.TabIndex = 10;
            this.btnSpeichern.Text = "Eintrag speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnLöschen
            // 
            this.btnLöschen.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLöschen.Location = new System.Drawing.Point(292, 300);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(150, 42);
            this.btnLöschen.TabIndex = 11;
            this.btnLöschen.Text = "Eintrag löschen";
            this.btnLöschen.UseVisualStyleBackColor = true;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 717);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "...";
            // 
            // btnNeuStart
            // 
            this.btnNeuStart.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeuStart.Location = new System.Drawing.Point(1165, 304);
            this.btnNeuStart.Name = "btnNeuStart";
            this.btnNeuStart.Size = new System.Drawing.Size(154, 42);
            this.btnNeuStart.TabIndex = 13;
            this.btnNeuStart.Text = "Konto neustarten";
            this.btnNeuStart.UseVisualStyleBackColor = true;
            this.btnNeuStart.Click += new System.EventHandler(this.btnNeuStart_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(507, 304);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 42);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Konto updaten";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuchen.Location = new System.Drawing.Point(740, 139);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(163, 45);
            this.btnSuchen.TabIndex = 15;
            this.btnSuchen.Text = "Eintrag suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(729, 304);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(172, 42);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Konto exportieren";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(995, 151);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(409, 34);
            this.tb5.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(1052, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 45);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kommentare:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(964, 304);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 38);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1242, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 62;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 101;
            // 
            // loginnameDataGridViewTextBoxColumn
            // 
            this.loginnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loginnameDataGridViewTextBoxColumn.DataPropertyName = "Loginname";
            this.loginnameDataGridViewTextBoxColumn.HeaderText = "Loginname";
            this.loginnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginnameDataGridViewTextBoxColumn.Name = "loginnameDataGridViewTextBoxColumn";
            this.loginnameDataGridViewTextBoxColumn.Width = 146;
            // 
            // loginpasswortDataGridViewTextBoxColumn
            // 
            this.loginpasswortDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loginpasswortDataGridViewTextBoxColumn.DataPropertyName = "Loginpasswort";
            this.loginpasswortDataGridViewTextBoxColumn.HeaderText = "Loginpasswort";
            this.loginpasswortDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginpasswortDataGridViewTextBoxColumn.Name = "loginpasswortDataGridViewTextBoxColumn";
            this.loginpasswortDataGridViewTextBoxColumn.Width = 182;
            // 
            // Kommentare
            // 
            this.Kommentare.DataPropertyName = "Kommentare";
            this.Kommentare.HeaderText = "Kommentare";
            this.Kommentare.MinimumWidth = 6;
            this.Kommentare.Name = "Kommentare";
            // 
            // KontoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1456, 797);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNeuStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "KontoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KontoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDMdatenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__DBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _C__DBDataSet _C__DBDataSet;
        private System.Windows.Forms.BindingSource lDMdatenBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNeuStart;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginpasswortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kommentare;
    }
}