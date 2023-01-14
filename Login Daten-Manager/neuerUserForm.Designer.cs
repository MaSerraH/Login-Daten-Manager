namespace Login_Daten_Manager
{
    partial class neuerUserForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnZumLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(414, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 44);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnZumLogin
            // 
            this.btnZumLogin.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZumLogin.Location = new System.Drawing.Point(81, 375);
            this.btnZumLogin.Name = "btnZumLogin";
            this.btnZumLogin.Size = new System.Drawing.Size(182, 44);
            this.btnZumLogin.TabIndex = 1;
            this.btnZumLogin.Text = "zum Login";
            this.btnZumLogin.UseVisualStyleBackColor = true;
            this.btnZumLogin.Click += new System.EventHandler(this.btnZumLogin_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "e-mail:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Passwort:";
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(165, 28);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(309, 34);
            this.tb1.TabIndex = 5;
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.Location = new System.Drawing.Point(165, 93);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(309, 34);
            this.tb2.TabIndex = 6;
            // 
            // tb3
            // 
            this.tb3.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb3.Location = new System.Drawing.Point(161, 152);
            this.tb3.Name = "tb3";
            this.tb3.PasswordChar = '?';
            this.tb3.Size = new System.Drawing.Size(309, 34);
            this.tb3.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tb3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(50, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 215);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "neuer User anlegen";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(242, 315);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(200, 43);
            this.btnSpeichern.TabIndex = 10;
            this.btnSpeichern.Text = "User speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // neuerUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnZumLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Name = "neuerUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "neuer User Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnZumLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSpeichern;
    }
}