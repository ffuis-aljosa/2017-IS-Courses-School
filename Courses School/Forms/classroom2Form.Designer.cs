namespace Courses_School
{
    partial class classroom2Form
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
            this.schoolTimetableListView = new System.Windows.Forms.ListView();
            this.TimeDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Monday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tuesday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wednesday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Thursday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Friday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wednesdayTextBox = new System.Windows.Forms.TextBox();
            this.fridayTextBox = new System.Windows.Forms.TextBox();
            this.thursdayTextBox = new System.Windows.Forms.TextBox();
            this.wdenesdayLabel = new System.Windows.Forms.Label();
            this.thursdayLabel = new System.Windows.Forms.Label();
            this.fridayLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.mondayLabel = new System.Windows.Forms.Label();
            this.mondayTextBox = new System.Windows.Forms.TextBox();
            this.tuesdayTextBox = new System.Windows.Forms.TextBox();
            this.tuesdayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // schoolTimetableListView
            // 
            this.schoolTimetableListView.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.schoolTimetableListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TimeDay,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday});
            this.schoolTimetableListView.FullRowSelect = true;
            this.schoolTimetableListView.GridLines = true;
            this.schoolTimetableListView.Location = new System.Drawing.Point(97, 33);
            this.schoolTimetableListView.Name = "schoolTimetableListView";
            this.schoolTimetableListView.Size = new System.Drawing.Size(675, 148);
            this.schoolTimetableListView.TabIndex = 0;
            this.schoolTimetableListView.UseCompatibleStateImageBehavior = false;
            this.schoolTimetableListView.View = System.Windows.Forms.View.Details;
            this.schoolTimetableListView.SelectedIndexChanged += new System.EventHandler(this.schoolTimetableListView_SelectedIndexChanged);
            // 
            // TimeDay
            // 
            this.TimeDay.Text = "Vrijeme \\ Dan";
            this.TimeDay.Width = 122;
            // 
            // Monday
            // 
            this.Monday.Text = "Ponedjeljak";
            this.Monday.Width = 116;
            // 
            // Tuesday
            // 
            this.Tuesday.Text = "Utorak";
            this.Tuesday.Width = 101;
            // 
            // Wednesday
            // 
            this.Wednesday.Text = "Srijeda";
            this.Wednesday.Width = 115;
            // 
            // Thursday
            // 
            this.Thursday.Text = "Četvrtak";
            this.Thursday.Width = 108;
            // 
            // Friday
            // 
            this.Friday.Text = "Petak";
            this.Friday.Width = 108;
            // 
            // wednesdayTextBox
            // 
            this.wednesdayTextBox.Location = new System.Drawing.Point(405, 210);
            this.wednesdayTextBox.Name = "wednesdayTextBox";
            this.wednesdayTextBox.Size = new System.Drawing.Size(100, 20);
            this.wednesdayTextBox.TabIndex = 4;
            // 
            // fridayTextBox
            // 
            this.fridayTextBox.Location = new System.Drawing.Point(660, 210);
            this.fridayTextBox.Name = "fridayTextBox";
            this.fridayTextBox.Size = new System.Drawing.Size(100, 20);
            this.fridayTextBox.TabIndex = 5;
            // 
            // thursdayTextBox
            // 
            this.thursdayTextBox.Location = new System.Drawing.Point(534, 210);
            this.thursdayTextBox.Name = "thursdayTextBox";
            this.thursdayTextBox.Size = new System.Drawing.Size(100, 20);
            this.thursdayTextBox.TabIndex = 6;
            // 
            // wdenesdayLabel
            // 
            this.wdenesdayLabel.AutoSize = true;
            this.wdenesdayLabel.Location = new System.Drawing.Point(402, 194);
            this.wdenesdayLabel.Name = "wdenesdayLabel";
            this.wdenesdayLabel.Size = new System.Drawing.Size(22, 13);
            this.wdenesdayLabel.TabIndex = 10;
            this.wdenesdayLabel.Text = "Sri:";
            // 
            // thursdayLabel
            // 
            this.thursdayLabel.AutoSize = true;
            this.thursdayLabel.Location = new System.Drawing.Point(531, 194);
            this.thursdayLabel.Name = "thursdayLabel";
            this.thursdayLabel.Size = new System.Drawing.Size(26, 13);
            this.thursdayLabel.TabIndex = 11;
            this.thursdayLabel.Text = "Čet:";
            // 
            // fridayLabel
            // 
            this.fridayLabel.AutoSize = true;
            this.fridayLabel.Location = new System.Drawing.Point(657, 194);
            this.fridayLabel.Name = "fridayLabel";
            this.fridayLabel.Size = new System.Drawing.Size(26, 13);
            this.fridayLabel.TabIndex = 12;
            this.fridayLabel.Text = "Pet:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(783, 207);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 23);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(783, 248);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 23);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Obriši";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(28, 194);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(44, 13);
            this.timeLabel.TabIndex = 16;
            this.timeLabel.Text = "Vrijeme:";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(31, 210);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox.TabIndex = 15;
            // 
            // mondayLabel
            // 
            this.mondayLabel.AutoSize = true;
            this.mondayLabel.Location = new System.Drawing.Point(148, 194);
            this.mondayLabel.Name = "mondayLabel";
            this.mondayLabel.Size = new System.Drawing.Size(29, 13);
            this.mondayLabel.TabIndex = 18;
            this.mondayLabel.Text = "Pon:";
            // 
            // mondayTextBox
            // 
            this.mondayTextBox.Location = new System.Drawing.Point(151, 210);
            this.mondayTextBox.Name = "mondayTextBox";
            this.mondayTextBox.Size = new System.Drawing.Size(100, 20);
            this.mondayTextBox.TabIndex = 17;
            // 
            // tuesdayTextBox
            // 
            this.tuesdayTextBox.Location = new System.Drawing.Point(276, 210);
            this.tuesdayTextBox.Name = "tuesdayTextBox";
            this.tuesdayTextBox.Size = new System.Drawing.Size(100, 20);
            this.tuesdayTextBox.TabIndex = 19;
            // 
            // tuesdayLabel
            // 
            this.tuesdayLabel.AutoSize = true;
            this.tuesdayLabel.Location = new System.Drawing.Point(273, 194);
            this.tuesdayLabel.Name = "tuesdayLabel";
            this.tuesdayLabel.Size = new System.Drawing.Size(27, 13);
            this.tuesdayLabel.TabIndex = 20;
            this.tuesdayLabel.Text = "Uto:";
            // 
            // classroom2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(892, 300);
            this.Controls.Add(this.tuesdayLabel);
            this.Controls.Add(this.tuesdayTextBox);
            this.Controls.Add(this.mondayLabel);
            this.Controls.Add(this.mondayTextBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.fridayLabel);
            this.Controls.Add(this.thursdayLabel);
            this.Controls.Add(this.wdenesdayLabel);
            this.Controls.Add(this.thursdayTextBox);
            this.Controls.Add(this.fridayTextBox);
            this.Controls.Add(this.wednesdayTextBox);
            this.Controls.Add(this.schoolTimetableListView);
            this.Name = "classroom2Form";
            this.Text = "Učionica br.2";
            this.Load += new System.EventHandler(this.classroom2Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView schoolTimetableListView;
        private System.Windows.Forms.ColumnHeader TimeDay;
        private System.Windows.Forms.ColumnHeader Monday;
        private System.Windows.Forms.ColumnHeader Tuesday;
        private System.Windows.Forms.ColumnHeader Wednesday;
        private System.Windows.Forms.ColumnHeader Thursday;
        private System.Windows.Forms.ColumnHeader Friday;
        private System.Windows.Forms.TextBox wednesdayTextBox;
        private System.Windows.Forms.TextBox fridayTextBox;
        private System.Windows.Forms.TextBox thursdayTextBox;
        private System.Windows.Forms.Label wdenesdayLabel;
        private System.Windows.Forms.Label thursdayLabel;
        private System.Windows.Forms.Label fridayLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label mondayLabel;
        private System.Windows.Forms.TextBox mondayTextBox;
        private System.Windows.Forms.TextBox tuesdayTextBox;
        private System.Windows.Forms.Label tuesdayLabel;
    }
}