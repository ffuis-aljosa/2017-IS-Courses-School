﻿namespace Courses_School
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.administratorLoginButton = new System.Windows.Forms.Button();
            this.userLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // administratorLoginButton
            // 
            this.administratorLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.administratorLoginButton.Location = new System.Drawing.Point(196, 101);
            this.administratorLoginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.administratorLoginButton.Name = "administratorLoginButton";
            this.administratorLoginButton.Size = new System.Drawing.Size(291, 57);
            this.administratorLoginButton.TabIndex = 0;
            this.administratorLoginButton.Text = "Administrator";
            this.administratorLoginButton.UseVisualStyleBackColor = true;
            this.administratorLoginButton.Click += new System.EventHandler(this.administratorButton_Click);
            // 
            // userLoginButton
            // 
            this.userLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.userLoginButton.Location = new System.Drawing.Point(196, 185);
            this.userLoginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userLoginButton.Name = "userLoginButton";
            this.userLoginButton.Size = new System.Drawing.Size(291, 57);
            this.userLoginButton.TabIndex = 1;
            this.userLoginButton.Text = "Korisnik";
            this.userLoginButton.UseVisualStyleBackColor = true;
            this.userLoginButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 398);
            this.Controls.Add(this.userLoginButton);
            this.Controls.Add(this.administratorLoginButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button administratorLoginButton;
        private System.Windows.Forms.Button userLoginButton;
    }
}

