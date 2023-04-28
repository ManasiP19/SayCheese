namespace FinalProj
{
    partial class PromotionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.PromotionLabel = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROMO";
            // 
            // PromotionLabel
            // 
            this.PromotionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PromotionLabel.Location = new System.Drawing.Point(106, 32);
            this.PromotionLabel.Name = "PromotionLabel";
            this.PromotionLabel.Size = new System.Drawing.Size(649, 120);
            this.PromotionLabel.TabIndex = 1;
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Location = new System.Drawing.Point(9, 7);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(50, 20);
            this.Customer.TabIndex = 2;
            this.Customer.Text = "label2";
            // 
            // PromotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.PromotionLabel);
            this.Controls.Add(this.label1);
            this.Name = "PromotionForm";
            this.Text = "PromotionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label PromotionLabel;
        private Label Customer;
    }
}