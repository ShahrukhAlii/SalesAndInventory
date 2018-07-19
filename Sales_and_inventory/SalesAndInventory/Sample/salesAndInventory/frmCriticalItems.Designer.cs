﻿namespace skelot
{
    partial class frmCriticalItems
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriticalItems));
            this.cboItems = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTempDate = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cboManufac = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtNetPrice = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrStock = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button5 = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtIDCode = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboItems
            // 
            this.cboItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItems.FormattingEnabled = true;
            this.cboItems.Items.AddRange(new object[] {
            "-SELECT-",
            "Under Stock",
            "Out of Stock"});
            this.cboItems.Location = new System.Drawing.Point(25, 44);
            this.cboItems.Name = "cboItems";
            this.cboItems.Size = new System.Drawing.Size(131, 29);
            this.cboItems.TabIndex = 4;
            this.cboItems.SelectedIndexChanged += new System.EventHandler(this.cboItems_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTempDate
            // 
            this.lblTempDate.AutoSize = true;
            this.lblTempDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTempDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTempDate.Location = new System.Drawing.Point(556, 47);
            this.lblTempDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTempDate.Name = "lblTempDate";
            this.lblTempDate.Size = new System.Drawing.Size(57, 22);
            this.lblTempDate.TabIndex = 71;
            this.lblTempDate.Text = "Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(617, 240);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 19);
            this.label16.TabIndex = 70;
            this.label16.Text = "# Days of Delivery";
            // 
            // txtDays
            // 
            this.txtDays.BackColor = System.Drawing.Color.White;
            this.txtDays.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDays.Location = new System.Drawing.Point(774, 234);
            this.txtDays.Margin = new System.Windows.Forms.Padding(5);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(159, 27);
            this.txtDays.TabIndex = 69;
            this.txtDays.TextChanged += new System.EventHandler(this.txtDays_TextChanged);
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.Color.White;
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOrderID.Location = new System.Drawing.Point(1118, 63);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(5);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(159, 27);
            this.txtOrderID.TabIndex = 67;
            this.txtOrderID.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(967, 66);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 21);
            this.label17.TabIndex = 68;
            this.label17.Text = "OrderID";
            this.label17.Visible = false;
            // 
            // cboManufac
            // 
            this.cboManufac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManufac.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboManufac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboManufac.FormattingEnabled = true;
            this.cboManufac.Items.AddRange(new object[] {
            "-Select-"});
            this.cboManufac.Location = new System.Drawing.Point(774, 158);
            this.cboManufac.Margin = new System.Windows.Forms.Padding(5);
            this.cboManufac.Name = "cboManufac";
            this.cboManufac.Size = new System.Drawing.Size(159, 29);
            this.cboManufac.TabIndex = 64;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(617, 161);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 22);
            this.label18.TabIndex = 63;
            this.label18.Text = "Manufacturer";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(164, 5);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 22);
            this.label19.TabIndex = 73;
            this.label19.Text = "Date:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(212, 5);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(98, 22);
            this.lblDate.TabIndex = 72;
            this.lblDate.Text = "DateNow";
            // 
            // txtNetPrice
            // 
            this.txtNetPrice.BackColor = System.Drawing.Color.White;
            this.txtNetPrice.Enabled = false;
            this.txtNetPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNetPrice.Location = new System.Drawing.Point(1118, 176);
            this.txtNetPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtNetPrice.Name = "txtNetPrice";
            this.txtNetPrice.Size = new System.Drawing.Size(159, 27);
            this.txtNetPrice.TabIndex = 61;
            this.txtNetPrice.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(967, 179);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 21);
            this.label21.TabIndex = 62;
            this.label21.Text = "Offered Price";
            this.label21.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(967, 105);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 21);
            this.label22.TabIndex = 46;
            this.label22.Text = "Product ID";
            this.label22.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.s);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCurrStock);
            this.panel1.Controls.Add(this.lblTempDate);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cboItems);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtDays);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.cboManufac);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 403);
            this.panel1.TabIndex = 75;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(408, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 82;
            this.label2.Text = "Date of Delivery:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(764, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 33);
            this.button1.TabIndex = 81;
            this.button1.Text = "Update Crit-Limit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.BackColor = System.Drawing.Color.Transparent;
            this.s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.s.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.s.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.s.Location = new System.Drawing.Point(35, 368);
            this.s.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(64, 21);
            this.s.TabIndex = 76;
            this.s.Text = "Search";
            this.s.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(109, 365);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 27);
            this.txtSearch.TabIndex = 77;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(164, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 22);
            this.label1.TabIndex = 75;
            this.label1.Text = "Current Stock on Hold:";
            // 
            // lblCurrStock
            // 
            this.lblCurrStock.AutoSize = true;
            this.lblCurrStock.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrStock.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurrStock.Location = new System.Drawing.Point(358, 47);
            this.lblCurrStock.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCurrStock.Name = "lblCurrStock";
            this.lblCurrStock.Size = new System.Drawing.Size(24, 22);
            this.lblCurrStock.TabIndex = 74;
            this.lblCurrStock.Text = "#";
            this.lblCurrStock.Click += new System.EventHandler(this.lblCurrStock_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(774, 121);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 27);
            this.txtName.TabIndex = 40;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label24.Location = new System.Drawing.Point(617, 124);
            this.label24.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 22);
            this.label24.TabIndex = 39;
            this.label24.Text = "Product";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label23.Location = new System.Drawing.Point(617, 200);
            this.label23.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 22);
            this.label23.TabIndex = 60;
            this.label23.Text = "Pcs";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.White;
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(25, 81);
            this.listView2.Margin = new System.Windows.Forms.Padding(5);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(582, 274);
            this.listView2.TabIndex = 58;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(774, 271);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 32);
            this.button5.TabIndex = 41;
            this.button5.Text = "Order";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStock.Location = new System.Drawing.Point(774, 197);
            this.txtStock.Margin = new System.Windows.Forms.Padding(5);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(159, 27);
            this.txtStock.TabIndex = 59;
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.Color.White;
            this.txtSize.Enabled = false;
            this.txtSize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSize.Location = new System.Drawing.Point(1118, 287);
            this.txtSize.Margin = new System.Windows.Forms.Padding(5);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(159, 27);
            this.txtSize.TabIndex = 79;
            this.txtSize.Visible = false;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.White;
            this.txtType.Enabled = false;
            this.txtType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtType.Location = new System.Drawing.Point(1118, 250);
            this.txtType.Margin = new System.Windows.Forms.Padding(5);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(159, 27);
            this.txtType.TabIndex = 78;
            this.txtType.Visible = false;
            // 
            // txtIDCode
            // 
            this.txtIDCode.BackColor = System.Drawing.Color.White;
            this.txtIDCode.Enabled = false;
            this.txtIDCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDCode.Location = new System.Drawing.Point(1118, 102);
            this.txtIDCode.Margin = new System.Windows.Forms.Padding(5);
            this.txtIDCode.Name = "txtIDCode";
            this.txtIDCode.Size = new System.Drawing.Size(159, 27);
            this.txtIDCode.TabIndex = 44;
            this.txtIDCode.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label25.Location = new System.Drawing.Point(967, 253);
            this.label25.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 21);
            this.label25.TabIndex = 51;
            this.label25.Text = "Type";
            this.label25.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label26.Location = new System.Drawing.Point(967, 290);
            this.label26.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 21);
            this.label26.TabIndex = 54;
            this.label26.Text = "Size";
            this.label26.Visible = false;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.Location = new System.Drawing.Point(1118, 213);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(159, 27);
            this.txtPrice.TabIndex = 43;
            this.txtPrice.Visible = false;
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.Color.White;
            this.txtBrand.Enabled = false;
            this.txtBrand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBrand.Location = new System.Drawing.Point(1118, 324);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(5);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(159, 27);
            this.txtBrand.TabIndex = 55;
            this.txtBrand.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label27.Location = new System.Drawing.Point(967, 327);
            this.label27.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 21);
            this.label27.TabIndex = 56;
            this.label27.Text = "Brand";
            this.label27.Visible = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label28.Location = new System.Drawing.Point(967, 216);
            this.label28.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 21);
            this.label28.TabIndex = 45;
            this.label28.Text = "Price";
            this.label28.Visible = false;
            // 
            // frmCriticalItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(973, 432);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtIDCode);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtNetPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCriticalItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "00-";
            this.Load += new System.EventHandler(this.frmCriticalItems_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboItems;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTempDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboManufac;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtNetPrice;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIDCode;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrStock;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}