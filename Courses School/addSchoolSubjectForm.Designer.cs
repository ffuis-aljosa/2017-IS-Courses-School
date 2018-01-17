namespace Courses_School
{
    partial class addSchoolSubjectForm
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
            this.subjectAddSchoolSubjectTextBox = new System.Windows.Forms.TextBox();
            this.subjectAddSchoolSubjectLabel = new System.Windows.Forms.Label();
            this.addSchoolSubjectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfClassesAddSchoolSubjectTextBox = new System.Windows.Forms.TextBox();
            this.numberOfCLassesAddSchoolSubject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subjectAddSchoolSubjectTextBox
            // 
            this.subjectAddSchoolSubjectTextBox.Location = new System.Drawing.Point(217, 49);
            this.subjectAddSchoolSubjectTextBox.Name = "subjectAddSchoolSubjectTextBox";
            this.subjectAddSchoolSubjectTextBox.Size = new System.Drawing.Size(319, 20);
            this.subjectAddSchoolSubjectTextBox.TabIndex = 0;
            // 
            // subjectAddSchoolSubjectLabel
            // 
            this.subjectAddSchoolSubjectLabel.AutoSize = true;
            this.subjectAddSchoolSubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subjectAddSchoolSubjectLabel.Location = new System.Drawing.Point(56, 54);
            this.subjectAddSchoolSubjectLabel.Name = "subjectAddSchoolSubjectLabel";
            this.subjectAddSchoolSubjectLabel.Size = new System.Drawing.Size(132, 15);
            this.subjectAddSchoolSubjectLabel.TabIndex = 2;
            this.subjectAddSchoolSubjectLabel.Text = "Naziv novog predmeta:";
            // 
            // addSchoolSubjectButton
            // 
            this.addSchoolSubjectButton.Location = new System.Drawing.Point(376, 167);
            this.addSchoolSubjectButton.Name = "addSchoolSubjectButton";
            this.addSchoolSubjectButton.Size = new System.Drawing.Size(160, 23);
            this.addSchoolSubjectButton.TabIndex = 4;
            this.addSchoolSubjectButton.Text = "Dodaj!";
            this.addSchoolSubjectButton.UseVisualStyleBackColor = true;
            this.addSchoolSubjectButton.Click += new System.EventHandler(this.addSchoolSubjectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // numberOfClassesAddSchoolSubjectTextBox
            // 
            this.numberOfClassesAddSchoolSubjectTextBox.Location = new System.Drawing.Point(217, 100);
            this.numberOfClassesAddSchoolSubjectTextBox.Name = "numberOfClassesAddSchoolSubjectTextBox";
            this.numberOfClassesAddSchoolSubjectTextBox.Size = new System.Drawing.Size(319, 20);
            this.numberOfClassesAddSchoolSubjectTextBox.TabIndex = 7;
            // 
            // numberOfCLassesAddSchoolSubject
            // 
            this.numberOfCLassesAddSchoolSubject.AutoSize = true;
            this.numberOfCLassesAddSchoolSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOfCLassesAddSchoolSubject.Location = new System.Drawing.Point(115, 105);
            this.numberOfCLassesAddSchoolSubject.Name = "numberOfCLassesAddSchoolSubject";
            this.numberOfCLassesAddSchoolSubject.Size = new System.Drawing.Size(73, 15);
            this.numberOfCLassesAddSchoolSubject.TabIndex = 8;
            this.numberOfCLassesAddSchoolSubject.Text = "Broj casova:";
            // 
            // addSchoolSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(641, 329);
            this.Controls.Add(this.numberOfCLassesAddSchoolSubject);
            this.Controls.Add(this.numberOfClassesAddSchoolSubjectTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSchoolSubjectButton);
            this.Controls.Add(this.subjectAddSchoolSubjectLabel);
            this.Controls.Add(this.subjectAddSchoolSubjectTextBox);
            this.Name = "addSchoolSubjectForm";
            this.Text = "Dodaj novi predmet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subjectAddSchoolSubjectTextBox;
        private System.Windows.Forms.Label subjectAddSchoolSubjectLabel;
        private System.Windows.Forms.Button addSchoolSubjectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfClassesAddSchoolSubjectTextBox;
        private System.Windows.Forms.Label numberOfCLassesAddSchoolSubject;
    }
}