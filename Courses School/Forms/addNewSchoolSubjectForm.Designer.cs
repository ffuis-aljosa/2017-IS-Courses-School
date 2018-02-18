namespace Courses_School
{
    partial class addNewSchoolSubjectForm
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
            this.SchoolSubjectListView = new System.Windows.Forms.ListView();
            this.numberOfCLassesAddSchoolSubject = new System.Windows.Forms.Label();
            this.numberOfClassesAddSchoolSubjectTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addSchoolSubjectButton = new System.Windows.Forms.Button();
            this.subjectAddSchoolSubjectLabel = new System.Windows.Forms.Label();
            this.subjectAddSchoolSubjectTextBox = new System.Windows.Forms.TextBox();
            this.deleteSchoolSubjectButton = new System.Windows.Forms.Button();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schoolSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numberOfClasses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // SchoolSubjectListView
            // 
            this.SchoolSubjectListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.SchoolSubjectListView.BackColor = System.Drawing.SystemColors.Window;
            this.SchoolSubjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.schoolSubject,
            this.numberOfClasses});
            this.SchoolSubjectListView.GridLines = true;
            this.SchoolSubjectListView.HoverSelection = true;
            this.SchoolSubjectListView.Location = new System.Drawing.Point(296, 24);
            this.SchoolSubjectListView.Name = "SchoolSubjectListView";
            this.SchoolSubjectListView.Size = new System.Drawing.Size(391, 289);
            this.SchoolSubjectListView.TabIndex = 16;
            this.SchoolSubjectListView.UseCompatibleStateImageBehavior = false;
            this.SchoolSubjectListView.View = System.Windows.Forms.View.Details;
            this.SchoolSubjectListView.SelectedIndexChanged += new System.EventHandler(this.SchoolSubjectListView_SelectedIndexChanged_1);
            // 
            // numberOfCLassesAddSchoolSubject
            // 
            this.numberOfCLassesAddSchoolSubject.AutoSize = true;
            this.numberOfCLassesAddSchoolSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOfCLassesAddSchoolSubject.Location = new System.Drawing.Point(47, 92);
            this.numberOfCLassesAddSchoolSubject.Name = "numberOfCLassesAddSchoolSubject";
            this.numberOfCLassesAddSchoolSubject.Size = new System.Drawing.Size(73, 15);
            this.numberOfCLassesAddSchoolSubject.TabIndex = 15;
            this.numberOfCLassesAddSchoolSubject.Text = "Broj casova:";
            // 
            // numberOfClassesAddSchoolSubjectTextBox
            // 
            this.numberOfClassesAddSchoolSubjectTextBox.Location = new System.Drawing.Point(47, 110);
            this.numberOfClassesAddSchoolSubjectTextBox.Name = "numberOfClassesAddSchoolSubjectTextBox";
            this.numberOfClassesAddSchoolSubjectTextBox.Size = new System.Drawing.Size(212, 20);
            this.numberOfClassesAddSchoolSubjectTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // addSchoolSubjectButton
            // 
            this.addSchoolSubjectButton.Location = new System.Drawing.Point(47, 158);
            this.addSchoolSubjectButton.Name = "addSchoolSubjectButton";
            this.addSchoolSubjectButton.Size = new System.Drawing.Size(91, 23);
            this.addSchoolSubjectButton.TabIndex = 12;
            this.addSchoolSubjectButton.Text = "Dodaj!";
            this.addSchoolSubjectButton.UseVisualStyleBackColor = true;
            this.addSchoolSubjectButton.Click += new System.EventHandler(this.addSchoolSubjectButton_Click);
            // 
            // subjectAddSchoolSubjectLabel
            // 
            this.subjectAddSchoolSubjectLabel.AutoSize = true;
            this.subjectAddSchoolSubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subjectAddSchoolSubjectLabel.Location = new System.Drawing.Point(47, 35);
            this.subjectAddSchoolSubjectLabel.Name = "subjectAddSchoolSubjectLabel";
            this.subjectAddSchoolSubjectLabel.Size = new System.Drawing.Size(132, 15);
            this.subjectAddSchoolSubjectLabel.TabIndex = 11;
            this.subjectAddSchoolSubjectLabel.Text = "Naziv novog predmeta:";
            // 
            // subjectAddSchoolSubjectTextBox
            // 
            this.subjectAddSchoolSubjectTextBox.Location = new System.Drawing.Point(47, 53);
            this.subjectAddSchoolSubjectTextBox.Name = "subjectAddSchoolSubjectTextBox";
            this.subjectAddSchoolSubjectTextBox.Size = new System.Drawing.Size(212, 20);
            this.subjectAddSchoolSubjectTextBox.TabIndex = 10;
            // 
            // deleteSchoolSubjectButton
            // 
            this.deleteSchoolSubjectButton.Location = new System.Drawing.Point(164, 158);
            this.deleteSchoolSubjectButton.Name = "deleteSchoolSubjectButton";
            this.deleteSchoolSubjectButton.Size = new System.Drawing.Size(95, 23);
            this.deleteSchoolSubjectButton.TabIndex = 17;
            this.deleteSchoolSubjectButton.Text = "Obrisi";
            this.deleteSchoolSubjectButton.UseVisualStyleBackColor = true;
            this.deleteSchoolSubjectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.Text = "Br.";
            // 
            // schoolSubject
            // 
            this.schoolSubject.Text = "Predmet";
            this.schoolSubject.Width = 194;
            // 
            // numberOfClasses
            // 
            this.numberOfClasses.Text = "Broj časova";
            this.numberOfClasses.Width = 242;
            // 
            // addNewSchoolSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(699, 348);
            this.Controls.Add(this.deleteSchoolSubjectButton);
            this.Controls.Add(this.SchoolSubjectListView);
            this.Controls.Add(this.numberOfCLassesAddSchoolSubject);
            this.Controls.Add(this.numberOfClassesAddSchoolSubjectTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSchoolSubjectButton);
            this.Controls.Add(this.subjectAddSchoolSubjectLabel);
            this.Controls.Add(this.subjectAddSchoolSubjectTextBox);
            this.Name = "addNewSchoolSubjectForm";
            this.Text = "Predmeti";
            this.Load += new System.EventHandler(this.schoolSubjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView SchoolSubjectListView;
        private System.Windows.Forms.Label numberOfCLassesAddSchoolSubject;
        private System.Windows.Forms.TextBox numberOfClassesAddSchoolSubjectTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSchoolSubjectButton;
        private System.Windows.Forms.Label subjectAddSchoolSubjectLabel;
        private System.Windows.Forms.TextBox subjectAddSchoolSubjectTextBox;
        private System.Windows.Forms.Button deleteSchoolSubjectButton;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader schoolSubject;
        private System.Windows.Forms.ColumnHeader numberOfClasses;
    }
}