namespace Employment_center_v2._0
{
    partial class preeditform
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
            this.vacbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vacbtn
            // 
            this.vacbtn.Location = new System.Drawing.Point(3, 55);
            this.vacbtn.Name = "vacbtn";
            this.vacbtn.Size = new System.Drawing.Size(75, 23);
            this.vacbtn.TabIndex = 0;
            this.vacbtn.Text = "Вакансии";
            this.vacbtn.UseVisualStyleBackColor = true;
            this.vacbtn.Click += new System.EventHandler(this.vacbtn_Click);
            // 
            // preeditform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.vacbtn);
            this.Name = "preeditform";
            this.Text = "preeditform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vacbtn;
    }
}