namespace Courses_School
{
    partial class newUserForm
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
            this.newUserLabel = new System.Windows.Forms.Label();
            this.addNewUserButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.repeatPasswordlabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newUserLabel
            // 
            this.newUserLabel.AutoSize = true;
            this.newUserLabel.Location = new System.Drawing.Point(134, 58);
            this.newUserLabel.Name = "newUserLabel";
            this.newUserLabel.Size = new System.Drawing.Size(88, 17);
            this.newUserLabel.TabIndex = 0;
            this.newUserLabel.Text = "Novi korisnik";
            // 
            // addNewUserButton
            // 
            this.addNewUserButton.Location = new System.Drawing.Point(44, 331);
            this.addNewUserButton.Name = "addNewUserButton";
            this.addNewUserButton.Size = new System.Drawing.Size(273, 38);
            this.addNewUserButton.TabIndex = 1;
            this.addNewUserButton.Text = "Dodaj";
            this.addNewUserButton.UseVisualStyleBackColor = true;
            this.addNewUserButton.Click += new System.EventHandler(this.addNewUserButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(57, 138);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(237, 22);
            this.usernameTextBox.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(54, 107);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(103, 17);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Korisničko ime:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(57, 192);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(237, 22);
            this.passwordTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(66, 172);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 17);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Lozinka";
            // 
            // repeatPasswordlabel
            // 
            this.repeatPasswordlabel.AutoSize = true;
            this.repeatPasswordlabel.Location = new System.Drawing.Point(66, 217);
            this.repeatPasswordlabel.Name = "repeatPasswordlabel";
            this.repeatPasswordlabel.Size = new System.Drawing.Size(111, 17);
            this.repeatPasswordlabel.TabIndex = 6;
            this.repeatPasswordlabel.Text = "Ponovite lozinku";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(57, 250);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.PasswordChar = '*';
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(244, 22);
            this.repeatPasswordTextBox.TabIndex = 7;
            // 
            // newUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(369, 424);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.repeatPasswordlabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.addNewUserButton);
            this.Controls.Add(this.newUserLabel);
            this.Name = "newUserForm";
            this.Text = "NewUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newUserLabel;
        private System.Windows.Forms.Button addNewUserButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label repeatPasswordlabel;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
    }
}