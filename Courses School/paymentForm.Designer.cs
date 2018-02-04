namespace Courses_School
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
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.addPaymentButton = new System.Windows.Forms.Button();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(11, 64);
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
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(184, 22);
            this.paymentTextBox.TabIndex = 3;
            // 
            // addPaymentButton
            // 
            this.addPaymentButton.Location = new System.Drawing.Point(11, 297);
            this.addPaymentButton.Name = "addPaymentButton";
            this.addPaymentButton.Size = new System.Drawing.Size(184, 32);
            this.addPaymentButton.TabIndex = 5;
            this.addPaymentButton.Text = "Dodaj!";
            this.addPaymentButton.UseVisualStyleBackColor = true;
            this.addPaymentButton.Click += new System.EventHandler(this.addPaymentButton_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(16, 228);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(199, 22);
            this.dataTextBox.TabIndex = 6;
            // 
            // paymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Courses_School.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(601, 403);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.addPaymentButton);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentComboBox);
            this.Name = "paymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.Button addPaymentButton;
        private System.Windows.Forms.TextBox dataTextBox;
    }
}