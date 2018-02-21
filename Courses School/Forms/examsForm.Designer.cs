namespace Courses_School
{
    partial class examsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(examsForm));
            this.schoolSubjectLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.firstNameComboBox = new System.Windows.Forms.ComboBox();
            this.schoolSubjectComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.examsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // schoolSubjectLabel
            // 
            this.schoolSubjectLabel.AutoSize = true;
            this.schoolSubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.schoolSubjectLabel.Location = new System.Drawing.Point(54, 133);
            this.schoolSubjectLabel.Name = "schoolSubjectLabel";
            this.schoolSubjectLabel.Size = new System.Drawing.Size(77, 20);
            this.schoolSubjectLabel.TabIndex = 0;
            this.schoolSubjectLabel.Text = "Predmet:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nameLabel.Location = new System.Drawing.Point(12, 87);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(115, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Ime i prezime:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gradeLabel.Location = new System.Drawing.Point(64, 173);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(67, 20);
            this.gradeLabel.TabIndex = 2;
            this.gradeLabel.Text = "Ocjena:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dateLabel.Location = new System.Drawing.Point(67, 215);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(64, 20);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Datum:";
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(137, 173);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(234, 20);
            this.gradeTextBox.TabIndex = 6;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.searchLabel.Location = new System.Drawing.Point(494, 56);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(78, 20);
            this.searchLabel.TabIndex = 9;
            this.searchLabel.Text = "Pretraga:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(578, 58);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(234, 20);
            this.searchTextBox.TabIndex = 10;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // firstNameComboBox
            // 
            this.firstNameComboBox.FormattingEnabled = true;
            this.firstNameComboBox.Location = new System.Drawing.Point(137, 89);
            this.firstNameComboBox.Name = "firstNameComboBox";
            this.firstNameComboBox.Size = new System.Drawing.Size(234, 21);
            this.firstNameComboBox.TabIndex = 11;
            this.firstNameComboBox.SelectedIndexChanged += new System.EventHandler(this.firstNameComboBox_SelectedIndexChanged);
            // 
            // schoolSubjectComboBox
            // 
            this.schoolSubjectComboBox.FormattingEnabled = true;
            this.schoolSubjectComboBox.Location = new System.Drawing.Point(137, 135);
            this.schoolSubjectComboBox.Name = "schoolSubjectComboBox";
            this.schoolSubjectComboBox.Size = new System.Drawing.Size(234, 21);
            this.schoolSubjectComboBox.TabIndex = 12;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.addButton.Location = new System.Drawing.Point(248, 274);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 50);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Dodaj !";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // examsListView
            // 
            this.examsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.examsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.examsListView.GridLines = true;
            this.examsListView.Location = new System.Drawing.Point(413, 87);
            this.examsListView.Name = "examsListView";
            this.examsListView.Size = new System.Drawing.Size(486, 306);
            this.examsListView.TabIndex = 23;
            this.examsListView.UseCompatibleStateImageBehavior = false;
            this.examsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Br";
            this.columnHeader1.Width = 32;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Predmet";
            this.columnHeader4.Width = 127;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ocjena";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Datum";
            this.columnHeader6.Width = 84;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(136, 215);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(235, 20);
            this.dateTimePicker.TabIndex = 25;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.deleteButton.Location = new System.Drawing.Point(248, 343);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(123, 50);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Obriši !";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // examsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 427);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.examsListView);
            this.Controls.Add(this.schoolSubjectComboBox);
            this.Controls.Add(this.firstNameComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.schoolSubjectLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "examsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ispiti";
            this.Load += new System.EventHandler(this.examsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label schoolSubjectLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox firstNameComboBox;
        private System.Windows.Forms.ComboBox schoolSubjectComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView examsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button deleteButton;
    }
}