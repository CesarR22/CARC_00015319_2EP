using System.ComponentModel;

namespace Parcial02POO
{
    partial class MainUserMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.Order = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BusinessCmbBox = new System.Windows.Forms.ComboBox();
            this.ProductCmbBox = new System.Windows.Forms.ComboBox();
            this.OrderReadyButton = new System.Windows.Forms.Button();
            this.AddressCmbBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentAddress = new System.Windows.Forms.TextBox();
            this.UpdateAddressButton = new System.Windows.Forms.Button();
            this.NewAddressTxt = new System.Windows.Forms.TextBox();
            this.UserOrderList = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.Business = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OrderList = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.Order.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Address.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.UserOrderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView4)).BeginInit();
            this.Business.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            this.OrderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tabMenu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 465F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.Order);
            this.tabMenu.Controls.Add(this.Address);
            this.tabMenu.Controls.Add(this.UserOrderList);
            this.tabMenu.Controls.Add(this.Business);
            this.tabMenu.Controls.Add(this.Users);
            this.tabMenu.Controls.Add(this.OrderList);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(3, 3);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(496, 459);
            this.tabMenu.TabIndex = 0;
            // 
            // Order
            // 
            this.Order.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (59)))), ((int) (((byte) (35)))),
                ((int) (((byte) (95)))));
            this.Order.Controls.Add(this.tableLayoutPanel2);
            this.Order.Location = new System.Drawing.Point(4, 24);
            this.Order.Name = "Order";
            this.Order.Padding = new System.Windows.Forms.Padding(3);
            this.Order.Size = new System.Drawing.Size(488, 431);
            this.Order.TabIndex = 0;
            this.Order.Text = "Realizar Pedido";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BusinessCmbBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ProductCmbBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.OrderReadyButton, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.AddressCmbBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.DescriptionBox, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.52941F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.23529F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(482, 425);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 117);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Business:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BusinessCmbBox
            // 
            this.BusinessCmbBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BusinessCmbBox.FormattingEnabled = true;
            this.BusinessCmbBox.Location = new System.Drawing.Point(263, 31);
            this.BusinessCmbBox.Name = "BusinessCmbBox";
            this.BusinessCmbBox.Size = new System.Drawing.Size(196, 23);
            this.BusinessCmbBox.TabIndex = 1;
            // 
            // ProductCmbBox
            // 
            this.ProductCmbBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductCmbBox.FormattingEnabled = true;
            this.ProductCmbBox.Location = new System.Drawing.Point(263, 132);
            this.ProductCmbBox.Name = "ProductCmbBox";
            this.ProductCmbBox.Size = new System.Drawing.Size(196, 23);
            this.ProductCmbBox.TabIndex = 2;
            // 
            // OrderReadyButton
            // 
            this.OrderReadyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderReadyButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.OrderReadyButton.Location = new System.Drawing.Point(244, 342);
            this.OrderReadyButton.Name = "OrderReadyButton";
            this.OrderReadyButton.Size = new System.Drawing.Size(235, 80);
            this.OrderReadyButton.TabIndex = 6;
            this.OrderReadyButton.Text = "make an order:";
            this.OrderReadyButton.UseVisualStyleBackColor = true;
            // 
            // AddressCmbBox
            // 
            this.AddressCmbBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddressCmbBox.FormattingEnabled = true;
            this.AddressCmbBox.Location = new System.Drawing.Point(263, 285);
            this.AddressCmbBox.Name = "AddressCmbBox";
            this.AddressCmbBox.Size = new System.Drawing.Size(196, 23);
            this.AddressCmbBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 85);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DescriptionBox.Location = new System.Drawing.Point(246, 205);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ReadOnly = true;
            this.DescriptionBox.Size = new System.Drawing.Size(231, 23);
            this.DescriptionBox.TabIndex = 7;
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (59)))), ((int) (((byte) (35)))),
                ((int) (((byte) (95)))));
            this.Address.Controls.Add(this.tableLayoutPanel3);
            this.Address.Location = new System.Drawing.Point(4, 24);
            this.Address.Name = "Address";
            this.Address.Padding = new System.Windows.Forms.Padding(3);
            this.Address.Size = new System.Drawing.Size(488, 431);
            this.Address.TabIndex = 1;
            this.Address.Text = "Dirección";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CurrentAddress, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.UpdateAddressButton, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.NewAddressTxt, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(482, 425);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 177);
            this.label5.TabIndex = 4;
            this.label5.Text = "New address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 177);
            this.label4.TabIndex = 0;
            this.label4.Text = "Old Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentAddress
            // 
            this.CurrentAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentAddress.Location = new System.Drawing.Point(245, 77);
            this.CurrentAddress.Name = "CurrentAddress";
            this.CurrentAddress.ReadOnly = true;
            this.CurrentAddress.Size = new System.Drawing.Size(233, 23);
            this.CurrentAddress.TabIndex = 1;
            // 
            // UpdateAddressButton
            // 
            this.UpdateAddressButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateAddressButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.UpdateAddressButton.Location = new System.Drawing.Point(244, 357);
            this.UpdateAddressButton.Name = "UpdateAddressButton";
            this.UpdateAddressButton.Size = new System.Drawing.Size(235, 65);
            this.UpdateAddressButton.TabIndex = 2;
            this.UpdateAddressButton.Text = "update address";
            this.UpdateAddressButton.UseVisualStyleBackColor = true;
            // 
            // NewAddressTxt
            // 
            this.NewAddressTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewAddressTxt.Location = new System.Drawing.Point(245, 254);
            this.NewAddressTxt.Name = "NewAddressTxt";
            this.NewAddressTxt.Size = new System.Drawing.Size(233, 23);
            this.NewAddressTxt.TabIndex = 3;
            // 
            // UserOrderList
            // 
            this.UserOrderList.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (59)))),
                ((int) (((byte) (35)))), ((int) (((byte) (95)))));
            this.UserOrderList.Controls.Add(this.dataGridView4);
            this.UserOrderList.Controls.Add(this.label12);
            this.UserOrderList.Location = new System.Drawing.Point(4, 24);
            this.UserOrderList.Name = "UserOrderList";
            this.UserOrderList.Size = new System.Drawing.Size(488, 431);
            this.UserOrderList.TabIndex = 4;
            this.UserOrderList.Text = "Lista de Pedidos";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(10, 126);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(467, 228);
            this.dataGridView4.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(114, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(313, 68);
            this.label12.TabIndex = 0;
            this.label12.Text = "LIST OF ORDERS";
            // 
            // Business
            // 
            this.Business.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (59)))), ((int) (((byte) (35)))),
                ((int) (((byte) (95)))));
            this.Business.Controls.Add(this.dataGridView1);
            this.Business.Controls.Add(this.textBox1);
            this.Business.Controls.Add(this.button1);
            this.Business.Controls.Add(this.label7);
            this.Business.Controls.Add(this.label6);
            this.Business.Location = new System.Drawing.Point(4, 24);
            this.Business.Name = "Business";
            this.Business.Padding = new System.Windows.Forms.Padding(3);
            this.Business.Size = new System.Drawing.Size(488, 431);
            this.Business.TabIndex = 2;
            this.Business.Text = "Negocios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 179);
            this.dataGridView1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 23);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 74);
            this.label7.TabIndex = 1;
            this.label7.Text = "Name of business:\r\n";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(160, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 65);
            this.label6.TabIndex = 0;
            this.label6.Text = "Business";
            // 
            // Users
            // 
            this.Users.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (59)))), ((int) (((byte) (35)))),
                ((int) (((byte) (95)))));
            this.Users.Controls.Add(this.button2);
            this.Users.Controls.Add(this.dataGridView2);
            this.Users.Controls.Add(this.textBox2);
            this.Users.Controls.Add(this.label9);
            this.Users.Controls.Add(this.label8);
            this.Users.Location = new System.Drawing.Point(4, 24);
            this.Users.Name = "Users";
            this.Users.Padding = new System.Windows.Forms.Padding(3);
            this.Users.Size = new System.Drawing.Size(488, 431);
            this.Users.TabIndex = 3;
            this.Users.Text = "Usuarios";
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 246);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(479, 179);
            this.dataGridView2.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 65);
            this.label9.TabIndex = 2;
            this.label9.Text = "Username:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(143, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 65);
            this.label8.TabIndex = 1;
            this.label8.Text = "Users";
            // 
            // OrderList
            // 
            this.OrderList.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (59)))), ((int) (((byte) (35)))),
                ((int) (((byte) (95)))));
            this.OrderList.Controls.Add(this.button3);
            this.OrderList.Controls.Add(this.dataGridView3);
            this.OrderList.Controls.Add(this.label11);
            this.OrderList.Controls.Add(this.label10);
            this.OrderList.Controls.Add(this.textBox3);
            this.OrderList.Location = new System.Drawing.Point(4, 24);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(488, 431);
            this.OrderList.TabIndex = 5;
            this.OrderList.Text = "Pedidos";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 54);
            this.button3.TabIndex = 8;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(17, 237);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(467, 179);
            this.dataGridView3.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(169, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 65);
            this.label11.TabIndex = 6;
            this.label11.Text = "Orders";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(69, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 65);
            this.label10.TabIndex = 5;
            this.label10.Text = "Order:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(237, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 23);
            this.textBox3.TabIndex = 4;
            // 
            // MainUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainUserMenu";
            this.Size = new System.Drawing.Size(502, 465);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.Order.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.Address.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.UserOrderList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView4)).EndInit();
            this.Business.ResumeLayout(false);
            this.Business.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.Users.ResumeLayout(false);
            this.Users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            this.OrderList.ResumeLayout(false);
            this.OrderList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage UserOrderList;
        private System.Windows.Forms.TabPage OrderList;
        private System.Windows.Forms.TabPage Order;
        private System.Windows.Forms.TabPage Address;
        private System.Windows.Forms.TabPage Business;
        private System.Windows.Forms.TabPage Users;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProductCmbBox;
        private System.Windows.Forms.ComboBox AddressCmbBox;
        private System.Windows.Forms.ComboBox BusinessCmbBox;
        private System.Windows.Forms.Button OrderReadyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CurrentAddress;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NewAddressTxt;
        private System.Windows.Forms.Button UpdateAddressButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}