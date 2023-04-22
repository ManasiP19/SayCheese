namespace FinalProj
{
    partial class OrderForm
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
            listBox1 = new ListBox();
            label1 = new Label();
            listBox2 = new ListBox();
            label2 = new Label();
            listBox3 = new ListBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            listBox4 = new ListBox();
            label4 = new Label();
            listBox5 = new ListBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(39, 60);
            listBox1.Margin = new Padding(4, 4, 4, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(236, 229);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(500, 60);
            listBox2.Margin = new Padding(4, 4, 4, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(236, 229);
            listBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 3;
            label2.Text = "Add-On";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(773, 60);
            listBox3.Margin = new Padding(4, 4, 4, 4);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(236, 229);
            listBox3.TabIndex = 4;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(773, 31);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 5;
            label3.Text = "Sauce";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(630, 506);
            checkBox1.Margin = new Padding(4, 4, 4, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(227, 29);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Register for Promotions";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(630, 379);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(235, 70);
            button1.TabIndex = 7;
            button1.Text = "SUBMIT ORDER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 25;
            listBox4.Location = new Point(27, 406);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(180, 129);
            listBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 379);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 9;
            label4.Text = "Order";
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 25;
            listBox5.Location = new Point(296, 71);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(180, 204);
            listBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 36);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 11;
            label5.Text = "Add item";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 562);
            Controls.Add(label5);
            Controls.Add(listBox5);
            Controls.Add(label4);
            Controls.Add(listBox4);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(listBox3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "OrderForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private ListBox listBox2;
        private Label label2;
        private ListBox listBox3;
        private Label label3;
        private CheckBox checkBox1;
        private Button button1;
        private ListBox listBox4;
        private Label label4;
        private ListBox listBox5;
        private Label label5;
    }
}