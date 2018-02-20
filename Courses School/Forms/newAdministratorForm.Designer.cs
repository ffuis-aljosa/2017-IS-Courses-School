namespace Courses_School
{
    partial class newAdministratorForm
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
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordlabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.addNewUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(60, 268);
            this.repeatPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.PasswordChar = '*';
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(237, 22);
            this.repeatPasswordTextBox.TabIndex = 14;
            // 
            // repeatPasswordlabel
            // 
            this.repeatPasswordlabel.AutoSize = true;
            this.repeatPasswordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.repeatPasswordlabel.Location = new System.Drawing.Point(21, 221);
            this.repeatPasswordlabel.Name = "repeatPasswordlabel";
            this.repeatPasswordlabel.Size = new System.Drawing.Size(152, 24);
            this.repeatPasswordlabel.TabIndex = 13;
            this.repeatPasswordlabel.Text = "Ponovite lozinku:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.passwordLabel.Location = new System.Drawing.Point(21, 131);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(79, 24);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Lozinka:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(60, 177);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(237, 22);
            this.passwordTextBox.TabIndex = 11;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.usernameLabel.Location = new System.Drawing.Point(21, 37);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(138, 24);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "Korisničko ime:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(60, 88);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(237, 22);
            this.usernameTextBox.TabIndex = 9;
            // 
            // addNewUserButton
            // 
            this.addNewUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.addNewUserButton.Location = new System.Drawing.Point(40, 359);
            this.addNewUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewUserButton.Name = "addNewUserButton";
            this.addNewUserButton.Size = new System.Drawing.Size(273, 38);
            this.addNewUserButton.TabIndex = 8;
            this.addNewUserButton.Text = "Dodaj!";
            this.addNewUserButton.UseVisualStyleBackColor = true;
            this.addNewUserButton.Click += new System.EventHandler(this.addNewUserButton_Click);
            // 
            // newAdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(367, 480);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.repeatPasswordlabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.addNewUserButton);
            this.MaximizeBox = false;
            this.Name = "newAdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Label repeatPasswordlabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button addNewUserButton;
    }
}