﻿namespace Courses_School
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
            this.examsListView = new System.Windows.Forms.ListView();
            this.schoolSubjectColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.schoolSubjectComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // schoolSubjectLabel
            // 
            this.schoolSubjectLabel.AutoSize = true;
            this.schoolSubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.schoolSubjectLabel.Location = new System.Drawing.Point(54, 88);
            this.schoolSubjectLabel.Name = "schoolSubjectLabel";
            this.schoolSubjectLabel.Size = new System.Drawing.Size(77, 20);
            this.schoolSubjectLabel.TabIndex = 0;
            this.schoolSubjectLabel.Text = "Predmet:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nameLabel.Location = new System.Drawing.Point(16, 130);
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
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(137, 215);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(234, 20);
            this.dateTextBox.TabIndex = 5;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(137, 173);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(234, 20);
            this.gradeTextBox.TabIndex = 6;
            // 
            // examsListView
            // 
            this.examsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.schoolSubjectColumnHeader,
            this.nameColumnHeader,
            this.gradeColumnHeader,
            this.dateColumnHeader});
            this.examsListView.GridLines = true;
            this.examsListView.Location = new System.Drawing.Point(426, 88);
            this.examsListView.Name = "examsListView";
            this.examsListView.Size = new System.Drawing.Size(462, 286);
            this.examsListView.TabIndex = 8;
            this.examsListView.UseCompatibleStateImageBehavior = false;
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
            // 
            // nameComboBox
            // 
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(137, 132);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(234, 21);
            this.nameComboBox.TabIndex = 11;
            // 
            // schoolSubjectComboBox
            // 
            this.schoolSubjectComboBox.FormattingEnabled = true;
            this.schoolSubjectComboBox.Location = new System.Drawing.Point(137, 87);
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
            // 
            // examsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 427);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.schoolSubjectComboBox);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.examsListView);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.schoolSubjectLabel);
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
        private System.Windows.Forms.ListView examsListView;
        private System.Windows.Forms.ColumnHeader schoolSubjectColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader gradeColumnHeader;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.ComboBox schoolSubjectComboBox;
        private System.Windows.Forms.Button addButton;
    }
}