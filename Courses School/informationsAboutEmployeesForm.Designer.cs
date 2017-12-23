namespace Courses_School
{
    partial class informationsAboutEmployeesForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addNewEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(536, 238);
            this.listBox1.TabIndex = 0;
            // 
            // addNewEmployeeButton
            // 
            this.addNewEmployeeButton.Location = new System.Drawing.Point(172, 265);
            this.addNewEmployeeButton.Name = "addNewEmployeeButton";
            this.addNewEmployeeButton.Size = new System.Drawing.Size(215, 42);
            this.addNewEmployeeButton.TabIndex = 1;
            this.addNewEmployeeButton.UseVisualStyleBackColor = true;
            this.addNewEmployeeButton.Click += new System.EventHandler(this.addNewEmployeeButton_Click);
            // 
            // informationsAboutEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(560, 319);
            this.Controls.Add(this.addNewEmployeeButton);
            this.Controls.Add(this.listBox1);
            this.Name = "informationsAboutEmployeesForm";
            this.Text = "informationsAboutEmployeesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addNewEmployeeButton;
    }
}