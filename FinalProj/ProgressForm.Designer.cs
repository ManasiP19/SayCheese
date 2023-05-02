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
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Title = new System.Windows.Forms.Label();
            this.ReceivedLabel = new System.Windows.Forms.Label();
            this.PreparingLabel = new System.Windows.Forms.Label();
            this.CompletedLabel = new System.Windows.Forms.Label();
            this.OrderReadyLabel = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.Label();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(26, 131);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(751, 78);
            this.ProgressBar.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Corbel", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(26, 47);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(328, 58);
            this.Title.TabIndex = 1;
            this.Title.Text = "Order Progress";
            // 
            // ReceivedLabel
            // 
            this.ReceivedLabel.AutoSize = true;
            this.ReceivedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReceivedLabel.Location = new System.Drawing.Point(26, 229);
            this.ReceivedLabel.Name = "ReceivedLabel";
            this.ReceivedLabel.Size = new System.Drawing.Size(145, 28);
            this.ReceivedLabel.TabIndex = 2;
            this.ReceivedLabel.Text = "Order Recieved";
            // 
            // PreparingLabel
            // 
            this.PreparingLabel.AutoSize = true;
            this.PreparingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreparingLabel.Location = new System.Drawing.Point(282, 229);
            this.PreparingLabel.Name = "PreparingLabel";
            this.PreparingLabel.Size = new System.Drawing.Size(219, 28);
            this.PreparingLabel.TabIndex = 3;
            this.PreparingLabel.Text = "Order Is Being Prepared";
            // 
            // CompletedLabel
            // 
            this.CompletedLabel.AutoSize = true;
            this.CompletedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompletedLabel.Location = new System.Drawing.Point(606, 229);
            this.CompletedLabel.Name = "CompletedLabel";
            this.CompletedLabel.Size = new System.Drawing.Size(171, 28);
            this.CompletedLabel.TabIndex = 4;
            this.CompletedLabel.Text = "Order Is Complete";
            // 
            // OrderReadyLabel
            // 
            this.OrderReadyLabel.AutoSize = true;
            this.OrderReadyLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderReadyLabel.Location = new System.Drawing.Point(227, 145);
            this.OrderReadyLabel.Name = "OrderReadyLabel";
            this.OrderReadyLabel.Size = new System.Drawing.Size(313, 45);
            this.OrderReadyLabel.TabIndex = 6;
            this.OrderReadyLabel.Text = "Your Order is Ready!";
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Location = new System.Drawing.Point(14, 13);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(50, 20);
            this.Customer.TabIndex = 7;
            this.Customer.Text = "label1";
            // 
            // OrderLabel
            // 
            this.OrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderLabel.Location = new System.Drawing.Point(348, 229);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(76, 31);
            this.OrderLabel.TabIndex = 8;
            this.OrderLabel.Text = "label1";
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.OrderLabel);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.OrderReadyLabel);
            this.Controls.Add(this.CompletedLabel);
            this.Controls.Add(this.PreparingLabel);
            this.Controls.Add(this.ReceivedLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ProgressBar);
            this.Name = "ProgressForm";
            this.Text = "ProgessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ProgressBar ProgressBar;
        private Label Title;
        public Label ReceivedLabel;
        public Label PreparingLabel;
        public Label CompletedLabel;
        private Label label5;
        public Label label6;
        public Label OrderReadyLabel;
        public Label Customer;
        public Label OrderLabel;
    }
}
