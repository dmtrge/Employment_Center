namespace Employment_center_v2._0
{
    partial class preadmin
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
            this.authbtn = new System.Windows.Forms.Button();
            this.passwdbox = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authbtn
            // 
            this.authbtn.Location = new System.Drawing.Point(12, 77);
            this.authbtn.Name = "authbtn";
            this.authbtn.Size = new System.Drawing.Size(116, 23);
            this.authbtn.TabIndex = 1;
            this.authbtn.Text = "Авторизироваться";
            this.authbtn.UseVisualStyleBackColor = true;
            this.authbtn.Click += new System.EventHandler(this.authbtn_Click);
            // 
            // passwdbox
            // 
            this.passwdbox.Location = new System.Drawing.Point(70, 25);
            this.passwdbox.Name = "passwdbox";
            this.passwdbox.Size = new System.Drawing.Size(123, 20);
            this.passwdbox.TabIndex = 0;
            this.passwdbox.Text = "Введите сюда пароль";
            this.passwdbox.UseSystemPasswordChar = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(167, 77);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 2;
            this.cancelbtn.Text = "Отмена";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // preadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(254, 127);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.passwdbox);
            this.Controls.Add(this.authbtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "preadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "preadmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authbtn;
        private System.Windows.Forms.TextBox passwdbox;
        private System.Windows.Forms.Button cancelbtn;
    }
}