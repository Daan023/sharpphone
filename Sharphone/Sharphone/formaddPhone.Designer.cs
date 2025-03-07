namespace Sharphone
{
    partial class formaddPhone
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
            btnOk = new Button();
            txtBrand = new TextBox();
            txtModel = new TextBox();
            txtSize = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            label5 = new Label();
            txtStock = new TextBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(636, 390);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(150, 46);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(200, 12);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(200, 39);
            txtBrand.TabIndex = 1;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(199, 72);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(200, 39);
            txtModel.TabIndex = 2;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(199, 130);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(200, 39);
            txtSize.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(199, 189);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 39);
            txtPrice.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 19);
            label1.Name = "label1";
            label1.Size = new Size(69, 32);
            label1.TabIndex = 5;
            label1.Text = "Merk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 72);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 6;
            label2.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 189);
            label4.Name = "label4";
            label4.Size = new Size(57, 32);
            label4.TabIndex = 8;
            label4.Text = "Prijs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 130);
            label3.Name = "label3";
            label3.Size = new Size(57, 32);
            label3.TabIndex = 9;
            label3.Text = "Size";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(25, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 251);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 11;
            label5.Text = "Stock";
            label5.Click += label5_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(200, 244);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(200, 39);
            txtStock.TabIndex = 12;
            // 
            // formaddPhone
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(btnCancel);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtSize);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Controls.Add(btnOk);
            Name = "formaddPhone";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private TextBox txtBrand;
        private TextBox txtModel;
        private TextBox txtSize;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button btnCancel;
        private Label label5;
        private TextBox txtStock;
    }
}