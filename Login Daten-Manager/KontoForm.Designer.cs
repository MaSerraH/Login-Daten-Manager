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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginpasswortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNeuStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDMdatenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__DBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(313, 707);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 53);
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
            this.loginpasswortDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lDMdatenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(672, 252);
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
            this.panel1.Size = new System.Drawing.Size(729, 321);
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
            this.btnSpeichern.Location = new System.Drawing.Point(151, 300);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(135, 42);
            this.btnSpeichern.TabIndex = 10;
            this.btnSpeichern.Text = "speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnLöschen
            // 
            this.btnLöschen.Location = new System.Drawing.Point(349, 300);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(150, 42);
            this.btnLöschen.TabIndex = 11;
            this.btnLöschen.Text = "löschen";
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // loginnameDataGridViewTextBoxColumn
            // 
            this.loginnameDataGridViewTextBoxColumn.DataPropertyName = "Loginname";
            this.loginnameDataGridViewTextBoxColumn.HeaderText = "Loginname";
            this.loginnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginnameDataGridViewTextBoxColumn.Name = "loginnameDataGridViewTextBoxColumn";
            // 
            // loginpasswortDataGridViewTextBoxColumn
            // 
            this.loginpasswortDataGridViewTextBoxColumn.DataPropertyName = "Loginpasswort";
            this.loginpasswortDataGridViewTextBoxColumn.HeaderText = "Loginpasswort";
            this.loginpasswortDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginpasswortDataGridViewTextBoxColumn.Name = "loginpasswortDataGridViewTextBoxColumn";
            // 
            // btnNeuStart
            // 
            this.btnNeuStart.Location = new System.Drawing.Point(589, 300);
            this.btnNeuStart.Name = "btnNeuStart";
            this.btnNeuStart.Size = new System.Drawing.Size(143, 42);
            this.btnNeuStart.TabIndex = 13;
            this.btnNeuStart.Text = "neu Start";
            this.btnNeuStart.UseVisualStyleBackColor = true;
            this.btnNeuStart.Click += new System.EventHandler(this.btnNeuStart_Click);
            // 
            // KontoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 797);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginpasswortDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNeuStart;
    }
}