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
            this.SuspendLayout();
            // 
            // authbtn
            // 
            this.authbtn.Location = new System.Drawing.Point(74, 174);
            this.authbtn.Name = "authbtn";
            this.authbtn.Size = new System.Drawing.Size(116, 23);
            this.authbtn.TabIndex = 0;
            this.authbtn.Text = "Авторизироваться";
            this.authbtn.UseVisualStyleBackColor = true;
            this.authbtn.Click += new System.EventHandler(this.authbtn_Click);
            // 
            // passwdbox
            // 
            this.passwdbox.Location = new System.Drawing.Point(74, 74);
            this.passwdbox.Name = "passwdbox";
            this.passwdbox.Size = new System.Drawing.Size(123, 20);
            this.passwdbox.TabIndex = 1;
            this.passwdbox.Text = "Введите сюда пароль";
            // 
            // preadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.passwdbox);
            this.Controls.Add(this.authbtn);
            this.Name = "preadmin";
            this.Text = "preadmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authbtn;
        private System.Windows.Forms.TextBox passwdbox;
    }
}