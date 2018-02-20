namespace Courses_School
{
    partial class employeeForm
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
            this.examsButton = new System.Windows.Forms.Button();
            this.timeTableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // examsButton
            // 
            this.examsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.examsButton.Location = new System.Drawing.Point(263, 224);
            this.examsButton.Margin = new System.Windows.Forms.Padding(4);
            this.examsButton.Name = "examsButton";
            this.examsButton.Size = new System.Drawing.Size(247, 96);
            this.examsButton.TabIndex = 0;
            this.examsButton.Text = "Testovi";
            this.examsButton.UseVisualStyleBackColor = true;
            this.examsButton.Click += new System.EventHandler(this.examsButton_Click);
            // 
            // timeTableButton
            // 
            this.timeTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.timeTableButton.Location = new System.Drawing.Point(263, 71);
            this.timeTableButton.Margin = new System.Windows.Forms.Padding(4);
            this.timeTableButton.Name = "timeTableButton";
            this.timeTableButton.Size = new System.Drawing.Size(247, 96);
            this.timeTableButton.TabIndex = 1;
            this.timeTableButton.Text = "Raspored ";
            this.timeTableButton.UseVisualStyleBackColor = true;
            this.timeTableButton.Click += new System.EventHandler(this.timeTableButton_Click);
            // 
            // employeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 393);
            this.Controls.Add(this.timeTableButton);
            this.Controls.Add(this.examsButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "employeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button examsButton;
        private System.Windows.Forms.Button timeTableButton;
    }
}