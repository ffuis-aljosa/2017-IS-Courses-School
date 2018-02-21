namespace Courses_School
{
    partial class schoolTimetableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schoolTimetableForm));
            this.classroom1Button = new System.Windows.Forms.Button();
            this.classroom2Botton = new System.Windows.Forms.Button();
            this.classroom3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classroom1Button
            // 
            this.classroom1Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.classroom1Button.Location = new System.Drawing.Point(74, 51);
            this.classroom1Button.Name = "classroom1Button";
            this.classroom1Button.Size = new System.Drawing.Size(387, 37);
            this.classroom1Button.TabIndex = 0;
            this.classroom1Button.Text = "Učionica br.1";
            this.classroom1Button.UseVisualStyleBackColor = false;
            this.classroom1Button.Click += new System.EventHandler(this.classroom1Button_Click);
            // 
            // classroom2Botton
            // 
            this.classroom2Botton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.classroom2Botton.Location = new System.Drawing.Point(74, 130);
            this.classroom2Botton.Name = "classroom2Botton";
            this.classroom2Botton.Size = new System.Drawing.Size(387, 36);
            this.classroom2Botton.TabIndex = 1;
            this.classroom2Botton.Text = "Učionica br.2";
            this.classroom2Botton.UseVisualStyleBackColor = false;
            this.classroom2Botton.Click += new System.EventHandler(this.classroom2Botton_Click);
            // 
            // classroom3Button
            // 
            this.classroom3Button.Location = new System.Drawing.Point(74, 211);
            this.classroom3Button.Name = "classroom3Button";
            this.classroom3Button.Size = new System.Drawing.Size(387, 34);
            this.classroom3Button.TabIndex = 2;
            this.classroom3Button.Text = "Učionica br.3";
            this.classroom3Button.UseVisualStyleBackColor = true;
            this.classroom3Button.Click += new System.EventHandler(this.classroom3Button_Click);
            // 
            // schoolTimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(560, 319);
            this.Controls.Add(this.classroom3Button);
            this.Controls.Add(this.classroom2Botton);
            this.Controls.Add(this.classroom1Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "schoolTimetableForm";
            this.Text = "Raspored ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button classroom1Button;
        private System.Windows.Forms.Button classroom2Botton;
        private System.Windows.Forms.Button classroom3Button;
    }
}