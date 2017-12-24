namespace Courses_School
{
    partial class schoolSubjectForm
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
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Employee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SchoolSubjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SchoolSubjectListView
            // 
            this.SchoolSubjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Subject,
            this.Employee});
            this.SchoolSubjectListView.Location = new System.Drawing.Point(24, 12);
            this.SchoolSubjectListView.Name = "SchoolSubjectListView";
            this.SchoolSubjectListView.Size = new System.Drawing.Size(654, 238);
            this.SchoolSubjectListView.TabIndex = 0;
            this.SchoolSubjectListView.UseCompatibleStateImageBehavior = false;
            this.SchoolSubjectListView.View = System.Windows.Forms.View.Details;
            // 
            // Subject
            // 
            this.Subject.Text = "Predmet";
            this.Subject.Width = 324;
            // 
            // Employee
            // 
            this.Employee.Text = "Profesor";
            this.Employee.Width = 589;
            // 
            // SchoolSubjectButton
            // 
            this.SchoolSubjectButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SchoolSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SchoolSubjectButton.Location = new System.Drawing.Point(186, 273);
            this.SchoolSubjectButton.Name = "SchoolSubjectButton";
            this.SchoolSubjectButton.Size = new System.Drawing.Size(333, 47);
            this.SchoolSubjectButton.TabIndex = 1;
            this.SchoolSubjectButton.Text = "Dodaj novi predmet";
            this.SchoolSubjectButton.UseVisualStyleBackColor = false;
            this.SchoolSubjectButton.Click += new System.EventHandler(this.SchoolSubjectButton_Click);
            // 
            // schoolSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(699, 348);
            this.Controls.Add(this.SchoolSubjectButton);
            this.Controls.Add(this.SchoolSubjectListView);
            this.Name = "schoolSubjectForm";
            this.Text = "Predmeti";
            this.Load += new System.EventHandler(this.schoolSubjectForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView SchoolSubjectListView;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader Employee;
        private System.Windows.Forms.Button SchoolSubjectButton;
    }
}