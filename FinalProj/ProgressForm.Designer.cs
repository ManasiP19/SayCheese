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
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(26, 131);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(751, 78);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 47);
            label1.Name = "label1";
            label1.Size = new Size(328, 58);
            label1.TabIndex = 1;
            label1.Text = "Order Progress";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 229);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 2;
            label2.Text = "Order Recieved";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(282, 229);
            label3.Name = "label3";
            label3.Size = new Size(219, 28);
            label3.TabIndex = 3;
            label3.Text = "Order Is Being Prepared";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(606, 229);
            label4.Name = "label4";
            label4.Size = new Size(171, 28);
            label4.TabIndex = 4;
            label4.Text = "Order Is Complete";
            // 
            // ProgessForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 314);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Name = "ProgessForm";
            Text = "ProgessForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}