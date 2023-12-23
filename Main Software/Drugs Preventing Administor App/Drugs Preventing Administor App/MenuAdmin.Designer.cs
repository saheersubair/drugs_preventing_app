namespace Drugs_Preventing_Administor_App
{
    partial class MenuAdmin
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
            this.btncomplain = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnPublic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncomplain
            // 
            this.btncomplain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncomplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomplain.Location = new System.Drawing.Point(76, 208);
            this.btncomplain.Margin = new System.Windows.Forms.Padding(2);
            this.btncomplain.Name = "btncomplain";
            this.btncomplain.Size = new System.Drawing.Size(386, 43);
            this.btncomplain.TabIndex = 1;
            this.btncomplain.Text = "Complains";
            this.btncomplain.UseVisualStyleBackColor = true;
            this.btncomplain.Click += new System.EventHandler(this.btnPersoncomplain_Click);
            // 
            // btnManage
            // 
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnManage.Location = new System.Drawing.Point(76, 287);
            this.btnManage.Margin = new System.Windows.Forms.Padding(2);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(386, 43);
            this.btnManage.TabIndex = 3;
            this.btnManage.Text = "Manage Users";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1154, 633);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 37);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(1051, 633);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(99, 37);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(76, 458);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(386, 43);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnPublic
            // 
            this.btnPublic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublic.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnPublic.Location = new System.Drawing.Point(76, 371);
            this.btnPublic.Margin = new System.Windows.Forms.Padding(2);
            this.btnPublic.Name = "btnPublic";
            this.btnPublic.Size = new System.Drawing.Size(386, 43);
            this.btnPublic.TabIndex = 8;
            this.btnPublic.Text = "Public Profiles";
            this.btnPublic.UseVisualStyleBackColor = true;
            this.btnPublic.Click += new System.EventHandler(this.btnPublic_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnPublic);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btncomplain);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btncomplain;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnPublic;
    }
}