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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.uplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // schoolTimetableButton
            // 
            this.schoolTimetableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.schoolTimetableButton.Location = new System.Drawing.Point(391, 195);
            this.schoolTimetableButton.Margin = new System.Windows.Forms.Padding(4);
            this.schoolTimetableButton.Name = "schoolTimetableButton";
            this.schoolTimetableButton.Size = new System.Drawing.Size(211, 81);
            this.schoolTimetableButton.TabIndex = 0;
            this.schoolTimetableButton.Text = "Raspored";
            this.schoolTimetableButton.UseVisualStyleBackColor = true;
            this.schoolTimetableButton.Click += new System.EventHandler(this.schoolTimetableButton_Click);
            // 
            // schoolSubjectbutton
            // 
            this.schoolSubjectbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.schoolSubjectbutton.Location = new System.Drawing.Point(115, 91);
            this.schoolSubjectbutton.Margin = new System.Windows.Forms.Padding(4);
            this.schoolSubjectbutton.Name = "schoolSubjectbutton";
            this.schoolSubjectbutton.Size = new System.Drawing.Size(211, 81);
            this.schoolSubjectbutton.TabIndex = 1;
            this.schoolSubjectbutton.Text = "Predmeti";
            this.schoolSubjectbutton.UseVisualStyleBackColor = true;
            this.schoolSubjectbutton.Click += new System.EventHandler(this.schoolSubjectbutton_Click);
            // 
            // informationsAboutStudentsButton
            // 
            this.informationsAboutStudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.informationsAboutStudentsButton.Location = new System.Drawing.Point(115, 195);
            this.informationsAboutStudentsButton.Margin = new System.Windows.Forms.Padding(4);
            this.informationsAboutStudentsButton.Name = "informationsAboutStudentsButton";
            this.informationsAboutStudentsButton.Size = new System.Drawing.Size(211, 81);
            this.informationsAboutStudentsButton.TabIndex = 2;
            this.informationsAboutStudentsButton.Text = "Podaci o učenicima";
            this.informationsAboutStudentsButton.UseVisualStyleBackColor = true;
            this.informationsAboutStudentsButton.Click += new System.EventHandler(this.informationsAboutStudentsButton_Click);
            // 
            // informationsAboutEmployeesButton
            // 
            this.informationsAboutEmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.informationsAboutEmployeesButton.Location = new System.Drawing.Point(391, 91);
            this.informationsAboutEmployeesButton.Margin = new System.Windows.Forms.Padding(4);
            this.informationsAboutEmployeesButton.Name = "informationsAboutEmployeesButton";
            this.informationsAboutEmployeesButton.Size = new System.Drawing.Size(211, 81);
            this.informationsAboutEmployeesButton.TabIndex = 3;
            this.informationsAboutEmployeesButton.Text = "Podaci o zaposlenima";
            this.informationsAboutEmployeesButton.UseVisualStyleBackColor = true;
            this.informationsAboutEmployeesButton.Click += new System.EventHandler(this.informationsAboutEmployeesButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.uplateToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(747, 28);
            this.menuStrip.TabIndex = 5;
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.createToolStripMenuItem.Text = "Administrator";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(208, 26);
            this.toolStripMenuItem1.Text = "Novi administrator";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(208, 26);
            this.toolStripMenuItem2.Text = "Novi korisnik";
            // 
            // uplateToolStripMenuItem
            // 
            this.uplateToolStripMenuItem.Name = "uplateToolStripMenuItem";
            this.uplateToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.uplateToolStripMenuItem.Text = "Uplate";
            this.uplateToolStripMenuItem.Click += new System.EventHandler(this.uplateToolStripMenuItem_Click);
            // 
            // administratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(747, 393);
            this.Controls.Add(this.informationsAboutEmployeesButton);
            this.Controls.Add(this.informationsAboutStudentsButton);
            this.Controls.Add(this.schoolSubjectbutton);
            this.Controls.Add(this.schoolTimetableButton);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "administratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button schoolTimetableButton;
        private System.Windows.Forms.Button schoolSubjectbutton;
        private System.Windows.Forms.Button informationsAboutStudentsButton;
        private System.Windows.Forms.Button informationsAboutEmployeesButton;

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem uplateToolStripMenuItem;
    }
}