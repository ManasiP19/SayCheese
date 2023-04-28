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
            this.MenuList = new System.Windows.Forms.ListBox();
            this.Menu = new System.Windows.Forms.Label();
            this.SauceList = new System.Windows.Forms.ListBox();
            this.Sauce = new System.Windows.Forms.Label();
            this.PromotionBox = new System.Windows.Forms.CheckBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.OrderList = new System.Windows.Forms.ListBox();
            this.Order = new System.Windows.Forms.Label();
            this.AddonList = new System.Windows.Forms.ListBox();
            this.AddItem = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.DrinksList = new System.Windows.Forms.ListBox();
            this.Drinks = new System.Windows.Forms.Label();
            this.SidesList = new System.Windows.Forms.ListBox();
            this.Sides = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MenuList
            // 
            this.MenuList.FormattingEnabled = true;
            this.MenuList.ItemHeight = 20;
            this.MenuList.Location = new System.Drawing.Point(31, 48);
            this.MenuList.Name = "MenuList";
            this.MenuList.Size = new System.Drawing.Size(190, 184);
            this.MenuList.TabIndex = 0;
            this.MenuList.SelectedIndexChanged += new System.EventHandler(this.MenuList_SelectedIndexChanged);
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Location = new System.Drawing.Point(31, 25);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(46, 20);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            // 
            // SauceList
            // 
            this.SauceList.FormattingEnabled = true;
            this.SauceList.ItemHeight = 20;
            this.SauceList.Location = new System.Drawing.Point(448, 48);
            this.SauceList.Name = "SauceList";
            this.SauceList.Size = new System.Drawing.Size(190, 184);
            this.SauceList.TabIndex = 4;
            this.SauceList.SelectedIndexChanged += new System.EventHandler(this.SauceList_SelectedIndexChanged);
            // 
            // Sauce
            // 
            this.Sauce.AutoSize = true;
            this.Sauce.Location = new System.Drawing.Point(448, 25);
            this.Sauce.Name = "Sauce";
            this.Sauce.Size = new System.Drawing.Size(48, 20);
            this.Sauce.TabIndex = 5;
            this.Sauce.Text = "Sauce";
            // 
            // PromotionBox
            // 
            this.PromotionBox.AutoSize = true;
            this.PromotionBox.Location = new System.Drawing.Point(504, 405);
            this.PromotionBox.Name = "PromotionBox";
            this.PromotionBox.Size = new System.Drawing.Size(188, 24);
            this.PromotionBox.TabIndex = 6;
            this.PromotionBox.Text = "Register for Promotions";
            this.PromotionBox.UseVisualStyleBackColor = true;
            this.PromotionBox.CheckedChanged += new System.EventHandler(this.PromotionBox_CheckedChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(504, 303);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(188, 56);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "SUBMIT ORDER";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // OrderList
            // 
            this.OrderList.FormattingEnabled = true;
            this.OrderList.ItemHeight = 20;
            this.OrderList.Location = new System.Drawing.Point(22, 325);
            this.OrderList.Margin = new System.Windows.Forms.Padding(2);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(370, 124);
            this.OrderList.TabIndex = 8;
            this.OrderList.SelectedIndexChanged += new System.EventHandler(this.OrderList_SelectedIndexChanged);
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Location = new System.Drawing.Point(26, 303);
            this.Order.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(47, 20);
            this.Order.TabIndex = 9;
            this.Order.Text = "Order";
            // 
            // AddonList
            // 
            this.AddonList.FormattingEnabled = true;
            this.AddonList.ItemHeight = 20;
            this.AddonList.Location = new System.Drawing.Point(238, 48);
            this.AddonList.Margin = new System.Windows.Forms.Padding(2);
            this.AddonList.Name = "AddonList";
            this.AddonList.Size = new System.Drawing.Size(190, 184);
            this.AddonList.TabIndex = 10;
            this.AddonList.SelectedIndexChanged += new System.EventHandler(this.AddonList_SelectedIndexChanged);
            // 
            // AddItem
            // 
            this.AddItem.AutoSize = true;
            this.AddItem.Location = new System.Drawing.Point(238, 25);
            this.AddItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(71, 20);
            this.AddItem.TabIndex = 11;
            this.AddItem.Text = "Add item";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(-2, 5);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(50, 20);
            this.CustomerName.TabIndex = 12;
            this.CustomerName.Text = "label6";
            // 
            // DrinksList
            // 
            this.DrinksList.FormattingEnabled = true;
            this.DrinksList.ItemHeight = 20;
            this.DrinksList.Location = new System.Drawing.Point(652, 48);
            this.DrinksList.Margin = new System.Windows.Forms.Padding(2);
            this.DrinksList.Name = "DrinksList";
            this.DrinksList.Size = new System.Drawing.Size(182, 184);
            this.DrinksList.TabIndex = 13;
            this.DrinksList.SelectedIndexChanged += new System.EventHandler(this.DrinksList_SelectedIndexChanged);
            // 
            // Drinks
            // 
            this.Drinks.AutoSize = true;
            this.Drinks.Location = new System.Drawing.Point(654, 23);
            this.Drinks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(50, 20);
            this.Drinks.TabIndex = 14;
            this.Drinks.Text = "Drinks";
            // 
            // SidesList
            // 
            this.SidesList.FormattingEnabled = true;
            this.SidesList.ItemHeight = 20;
            this.SidesList.Location = new System.Drawing.Point(858, 47);
            this.SidesList.Margin = new System.Windows.Forms.Padding(2);
            this.SidesList.Name = "SidesList";
            this.SidesList.Size = new System.Drawing.Size(166, 184);
            this.SidesList.TabIndex = 15;
            this.SidesList.SelectedIndexChanged += new System.EventHandler(this.SidesList_SelectedIndexChanged);
            // 
            // Sides
            // 
            this.Sides.AutoSize = true;
            this.Sides.Location = new System.Drawing.Point(858, 21);
            this.Sides.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sides.Name = "Sides";
            this.Sides.Size = new System.Drawing.Size(44, 20);
            this.Sides.TabIndex = 16;
            this.Sides.Text = "Sides";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceLabel.Location = new System.Drawing.Point(858, 343);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(105, 28);
            this.PriceLabel.TabIndex = 17;
            this.PriceLabel.Text = "Total Price:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 482);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.Sides);
            this.Controls.Add(this.SidesList);
            this.Controls.Add(this.Drinks);
            this.Controls.Add(this.DrinksList);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.AddonList);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PromotionBox);
            this.Controls.Add(this.Sauce);
            this.Controls.Add(this.SauceList);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MenuList);
            this.Name = "OrderForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        public ListBox MenuList;
        public Label Menu;
        public ListBox SauceList;
        public Label Sauce;
        public CheckBox PromotionBox;
        public Button SubmitButton;
        public ListBox OrderList;
        public Label Order;
        public ListBox AddonList;
        public Label AddItem;
        public Label CustomerName;
        private ListBox DrinksList;
        private Label Drinks;
        private ListBox SidesList;
        private Label Sides;
        private Label label8;
        private Label PriceLabel;
    }
}