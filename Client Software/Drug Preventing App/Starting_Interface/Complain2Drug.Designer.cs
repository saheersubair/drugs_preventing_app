namespace Starting_Interface
{
    partial class Complain2Drug
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1151, 636);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 33);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPlace
            // 
            this.btnPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlace.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnPlace.FlatAppearance.BorderSize = 10;
            this.btnPlace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlace.Location = new System.Drawing.Point(36, 521);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(551, 65);
            this.btnPlace.TabIndex = 6;
            this.btnPlace.Text = "Place of Drug Dealing";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPerson.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnPerson.FlatAppearance.BorderSize = 10;
            this.btnPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerson.Location = new System.Drawing.Point(36, 297);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(551, 65);
            this.btnPerson.TabIndex = 5;
            this.btnPerson.Text = "Victim";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // lblQ2
            // 
            this.lblQ2.AutoSize = true;
            this.lblQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ2.Location = new System.Drawing.Point(26, 106);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(1251, 110);
            this.lblQ2.TabIndex = 4;
            this.lblQ2.Text = "IS YOUR COMPLAINT IS ABOUT A PERSON / PLACE\r\nOF DRUG DEALING ?\r\n";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(551, 65);
            this.button1.TabIndex = 8;
            this.button1.Text = "Drug Dealer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Complain2Drug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.btnPerson);
            this.Controls.Add(this.lblQ2);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Complain2Drug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drug Preventing App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Complain2Drug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Label lblQ2;
        private System.Windows.Forms.Button button1;
    }
}