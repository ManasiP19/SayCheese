namespace FinalProj
{
    public partial class OrderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            listBox3 = new ListBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            listBox4 = new ListBox();
            label4 = new Label();
            listBox5 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            listBox2 = new ListBox();
            label2 = new Label();
            listBox6 = new ListBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(39, 60);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(236, 229);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
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
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(560, 60);
            listBox3.Margin = new Padding(4);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(236, 229);
            listBox3.TabIndex = 4;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(560, 31);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 5;
            label3.Text = "Sauce";
            label3.Click += label3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(630, 506);
            checkBox1.Margin = new Padding(4);
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
            button1.Margin = new Padding(4);
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
            listBox4.Size = new Size(462, 154);
            listBox4.TabIndex = 8;
            listBox4.SelectedIndexChanged += listBox4_SelectedIndexChanged;
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
            listBox5.Location = new Point(297, 60);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(236, 229);
            listBox5.TabIndex = 10;
            listBox5.SelectedIndexChanged += listBox5_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 31);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 11;
            label5.Text = "Add item";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-3, 6);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 12;
            label6.Text = "label6";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(815, 60);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(227, 229);
            listBox2.TabIndex = 13;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(817, 29);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 14;
            label2.Text = "Drinks";
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 25;
            listBox6.Location = new Point(1072, 59);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(207, 229);
            listBox6.TabIndex = 15;
            listBox6.SelectedIndexChanged += listBox6_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1073, 26);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 16;
            label7.Text = "Sides";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 602);
            Controls.Add(label7);
            Controls.Add(listBox6);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBox5);
            Controls.Add(label4);
            Controls.Add(listBox4);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(listBox3);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Margin = new Padding(4);
            Name = "OrderForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ListBox listBox1;
        public Label label1;
        public ListBox listBox3;
        public Label label3;
        public CheckBox checkBox1;
        public Button button1;
        public ListBox listBox4;
        public Label label4;
        public ListBox listBox5;
        public Label label5;
        public Label label6;
        private ListBox listBox2;
        private Label label2;
        private ListBox listBox6;
        private Label label7;
    }
}