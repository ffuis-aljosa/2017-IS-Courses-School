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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addNewSchoolSubjectForm));
            this.searchSchoolSubjectLabel = new System.Windows.Forms.Label();
            this.changeSchoolSubjectButton = new System.Windows.Forms.Button();
            this.deleteSchoolSubjectButton = new System.Windows.Forms.Button();
            this.schoolSubjectListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schoolSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numberOfClasses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numberOfCLassesAddSchoolSubject = new System.Windows.Forms.Label();
            this.numberOfClassesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addSchoolSubjectButton = new System.Windows.Forms.Button();
            this.subjectAddSchoolSubjectLabel = new System.Windows.Forms.Label();
            this.schoolSubjectTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchSchoolSubjectLabel
            // 
            this.searchSchoolSubjectLabel.AutoSize = true;
            this.searchSchoolSubjectLabel.Location = new System.Drawing.Point(275, 303);
            this.searchSchoolSubjectLabel.Name = "searchSchoolSubjectLabel";
            this.searchSchoolSubjectLabel.Size = new System.Drawing.Size(33, 13);
            this.searchSchoolSubjectLabel.TabIndex = 31;
            this.searchSchoolSubjectLabel.Text = "Traži:";
            // 
            // changeSchoolSubjectButton
            // 
            this.changeSchoolSubjectButton.Location = new System.Drawing.Point(29, 256);
            this.changeSchoolSubjectButton.Name = "changeSchoolSubjectButton";
            this.changeSchoolSubjectButton.Size = new System.Drawing.Size(209, 23);
            this.changeSchoolSubjectButton.TabIndex = 29;
            this.changeSchoolSubjectButton.Text = "Izmijeni";
            this.changeSchoolSubjectButton.UseVisualStyleBackColor = true;
            this.changeSchoolSubjectButton.Click += new System.EventHandler(this.changeSchoolSubjectButton_Click_1);
            // 
            // deleteSchoolSubjectButton
            // 
            this.deleteSchoolSubjectButton.Location = new System.Drawing.Point(29, 209);
            this.deleteSchoolSubjectButton.Name = "deleteSchoolSubjectButton";
            this.deleteSchoolSubjectButton.Size = new System.Drawing.Size(209, 23);
            this.deleteSchoolSubjectButton.TabIndex = 28;
            this.deleteSchoolSubjectButton.Text = "Obriši";
            this.deleteSchoolSubjectButton.UseVisualStyleBackColor = true;
            this.deleteSchoolSubjectButton.Click += new System.EventHandler(this.deleteSchoolSubjectButton_Click);
            // 
            // schoolSubjectListView
            // 
            this.schoolSubjectListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.schoolSubjectListView.BackColor = System.Drawing.SystemColors.Window;
            this.schoolSubjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.schoolSubject,
            this.numberOfClasses});
            this.schoolSubjectListView.FullRowSelect = true;
            this.schoolSubjectListView.GridLines = true;
            this.schoolSubjectListView.HoverSelection = true;
            this.schoolSubjectListView.Location = new System.Drawing.Point(278, 27);
            this.schoolSubjectListView.Name = "schoolSubjectListView";
            this.schoolSubjectListView.Size = new System.Drawing.Size(391, 252);
            this.schoolSubjectListView.TabIndex = 27;
            this.schoolSubjectListView.UseCompatibleStateImageBehavior = false;
            this.schoolSubjectListView.View = System.Windows.Forms.View.Details;
            this.schoolSubjectListView.SelectedIndexChanged += new System.EventHandler(this.schoolSubjectListView_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "Br.";
            this.id.Width = 0;
            // 
            // schoolSubject
            // 
            this.schoolSubject.Text = "Predmet";
            this.schoolSubject.Width = 220;
            // 
            // numberOfClasses
            // 
            this.numberOfClasses.Text = "Broj časova";
            this.numberOfClasses.Width = 167;
            // 
            // numberOfCLassesAddSchoolSubject
            // 
            this.numberOfCLassesAddSchoolSubject.AutoSize = true;
            this.numberOfCLassesAddSchoolSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOfCLassesAddSchoolSubject.Location = new System.Drawing.Point(29, 95);
            this.numberOfCLassesAddSchoolSubject.Name = "numberOfCLassesAddSchoolSubject";
            this.numberOfCLassesAddSchoolSubject.Size = new System.Drawing.Size(73, 15);
            this.numberOfCLassesAddSchoolSubject.TabIndex = 26;
            this.numberOfCLassesAddSchoolSubject.Text = "Broj casova:";
            // 
            // numberOfClassesTextBox
            // 
            this.numberOfClassesTextBox.Location = new System.Drawing.Point(29, 113);
            this.numberOfClassesTextBox.Name = "numberOfClassesTextBox";
            this.numberOfClassesTextBox.Size = new System.Drawing.Size(212, 20);
            this.numberOfClassesTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 24;
            // 
            // addSchoolSubjectButton
            // 
            this.addSchoolSubjectButton.Location = new System.Drawing.Point(29, 161);
            this.addSchoolSubjectButton.Name = "addSchoolSubjectButton";
            this.addSchoolSubjectButton.Size = new System.Drawing.Size(209, 23);
            this.addSchoolSubjectButton.TabIndex = 23;
            this.addSchoolSubjectButton.Text = "Dodaj";
            this.addSchoolSubjectButton.UseVisualStyleBackColor = true;
            this.addSchoolSubjectButton.Click += new System.EventHandler(this.addSchoolSubjectButton_Click_1);
            // 
            // subjectAddSchoolSubjectLabel
            // 
            this.subjectAddSchoolSubjectLabel.AutoSize = true;
            this.subjectAddSchoolSubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subjectAddSchoolSubjectLabel.Location = new System.Drawing.Point(29, 38);
            this.subjectAddSchoolSubjectLabel.Name = "subjectAddSchoolSubjectLabel";
            this.subjectAddSchoolSubjectLabel.Size = new System.Drawing.Size(132, 15);
            this.subjectAddSchoolSubjectLabel.TabIndex = 22;
            this.subjectAddSchoolSubjectLabel.Text = "Naziv novog predmeta:";
            // 
            // schoolSubjectTextBox
            // 
            this.schoolSubjectTextBox.Location = new System.Drawing.Point(29, 56);
            this.schoolSubjectTextBox.Name = "schoolSubjectTextBox";
            this.schoolSubjectTextBox.Size = new System.Drawing.Size(212, 20);
            this.schoolSubjectTextBox.TabIndex = 21;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(278, 319);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(391, 20);
            this.searchTextBox.TabIndex = 32;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // addNewSchoolSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(707, 360);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchSchoolSubjectLabel);
            this.Controls.Add(this.changeSchoolSubjectButton);
            this.Controls.Add(this.deleteSchoolSubjectButton);
            this.Controls.Add(this.schoolSubjectListView);
            this.Controls.Add(this.numberOfCLassesAddSchoolSubject);
            this.Controls.Add(this.numberOfClassesTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSchoolSubjectButton);
            this.Controls.Add(this.subjectAddSchoolSubjectLabel);
            this.Controls.Add(this.schoolSubjectTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addNewSchoolSubjectForm";
            this.Text = "Predmeti";
            this.Load += new System.EventHandler(this.addNewSchoolSubjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchSchoolSubjectLabel;
        private System.Windows.Forms.Button changeSchoolSubjectButton;
        private System.Windows.Forms.Button deleteSchoolSubjectButton;
        private System.Windows.Forms.ListView schoolSubjectListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader schoolSubject;
        private System.Windows.Forms.ColumnHeader numberOfClasses;
        private System.Windows.Forms.Label numberOfCLassesAddSchoolSubject;
        private System.Windows.Forms.TextBox numberOfClassesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSchoolSubjectButton;
        private System.Windows.Forms.Label subjectAddSchoolSubjectLabel;
        private System.Windows.Forms.TextBox schoolSubjectTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}