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
            this.schoolSubjectLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.firstNameComboBox = new System.Windows.Forms.ComboBox();
            this.schoolSubjectComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.examsListView = new System.Windows.Forms.ListView();
            this.schoolSubjectolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // schoolSubjectLabel
            // 
            this.schoolSubjectLabel.AutoSize = true;
            this.schoolSubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.schoolSubjectLabel.Location = new System.Drawing.Point(72, 108);
            this.schoolSubjectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.schoolSubjectLabel.Name = "schoolSubjectLabel";
            this.schoolSubjectLabel.Size = new System.Drawing.Size(98, 25);
            this.schoolSubjectLabel.TabIndex = 0;
            this.schoolSubjectLabel.Text = "Predmet:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nameLabel.Location = new System.Drawing.Point(21, 160);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(145, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Ime i prezime:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gradeLabel.Location = new System.Drawing.Point(85, 213);
            this.gradeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(86, 25);
            this.gradeLabel.TabIndex = 2;
            this.gradeLabel.Text = "Ocjena:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dateLabel.Location = new System.Drawing.Point(89, 265);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(80, 25);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Datum:";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(183, 265);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(311, 22);
            this.dateTextBox.TabIndex = 5;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(183, 213);
            this.gradeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(311, 22);
            this.gradeTextBox.TabIndex = 6;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.searchLabel.Location = new System.Drawing.Point(659, 69);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(100, 25);
            this.searchLabel.TabIndex = 9;
            this.searchLabel.Text = "Pretraga:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(771, 71);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(311, 22);
            this.searchTextBox.TabIndex = 10;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // firstNameComboBox
            // 
            this.firstNameComboBox.FormattingEnabled = true;
            this.firstNameComboBox.Location = new System.Drawing.Point(183, 162);
            this.firstNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameComboBox.Name = "firstNameComboBox";
            this.firstNameComboBox.Size = new System.Drawing.Size(311, 24);
            this.firstNameComboBox.TabIndex = 11;
            // 
            // schoolSubjectComboBox
            // 
            this.schoolSubjectComboBox.FormattingEnabled = true;
            this.schoolSubjectComboBox.Location = new System.Drawing.Point(183, 107);
            this.schoolSubjectComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.schoolSubjectComboBox.Name = "schoolSubjectComboBox";
            this.schoolSubjectComboBox.Size = new System.Drawing.Size(311, 24);
            this.schoolSubjectComboBox.TabIndex = 12;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.addButton.Location = new System.Drawing.Point(331, 337);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(164, 62);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Dodaj !";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // examsListView
            // 
            this.examsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.schoolSubjectolumnHeader,
            this.nameColumnHeader,
            this.gradeColumnHeader,
            this.dateColumnHeader});
            this.examsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.examsListView.GridLines = true;
            this.examsListView.Location = new System.Drawing.Point(551, 107);
            this.examsListView.Margin = new System.Windows.Forms.Padding(4);
            this.examsListView.Name = "examsListView";
            this.examsListView.Size = new System.Drawing.Size(647, 376);
            this.examsListView.TabIndex = 23;
            this.examsListView.UseCompatibleStateImageBehavior = false;
            this.examsListView.View = System.Windows.Forms.View.Details;
            this.examsListView.SelectedIndexChanged += new System.EventHandler(this.examsListView_SelectedIndexChanged);
            // 
            // schoolSubjectolumnHeader
            // 
            this.schoolSubjectolumnHeader.Text = "Predmet:";
            this.schoolSubjectolumnHeader.Width = 131;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Ime i prezime:";
            this.nameColumnHeader.Width = 142;
            // 
            // gradeColumnHeader
            // 
            this.gradeColumnHeader.Text = "Ocjena:";
            this.gradeColumnHeader.Width = 93;
            // 
            // dateColumnHeader
            // 
            this.dateColumnHeader.Text = "Datum:";
            this.dateColumnHeader.Width = 116;
            // 
            // examsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 526);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.examsListView);
            this.Controls.Add(this.schoolSubjectComboBox);
            this.Controls.Add(this.firstNameComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.schoolSubjectLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "examsForm";
            this.Text = "examsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label schoolSubjectLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox firstNameComboBox;
        private System.Windows.Forms.ComboBox schoolSubjectComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView examsListView;
        private System.Windows.Forms.ColumnHeader schoolSubjectolumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader gradeColumnHeader;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
    }
}