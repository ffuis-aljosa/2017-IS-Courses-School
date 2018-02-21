namespace Courses_School
{
    partial class classroom1Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(classroom1Form));
            this.tuesdayLabel1 = new System.Windows.Forms.Label();
            this.tuesdayTextBox1 = new System.Windows.Forms.TextBox();
            this.mondayLabel1 = new System.Windows.Forms.Label();
            this.mondayTextBox1 = new System.Windows.Forms.TextBox();
            this.timeLabel1 = new System.Windows.Forms.Label();
            this.timeTextBox1 = new System.Windows.Forms.TextBox();
            this.deleteButton1 = new System.Windows.Forms.Button();
            this.addButton1 = new System.Windows.Forms.Button();
            this.fridayLabel1 = new System.Windows.Forms.Label();
            this.thursdayLabel1 = new System.Windows.Forms.Label();
            this.wednesdayLabel1 = new System.Windows.Forms.Label();
            this.thursdayTextBox1 = new System.Windows.Forms.TextBox();
            this.fridayTextBox1 = new System.Windows.Forms.TextBox();
            this.wednesdayTextBox1 = new System.Windows.Forms.TextBox();
            this.schoolTimetableListView1 = new System.Windows.Forms.ListView();
            this.TimeDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Monday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tuesday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wednesday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Thursday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Friday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.changeButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tuesdayLabel1
            // 
            this.tuesdayLabel1.AutoSize = true;
            this.tuesdayLabel1.Location = new System.Drawing.Point(251, 222);
            this.tuesdayLabel1.Name = "tuesdayLabel1";
            this.tuesdayLabel1.Size = new System.Drawing.Size(27, 13);
            this.tuesdayLabel1.TabIndex = 35;
            this.tuesdayLabel1.Text = "Uto:";
            // 
            // tuesdayTextBox1
            // 
            this.tuesdayTextBox1.Location = new System.Drawing.Point(254, 238);
            this.tuesdayTextBox1.Name = "tuesdayTextBox1";
            this.tuesdayTextBox1.Size = new System.Drawing.Size(100, 20);
            this.tuesdayTextBox1.TabIndex = 34;
            // 
            // mondayLabel1
            // 
            this.mondayLabel1.AutoSize = true;
            this.mondayLabel1.Location = new System.Drawing.Point(126, 222);
            this.mondayLabel1.Name = "mondayLabel1";
            this.mondayLabel1.Size = new System.Drawing.Size(29, 13);
            this.mondayLabel1.TabIndex = 33;
            this.mondayLabel1.Text = "Pon:";
            // 
            // mondayTextBox1
            // 
            this.mondayTextBox1.Location = new System.Drawing.Point(129, 238);
            this.mondayTextBox1.Name = "mondayTextBox1";
            this.mondayTextBox1.Size = new System.Drawing.Size(100, 20);
            this.mondayTextBox1.TabIndex = 32;
            // 
            // timeLabel1
            // 
            this.timeLabel1.AutoSize = true;
            this.timeLabel1.Location = new System.Drawing.Point(6, 222);
            this.timeLabel1.Name = "timeLabel1";
            this.timeLabel1.Size = new System.Drawing.Size(44, 13);
            this.timeLabel1.TabIndex = 31;
            this.timeLabel1.Text = "Vrijeme:";
            // 
            // timeTextBox1
            // 
            this.timeTextBox1.Location = new System.Drawing.Point(9, 238);
            this.timeTextBox1.Name = "timeTextBox1";
            this.timeTextBox1.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox1.TabIndex = 30;
            // 
            // deleteButton1
            // 
            this.deleteButton1.Location = new System.Drawing.Point(769, 199);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(100, 23);
            this.deleteButton1.TabIndex = 29;
            this.deleteButton1.Text = "Obriši";
            this.deleteButton1.UseVisualStyleBackColor = true;
            this.deleteButton1.Click += new System.EventHandler(this.deleteButton1_Click);
            // 
            // addButton1
            // 
            this.addButton1.Location = new System.Drawing.Point(769, 238);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(100, 23);
            this.addButton1.TabIndex = 28;
            this.addButton1.Text = "Dodaj";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // fridayLabel1
            // 
            this.fridayLabel1.AutoSize = true;
            this.fridayLabel1.Location = new System.Drawing.Point(635, 222);
            this.fridayLabel1.Name = "fridayLabel1";
            this.fridayLabel1.Size = new System.Drawing.Size(26, 13);
            this.fridayLabel1.TabIndex = 27;
            this.fridayLabel1.Text = "Pet:";
            // 
            // thursdayLabel1
            // 
            this.thursdayLabel1.AutoSize = true;
            this.thursdayLabel1.Location = new System.Drawing.Point(509, 222);
            this.thursdayLabel1.Name = "thursdayLabel1";
            this.thursdayLabel1.Size = new System.Drawing.Size(26, 13);
            this.thursdayLabel1.TabIndex = 26;
            this.thursdayLabel1.Text = "Čet:";
            // 
            // wednesdayLabel1
            // 
            this.wednesdayLabel1.AutoSize = true;
            this.wednesdayLabel1.Location = new System.Drawing.Point(380, 222);
            this.wednesdayLabel1.Name = "wednesdayLabel1";
            this.wednesdayLabel1.Size = new System.Drawing.Size(22, 13);
            this.wednesdayLabel1.TabIndex = 25;
            this.wednesdayLabel1.Text = "Sri:";
            // 
            // thursdayTextBox1
            // 
            this.thursdayTextBox1.Location = new System.Drawing.Point(512, 238);
            this.thursdayTextBox1.Name = "thursdayTextBox1";
            this.thursdayTextBox1.Size = new System.Drawing.Size(100, 20);
            this.thursdayTextBox1.TabIndex = 24;
            // 
            // fridayTextBox1
            // 
            this.fridayTextBox1.Location = new System.Drawing.Point(638, 238);
            this.fridayTextBox1.Name = "fridayTextBox1";
            this.fridayTextBox1.Size = new System.Drawing.Size(100, 20);
            this.fridayTextBox1.TabIndex = 23;
            // 
            // wednesdayTextBox1
            // 
            this.wednesdayTextBox1.Location = new System.Drawing.Point(383, 238);
            this.wednesdayTextBox1.Name = "wednesdayTextBox1";
            this.wednesdayTextBox1.Size = new System.Drawing.Size(100, 20);
            this.wednesdayTextBox1.TabIndex = 22;
            // 
            // schoolTimetableListView1
            // 
            this.schoolTimetableListView1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.schoolTimetableListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TimeDay,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday});
            this.schoolTimetableListView1.FullRowSelect = true;
            this.schoolTimetableListView1.GridLines = true;
            this.schoolTimetableListView1.Location = new System.Drawing.Point(83, 35);
            this.schoolTimetableListView1.Name = "schoolTimetableListView1";
            this.schoolTimetableListView1.Size = new System.Drawing.Size(675, 148);
            this.schoolTimetableListView1.TabIndex = 21;
            this.schoolTimetableListView1.UseCompatibleStateImageBehavior = false;
            this.schoolTimetableListView1.View = System.Windows.Forms.View.Details;
            this.schoolTimetableListView1.SelectedIndexChanged += new System.EventHandler(this.schoolTimetableListView1_SelectedIndexChanged);
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
            // changeButton1
            // 
            this.changeButton1.Location = new System.Drawing.Point(769, 279);
            this.changeButton1.Name = "changeButton1";
            this.changeButton1.Size = new System.Drawing.Size(100, 23);
            this.changeButton1.TabIndex = 36;
            this.changeButton1.Text = "Izmijeni";
            this.changeButton1.UseVisualStyleBackColor = true;
            this.changeButton1.Click += new System.EventHandler(this.changeButton1_Click);
            // 
            // classroom1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(883, 308);
            this.Controls.Add(this.changeButton1);
            this.Controls.Add(this.tuesdayLabel1);
            this.Controls.Add(this.tuesdayTextBox1);
            this.Controls.Add(this.mondayLabel1);
            this.Controls.Add(this.mondayTextBox1);
            this.Controls.Add(this.timeLabel1);
            this.Controls.Add(this.timeTextBox1);
            this.Controls.Add(this.deleteButton1);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.fridayLabel1);
            this.Controls.Add(this.thursdayLabel1);
            this.Controls.Add(this.wednesdayLabel1);
            this.Controls.Add(this.thursdayTextBox1);
            this.Controls.Add(this.fridayTextBox1);
            this.Controls.Add(this.wednesdayTextBox1);
            this.Controls.Add(this.schoolTimetableListView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "classroom1Form";
            this.Text = "Učionica br. 1";
            this.Load += new System.EventHandler(this.classroom1Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tuesdayLabel1;
        private System.Windows.Forms.TextBox tuesdayTextBox1;
        private System.Windows.Forms.Label mondayLabel1;
        private System.Windows.Forms.TextBox mondayTextBox1;
        private System.Windows.Forms.Label timeLabel1;
        private System.Windows.Forms.TextBox timeTextBox1;
        private System.Windows.Forms.Button deleteButton1;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Label fridayLabel1;
        private System.Windows.Forms.Label thursdayLabel1;
        private System.Windows.Forms.Label wednesdayLabel1;
        private System.Windows.Forms.TextBox thursdayTextBox1;
        private System.Windows.Forms.TextBox fridayTextBox1;
        private System.Windows.Forms.TextBox wednesdayTextBox1;
        private System.Windows.Forms.ListView schoolTimetableListView1;
        private System.Windows.Forms.ColumnHeader TimeDay;
        private System.Windows.Forms.ColumnHeader Monday;
        private System.Windows.Forms.ColumnHeader Tuesday;
        private System.Windows.Forms.ColumnHeader Wednesday;
        private System.Windows.Forms.ColumnHeader Thursday;
        private System.Windows.Forms.ColumnHeader Friday;
        private System.Windows.Forms.Button changeButton1;
    }
}