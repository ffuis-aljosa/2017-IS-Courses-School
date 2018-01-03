namespace Courses_School
{
    partial class informationsAboutStudentsForm
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
            this.addNewStudentButton = new System.Windows.Forms.Button();
            this.informationsAboutStudentsListView = new System.Windows.Forms.ListView();
            this.firstNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jmbgColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOfBirthColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.membershipCostcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // addNewStudentButton
            // 
            this.addNewStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewStudentButton.Location = new System.Drawing.Point(777, 12);
            this.addNewStudentButton.Name = "addNewStudentButton";
            this.addNewStudentButton.Size = new System.Drawing.Size(341, 39);
            this.addNewStudentButton.TabIndex = 2;
            this.addNewStudentButton.Text = "Dodaj novog učenika";
            this.addNewStudentButton.UseVisualStyleBackColor = true;
            this.addNewStudentButton.Click += new System.EventHandler(this.addNewStudentButton_Click);
            // 
            // informationsAboutStudentsListView
            // 
            this.informationsAboutStudentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstNameColumnHeader,
            this.lastNameColumnHeader,
            this.jmbgColumnHeader,
            this.dateOfBirthColumnHeader,
            this.addressColumnHeader,
            this.phoneNumberColumnHeader,
            this.membershipCostcolumnHeader});
            this.informationsAboutStudentsListView.GridLines = true;
            this.informationsAboutStudentsListView.Location = new System.Drawing.Point(12, 66);
            this.informationsAboutStudentsListView.Name = "informationsAboutStudentsListView";
            this.informationsAboutStudentsListView.Size = new System.Drawing.Size(1066, 419);
            this.informationsAboutStudentsListView.TabIndex = 3;
            this.informationsAboutStudentsListView.UseCompatibleStateImageBehavior = false;
            this.informationsAboutStudentsListView.View = System.Windows.Forms.View.Details;
            // 
            // firstNameColumnHeader
            // 
            this.firstNameColumnHeader.Text = "Ime";
            this.firstNameColumnHeader.Width = 150;
            // 
            // lastNameColumnHeader
            // 
            this.lastNameColumnHeader.Text = "Prezime";
            this.lastNameColumnHeader.Width = 150;
            // 
            // jmbgColumnHeader
            // 
            this.jmbgColumnHeader.Text = "JMBG";
            this.jmbgColumnHeader.Width = 150;
            // 
            // dateOfBirthColumnHeader
            // 
            this.dateOfBirthColumnHeader.Text = "Datum rođenja";
            this.dateOfBirthColumnHeader.Width = 150;
            // 
            // addressColumnHeader
            // 
            this.addressColumnHeader.Text = "Adresa stanovanja";
            this.addressColumnHeader.Width = 150;
            // 
            // phoneNumberColumnHeader
            // 
            this.phoneNumberColumnHeader.Text = "Broj telefona";
            this.phoneNumberColumnHeader.Width = 150;
            // 
            // membershipCostcolumnHeader
            // 
            this.membershipCostcolumnHeader.Text = "Mjesečna članarina";
            this.membershipCostcolumnHeader.Width = 150;
            // 
            // informationsAboutStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 538);
            this.Controls.Add(this.informationsAboutStudentsListView);
            this.Controls.Add(this.addNewStudentButton);
            this.Name = "informationsAboutStudentsForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addNewStudentButton;
        private System.Windows.Forms.ListView informationsAboutStudentsListView;
        private System.Windows.Forms.ColumnHeader firstNameColumnHeader;
        private System.Windows.Forms.ColumnHeader lastNameColumnHeader;
        private System.Windows.Forms.ColumnHeader jmbgColumnHeader;
        private System.Windows.Forms.ColumnHeader dateOfBirthColumnHeader;
        private System.Windows.Forms.ColumnHeader addressColumnHeader;
        private System.Windows.Forms.ColumnHeader phoneNumberColumnHeader;
        private System.Windows.Forms.ColumnHeader membershipCostcolumnHeader;
    }
}