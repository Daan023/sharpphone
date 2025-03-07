namespace Sharphone
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listPhones = new ListBox();
            BtnAddPhone = new Button();
            btnModify = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Voorraad";
            // 
            // listPhones
            // 
            listPhones.FormattingEnabled = true;
            listPhones.ItemHeight = 15;
            listPhones.Location = new Point(11, 23);
            listPhones.Margin = new Padding(2, 1, 2, 1);
            listPhones.Name = "listPhones";
            listPhones.Size = new Size(176, 184);
            listPhones.TabIndex = 1;
            // 
            // BtnAddPhone
            // 
            BtnAddPhone.Location = new Point(212, 23);
            BtnAddPhone.Margin = new Padding(2, 1, 2, 1);
            BtnAddPhone.Name = "BtnAddPhone";
            BtnAddPhone.Size = new Size(83, 22);
            BtnAddPhone.TabIndex = 2;
            BtnAddPhone.Text = "+";
            BtnAddPhone.UseVisualStyleBackColor = true;
            BtnAddPhone.Click += Btnaddphone_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(212, 58);
            btnModify.Margin = new Padding(2, 1, 2, 1);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(81, 22);
            btnModify.TabIndex = 3;
            btnModify.Text = "Aanpassen";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 211);
            Controls.Add(btnModify);
            Controls.Add(BtnAddPhone);
            Controls.Add(listPhones);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listPhones;
        private Button BtnAddPhone;
        private Button btnModify;
    }
}