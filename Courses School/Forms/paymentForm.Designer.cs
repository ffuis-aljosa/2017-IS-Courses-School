﻿namespace Courses_School
{
    partial class paymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentForm));
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.addPaymentButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paymentListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(11, 64);
            this.StudentComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(184, 24);
            this.StudentComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime i prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iznos uplate (KM)";
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Location = new System.Drawing.Point(11, 162);
            this.paymentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(184, 22);
            this.paymentTextBox.TabIndex = 3;
            // 
            // addPaymentButton
            // 
            this.addPaymentButton.Location = new System.Drawing.Point(11, 297);
            this.addPaymentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPaymentButton.Name = "addPaymentButton";
            this.addPaymentButton.Size = new System.Drawing.Size(184, 32);
            this.addPaymentButton.TabIndex = 5;
            this.addPaymentButton.Text = "Dodaj!";
            this.addPaymentButton.UseVisualStyleBackColor = true;
            this.addPaymentButton.Click += new System.EventHandler(this.addPaymentButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(11, 235);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker.TabIndex = 7;
            // 
            // paymentListView
            // 
            this.paymentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.paymentListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.paymentListView.GridLines = true;
            this.paymentListView.Location = new System.Drawing.Point(267, 76);
            this.paymentListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentListView.Name = "paymentListView";
            this.paymentListView.Size = new System.Drawing.Size(398, 299);
            this.paymentListView.TabIndex = 8;
            this.paymentListView.UseCompatibleStateImageBehavior = false;
            this.paymentListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Br.";
            this.columnHeader1.Width = 31;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Iznos";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Datum";
            this.columnHeader5.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(239, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Pretraga:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(339, 20);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(183, 22);
            this.searchTextBox.TabIndex = 28;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // paymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(805, 428);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.paymentListView);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.addPaymentButton);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "paymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uplate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.Button addPaymentButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListView paymentListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}