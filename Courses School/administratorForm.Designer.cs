namespace Courses_School
{
    partial class administratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(administratorForm));
            this.schoolTimetableButton = new System.Windows.Forms.Button();
            this.schoolSubjectbutton = new System.Windows.Forms.Button();
            this.informationsAboutStudentsButton = new System.Windows.Forms.Button();
            this.informationsAboutEmployeesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // schoolTimetableButton
            // 
            this.schoolTimetableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.schoolTimetableButton.Location = new System.Drawing.Point(305, 146);
            this.schoolTimetableButton.Name = "schoolTimetableButton";
            this.schoolTimetableButton.Size = new System.Drawing.Size(158, 66);
            this.schoolTimetableButton.TabIndex = 0;
            this.schoolTimetableButton.Text = "Raspored";
            this.schoolTimetableButton.UseVisualStyleBackColor = true;
            this.schoolTimetableButton.Click += new System.EventHandler(this.schoolTimetableButton_Click);
            // 
            // schoolSubjectbutton
            // 
            this.schoolSubjectbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.schoolSubjectbutton.Location = new System.Drawing.Point(98, 62);
            this.schoolSubjectbutton.Name = "schoolSubjectbutton";
            this.schoolSubjectbutton.Size = new System.Drawing.Size(158, 66);
            this.schoolSubjectbutton.TabIndex = 1;
            this.schoolSubjectbutton.Text = "Predmeti";
            this.schoolSubjectbutton.UseVisualStyleBackColor = true;
            this.schoolSubjectbutton.Click += new System.EventHandler(this.schoolSubjectbutton_Click);
            // 
            // informationsAboutStudentsButton
            // 
            this.informationsAboutStudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.informationsAboutStudentsButton.Location = new System.Drawing.Point(98, 146);
            this.informationsAboutStudentsButton.Name = "informationsAboutStudentsButton";
            this.informationsAboutStudentsButton.Size = new System.Drawing.Size(158, 66);
            this.informationsAboutStudentsButton.TabIndex = 2;
            this.informationsAboutStudentsButton.Text = "Podaci o učenicima";
            this.informationsAboutStudentsButton.UseVisualStyleBackColor = true;
            this.informationsAboutStudentsButton.Click += new System.EventHandler(this.informationsAboutStudentsButton_Click);
            // 
            // informationsAboutEmployeesButton
            // 
            this.informationsAboutEmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.informationsAboutEmployeesButton.Location = new System.Drawing.Point(305, 62);
            this.informationsAboutEmployeesButton.Name = "informationsAboutEmployeesButton";
            this.informationsAboutEmployeesButton.Size = new System.Drawing.Size(158, 66);
            this.informationsAboutEmployeesButton.TabIndex = 3;
            this.informationsAboutEmployeesButton.Text = "Podaci o zaposlenima";
            this.informationsAboutEmployeesButton.UseVisualStyleBackColor = true;
            this.informationsAboutEmployeesButton.Click += new System.EventHandler(this.informationsAboutEmployeesButton_Click);
            // 
            // administratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(560, 319);
            this.Controls.Add(this.informationsAboutEmployeesButton);
            this.Controls.Add(this.informationsAboutStudentsButton);
            this.Controls.Add(this.schoolSubjectbutton);
            this.Controls.Add(this.schoolTimetableButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "administratorForm";
            this.Text = "administratorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button schoolTimetableButton;
        private System.Windows.Forms.Button schoolSubjectbutton;
        private System.Windows.Forms.Button informationsAboutStudentsButton;
        private System.Windows.Forms.Button informationsAboutEmployeesButton;
    }
}