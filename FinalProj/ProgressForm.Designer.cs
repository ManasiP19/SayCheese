namespace FinalProj
{
    partial class ProgressForm
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderReadyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 131);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(751, 78);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Progress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order Recieved";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(282, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order Is Being Prepared";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(606, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Order Is Complete";
            // 
            // OrderReadyLabel
            // 
            this.OrderReadyLabel.AutoSize = true;
            this.OrderReadyLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderReadyLabel.Location = new System.Drawing.Point(227, 145);
            this.OrderReadyLabel.Name = "OrderReadyLabel";
            this.OrderReadyLabel.Size = new System.Drawing.Size(324, 46);
            this.OrderReadyLabel.TabIndex = 6;
            this.OrderReadyLabel.Text = "Your Order is Ready!";
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.OrderReadyLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Name = "ProgressForm";
            this.Text = "ProgessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ProgressBar progressBar1;
        private Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        private Label label5;
        public Label label6;
        public Label OrderReadyLabel;
    }
}