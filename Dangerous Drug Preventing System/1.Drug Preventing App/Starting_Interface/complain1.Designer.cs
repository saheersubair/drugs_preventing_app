namespace Starting_Interface
{
    partial class complain1
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
            this.lblQ = new System.Windows.Forms.Label();
            this.btnDrug = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ.Location = new System.Drawing.Point(48, 80);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(916, 55);
            this.lblQ.TabIndex = 0;
            this.lblQ.Text = "WHAT IS YOUR COMPLAINT ABOUT ?";
            // 
            // btnDrug
            // 
            this.btnDrug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrug.Location = new System.Drawing.Point(54, 189);
            this.btnDrug.Name = "btnDrug";
            this.btnDrug.Size = new System.Drawing.Size(433, 53);
            this.btnDrug.TabIndex = 1;
            this.btnDrug.Text = "Drugs";
            this.btnDrug.UseVisualStyleBackColor = true;
            this.btnDrug.Click += new System.EventHandler(this.btnDrug_Click);
            // 
            // btnOther
            // 
            this.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.Location = new System.Drawing.Point(54, 300);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(433, 53);
            this.btnOther.TabIndex = 2;
            this.btnOther.Text = "Other";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1152, 633);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // complain1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.btnDrug);
            this.Controls.Add(this.lblQ);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "complain1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.complain1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Button btnDrug;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnBack;
    }
}