namespace RestaurantMS_Definitive
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.adminTab = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.itemIDText = new System.Windows.Forms.TextBox();
            this.itemCategoryText = new System.Windows.Forms.ComboBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.itemPriceText = new System.Windows.Forms.TextBox();
            this.itemNameText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteItem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.catogoryChoice = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.itemPrice = new System.Windows.Forms.Label();
            this.itemCatogory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.totalAmount = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.year = new System.Windows.Forms.RadioButton();
            this.yearText = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.sortShow = new System.Windows.Forms.Button();
            this.monthText = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.month = new System.Windows.Forms.RadioButton();
            this.date = new System.Windows.Forms.RadioButton();
            this.dateText = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.transactionView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.saveTable = new System.Windows.Forms.Button();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tableNum = new System.Windows.Forms.NumericUpDown();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.userView = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteUser = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addButton2 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.TextBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.exitButton = new System.Windows.Forms.Button();
            this.adminTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableNum)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTab
            // 
            this.adminTab.Controls.Add(this.tabPage1);
            this.adminTab.Controls.Add(this.tabPage2);
            this.adminTab.Controls.Add(this.tabPage3);
            this.adminTab.Controls.Add(this.tabPage4);
            this.adminTab.Depth = 0;
            this.adminTab.Location = new System.Drawing.Point(16, 127);
            this.adminTab.Margin = new System.Windows.Forms.Padding(4);
            this.adminTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.adminTab.Name = "adminTab";
            this.adminTab.SelectedIndex = 0;
            this.adminTab.Size = new System.Drawing.Size(1021, 496);
            this.adminTab.TabIndex = 0;
            this.adminTab.SelectedIndexChanged += new System.EventHandler(this.adminTab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1013, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menu";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.itemIDText);
            this.groupBox5.Controls.Add(this.itemCategoryText);
            this.groupBox5.Controls.Add(this.modifyButton);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.itemPriceText);
            this.groupBox5.Controls.Add(this.itemNameText);
            this.groupBox5.Location = new System.Drawing.Point(644, 213);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(360, 235);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ndrysho Ushqimin/Pijen";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "ID";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // itemIDText
            // 
            this.itemIDText.Location = new System.Drawing.Point(148, 30);
            this.itemIDText.Margin = new System.Windows.Forms.Padding(4);
            this.itemIDText.Name = "itemIDText";
            this.itemIDText.ReadOnly = true;
            this.itemIDText.Size = new System.Drawing.Size(195, 22);
            this.itemIDText.TabIndex = 16;
            this.itemIDText.TextChanged += new System.EventHandler(this.itemIDText_TextChanged);
            // 
            // itemCategoryText
            // 
            this.itemCategoryText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemCategoryText.FormattingEnabled = true;
            this.itemCategoryText.Items.AddRange(new object[] {
            "food",
            "beverage"});
            this.itemCategoryText.Location = new System.Drawing.Point(148, 129);
            this.itemCategoryText.Margin = new System.Windows.Forms.Padding(4);
            this.itemCategoryText.Name = "itemCategoryText";
            this.itemCategoryText.Size = new System.Drawing.Size(195, 24);
            this.itemCategoryText.TabIndex = 15;
            this.itemCategoryText.SelectedIndexChanged += new System.EventHandler(this.itemCategoryText_SelectedIndexChanged);
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.modifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.modifyButton.Image = global::RestaurantMS_Definitive.Properties.Resources.sort;
            this.modifyButton.Location = new System.Drawing.Point(192, 162);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(160, 65);
            this.modifyButton.TabIndex = 14;
            this.modifyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.modifyButton.UseVisualStyleBackColor = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Çmimi (MKD)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kategorija";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Emri";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // itemPriceText
            // 
            this.itemPriceText.Location = new System.Drawing.Point(148, 94);
            this.itemPriceText.Margin = new System.Windows.Forms.Padding(4);
            this.itemPriceText.Name = "itemPriceText";
            this.itemPriceText.Size = new System.Drawing.Size(195, 22);
            this.itemPriceText.TabIndex = 6;
            this.itemPriceText.TextChanged += new System.EventHandler(this.itemPriceText_TextChanged);
            // 
            // itemNameText
            // 
            this.itemNameText.Location = new System.Drawing.Point(148, 62);
            this.itemNameText.Margin = new System.Windows.Forms.Padding(4);
            this.itemNameText.Name = "itemNameText";
            this.itemNameText.Size = new System.Drawing.Size(195, 22);
            this.itemNameText.TabIndex = 4;
            this.itemNameText.TextChanged += new System.EventHandler(this.itemNameText_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.menuView);
            this.groupBox2.Controls.Add(this.deleteItem);
            this.groupBox2.Location = new System.Drawing.Point(8, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(636, 444);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // menuView
            // 
            this.menuView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader1});
            this.menuView.FullRowSelect = true;
            this.menuView.HideSelection = false;
            this.menuView.Location = new System.Drawing.Point(8, 23);
            this.menuView.Margin = new System.Windows.Forms.Padding(4);
            this.menuView.MultiSelect = false;
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(619, 340);
            this.menuView.TabIndex = 11;
            this.menuView.UseCompatibleStateImageBehavior = false;
            this.menuView.View = System.Windows.Forms.View.Details;
            this.menuView.SelectedIndexChanged += new System.EventHandler(this.menuView_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Emri";
            this.columnHeader5.Width = 234;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kategorija";
            this.columnHeader6.Width = 97;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Çmimi (MKD)";
            this.columnHeader1.Width = 144;
            // 
            // deleteItem
            // 
            this.deleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.deleteItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteItem.FlatAppearance.BorderSize = 0;
            this.deleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItem.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteItem.Image")));
            this.deleteItem.Location = new System.Drawing.Point(472, 372);
            this.deleteItem.Margin = new System.Windows.Forms.Padding(4);
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(156, 65);
            this.deleteItem.TabIndex = 9;
            this.deleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteItem.UseVisualStyleBackColor = false;
            this.deleteItem.Click += new System.EventHandler(this.deleteItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.catogoryChoice);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.itemPrice);
            this.groupBox1.Controls.Add(this.itemCatogory);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.itemName);
            this.groupBox1.Location = new System.Drawing.Point(644, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(360, 198);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shto Ushqim/Pije";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // catogoryChoice
            // 
            this.catogoryChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catogoryChoice.FormattingEnabled = true;
            this.catogoryChoice.Items.AddRange(new object[] {
            "food",
            "beverage"});
            this.catogoryChoice.Location = new System.Drawing.Point(148, 91);
            this.catogoryChoice.Margin = new System.Windows.Forms.Padding(4);
            this.catogoryChoice.Name = "catogoryChoice";
            this.catogoryChoice.Size = new System.Drawing.Size(195, 24);
            this.catogoryChoice.TabIndex = 15;
            this.catogoryChoice.SelectedIndexChanged += new System.EventHandler(this.catogoryChoice_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addButton.Image = global::RestaurantMS_Definitive.Properties.Resources.plus;
            this.addButton.Location = new System.Drawing.Point(207, 124);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(137, 65);
            this.addButton.TabIndex = 14;
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // itemPrice
            // 
            this.itemPrice.AutoSize = true;
            this.itemPrice.Location = new System.Drawing.Point(8, 59);
            this.itemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(89, 17);
            this.itemPrice.TabIndex = 8;
            this.itemPrice.Text = "Çmimi (MKD)";
            this.itemPrice.Click += new System.EventHandler(this.itemPrice_Click);
            // 
            // itemCatogory
            // 
            this.itemCatogory.AutoSize = true;
            this.itemCatogory.Location = new System.Drawing.Point(8, 91);
            this.itemCatogory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemCatogory.Name = "itemCatogory";
            this.itemCatogory.Size = new System.Drawing.Size(72, 17);
            this.itemCatogory.TabIndex = 7;
            this.itemCatogory.Text = "Kategorija";
            this.itemCatogory.Click += new System.EventHandler(this.itemCatogory_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Emri";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(148, 55);
            this.price.Margin = new System.Windows.Forms.Padding(4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(195, 22);
            this.price.TabIndex = 6;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(148, 23);
            this.itemName.Margin = new System.Windows.Forms.Padding(4);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(195, 22);
            this.itemName.TabIndex = 4;
            this.itemName.TextChanged += new System.EventHandler(this.itemName_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.totalAmount);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.transactionView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1013, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pagesat";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // totalAmount
            // 
            this.totalAmount.Location = new System.Drawing.Point(815, 415);
            this.totalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            this.totalAmount.Size = new System.Drawing.Size(173, 22);
            this.totalAmount.TabIndex = 11;
            this.totalAmount.TextChanged += new System.EventHandler(this.totalAmount_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(573, 413);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(224, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Të Ardhurat Totale (MKD)";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.year);
            this.groupBox3.Controls.Add(this.yearText);
            this.groupBox3.Controls.Add(this.materialLabel5);
            this.groupBox3.Controls.Add(this.sortShow);
            this.groupBox3.Controls.Add(this.monthText);
            this.groupBox3.Controls.Add(this.materialLabel4);
            this.groupBox3.Controls.Add(this.materialLabel3);
            this.groupBox3.Controls.Add(this.month);
            this.groupBox3.Controls.Add(this.date);
            this.groupBox3.Controls.Add(this.dateText);
            this.groupBox3.Controls.Add(this.materialLabel2);
            this.groupBox3.Controls.Add(this.calendar);
            this.groupBox3.Location = new System.Drawing.Point(8, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(428, 441);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shiko Historinë e Pagesave";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(168, 356);
            this.year.Margin = new System.Windows.Forms.Padding(4);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(56, 21);
            this.year.TabIndex = 21;
            this.year.TabStop = true;
            this.year.Text = "Vjeti";
            this.year.UseVisualStyleBackColor = true;
            this.year.CheckedChanged += new System.EventHandler(this.year_CheckedChanged);
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(87, 298);
            this.yearText.Margin = new System.Windows.Forms.Padding(4);
            this.yearText.Name = "yearText";
            this.yearText.ReadOnly = true;
            this.yearText.Size = new System.Drawing.Size(245, 22);
            this.yearText.TabIndex = 20;
            this.yearText.TextChanged += new System.EventHandler(this.yearText_TextChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(9, 297);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(48, 24);
            this.materialLabel5.TabIndex = 19;
            this.materialLabel5.Text = "Vjeti";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // sortShow
            // 
            this.sortShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.sortShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sortShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortShow.FlatAppearance.BorderSize = 0;
            this.sortShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortShow.ForeColor = System.Drawing.SystemColors.Control;
            this.sortShow.Image = global::RestaurantMS_Definitive.Properties.Resources.presentation;
            this.sortShow.Location = new System.Drawing.Point(196, 385);
            this.sortShow.Margin = new System.Windows.Forms.Padding(4);
            this.sortShow.Name = "sortShow";
            this.sortShow.Size = new System.Drawing.Size(195, 48);
            this.sortShow.TabIndex = 18;
            this.sortShow.Text = "SHFAQ";
            this.sortShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sortShow.UseVisualStyleBackColor = false;
            this.sortShow.Click += new System.EventHandler(this.sortShow_Click);
            // 
            // monthText
            // 
            this.monthText.Location = new System.Drawing.Point(87, 266);
            this.monthText.Margin = new System.Windows.Forms.Padding(4);
            this.monthText.Name = "monthText";
            this.monthText.ReadOnly = true;
            this.monthText.Size = new System.Drawing.Size(245, 22);
            this.monthText.TabIndex = 17;
            this.monthText.TextChanged += new System.EventHandler(this.monthText_TextChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(9, 265);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(57, 24);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Muaji";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(5, 329);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(137, 24);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Rradhitja Sipas";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(87, 357);
            this.month.Margin = new System.Windows.Forms.Padding(4);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(62, 21);
            this.month.TabIndex = 14;
            this.month.Text = "Muaji";
            this.month.UseVisualStyleBackColor = true;
            this.month.CheckedChanged += new System.EventHandler(this.month_CheckedChanged);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Checked = true;
            this.date.Location = new System.Drawing.Point(7, 357);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(59, 21);
            this.date.TabIndex = 13;
            this.date.TabStop = true;
            this.date.Text = "Data";
            this.date.UseVisualStyleBackColor = true;
            this.date.CheckedChanged += new System.EventHandler(this.date_CheckedChanged);
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(87, 234);
            this.dateText.Margin = new System.Windows.Forms.Padding(4);
            this.dateText.Name = "dateText";
            this.dateText.ReadOnly = true;
            this.dateText.Size = new System.Drawing.Size(245, 22);
            this.dateText.TabIndex = 12;
            this.dateText.TextChanged += new System.EventHandler(this.dateText_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 233);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(48, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Data";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(16, 30);
            this.calendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // transactionView
            // 
            this.transactionView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader7});
            this.transactionView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionView.HideSelection = false;
            this.transactionView.Location = new System.Drawing.Point(444, 7);
            this.transactionView.Margin = new System.Windows.Forms.Padding(4);
            this.transactionView.Name = "transactionView";
            this.transactionView.Size = new System.Drawing.Size(557, 393);
            this.transactionView.TabIndex = 0;
            this.transactionView.UseCompatibleStateImageBehavior = false;
            this.transactionView.View = System.Windows.Forms.View.Details;
            this.transactionView.SelectedIndexChanged += new System.EventHandler(this.transactionView_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Porosia ID";
            this.columnHeader3.Width = 136;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data";
            this.columnHeader4.Width = 115;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Shuma (MKD)";
            this.columnHeader7.Width = 248;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.saveTable);
            this.tabPage3.Controls.Add(this.materialLabel6);
            this.tabPage3.Controls.Add(this.tableNum);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1013, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tavolinat";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // saveTable
            // 
            this.saveTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.saveTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTable.ForeColor = System.Drawing.SystemColors.Control;
            this.saveTable.Image = global::RestaurantMS_Definitive.Properties.Resources.content_save;
            this.saveTable.Location = new System.Drawing.Point(793, 337);
            this.saveTable.Margin = new System.Windows.Forms.Padding(4);
            this.saveTable.Name = "saveTable";
            this.saveTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveTable.Size = new System.Drawing.Size(169, 73);
            this.saveTable.TabIndex = 15;
            this.saveTable.Text = "RUAJ";
            this.saveTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveTable.UseVisualStyleBackColor = false;
            this.saveTable.Click += new System.EventHandler(this.saveTable_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(25, 46);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(278, 24);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Shuma e tavolinave në restorant";
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // tableNum
            // 
            this.tableNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNum.Location = new System.Drawing.Point(31, 73);
            this.tableNum.Margin = new System.Windows.Forms.Padding(4);
            this.tableNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tableNum.Name = "tableNum";
            this.tableNum.ReadOnly = true;
            this.tableNum.Size = new System.Drawing.Size(932, 57);
            this.tableNum.TabIndex = 1;
            this.tableNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tableNum.ValueChanged += new System.EventHandler(this.tableNum_ValueChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.userView);
            this.tabPage4.Controls.Add(this.deleteUser);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1013, 467);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Përdoruesit";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // userView
            // 
            this.userView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.Username,
            this.columnHeader13});
            this.userView.FullRowSelect = true;
            this.userView.HideSelection = false;
            this.userView.Location = new System.Drawing.Point(8, 18);
            this.userView.Margin = new System.Windows.Forms.Padding(4);
            this.userView.MultiSelect = false;
            this.userView.Name = "userView";
            this.userView.Size = new System.Drawing.Size(993, 155);
            this.userView.TabIndex = 16;
            this.userView.UseCompatibleStateImageBehavior = false;
            this.userView.View = System.Windows.Forms.View.Details;
            this.userView.SelectedIndexChanged += new System.EventHandler(this.userView_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 86;
            // 
            // Username
            // 
            this.Username.Text = "Përdoruesi";
            this.Username.Width = 465;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Privilegji";
            this.columnHeader13.Width = 188;
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.deleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUser.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteUser.Image = global::RestaurantMS_Definitive.Properties.Resources.delete__1_;
            this.deleteUser.Location = new System.Drawing.Point(745, 182);
            this.deleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(257, 97);
            this.deleteUser.TabIndex = 15;
            this.deleteUser.Text = "Fshije Përdoruesin";
            this.deleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteUser.UseVisualStyleBackColor = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.addButton2);
            this.groupBox4.Controls.Add(this.name);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.pw);
            this.groupBox4.Location = new System.Drawing.Point(8, 182);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(332, 266);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Përdoruesi";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // addButton2
            // 
            this.addButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.addButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.addButton2.Image = global::RestaurantMS_Definitive.Properties.Resources.plus;
            this.addButton2.Location = new System.Drawing.Point(173, 165);
            this.addButton2.Margin = new System.Windows.Forms.Padding(4);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(137, 65);
            this.addButton2.TabIndex = 14;
            this.addButton2.Text = "Shto";
            this.addButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton2.UseVisualStyleBackColor = false;
            this.addButton2.Click += new System.EventHandler(this.addNewUser_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(101, 32);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(195, 22);
            this.name.TabIndex = 4;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fjalëkalimi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pw
            // 
            this.pw.Location = new System.Drawing.Point(101, 78);
            this.pw.Margin = new System.Windows.Forms.Padding(4);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(195, 22);
            this.pw.TabIndex = 6;
            this.pw.TextChanged += new System.EventHandler(this.pw_TextChanged);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.adminTab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 78);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1055, 42);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Image = global::RestaurantMS_Definitive.Properties.Resources.undo;
            this.exitButton.Location = new System.Drawing.Point(931, 36);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 48);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Dil";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 619);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.adminTab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paneli i Administratorit";
            this.adminTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableNum)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl adminTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label itemPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Button deleteItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView transactionView;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox totalAmount;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.RadioButton month;
        private System.Windows.Forms.RadioButton date;
        private System.Windows.Forms.TextBox dateText;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox monthText;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Button sortShow;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView menuView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label itemCatogory;
        private System.Windows.Forms.ComboBox catogoryChoice;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NumericUpDown tableNum;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.TextBox yearText;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.RadioButton year;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Button saveTable;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addButton2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.ListView userView;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox itemIDText;
        private System.Windows.Forms.ComboBox itemCategoryText;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox itemPriceText;
        private System.Windows.Forms.TextBox itemNameText;
    }
}