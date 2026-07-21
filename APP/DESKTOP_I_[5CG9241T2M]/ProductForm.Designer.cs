namespace DESKTOP_I__5CG9241T2M_
{
    partial class ProductForm
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgv_product = new DataGridView();
            groupBox_Detail = new GroupBox();
            button_cancel = new Button();
            button_save = new Button();
            cbx_status = new ComboBox();
            label_Status = new Label();
            nUD_UnitStok = new NumericUpDown();
            nUD_prince = new NumericUpDown();
            label_unitStok = new Label();
            label_prince = new Label();
            label_nama = new Label();
            check_Measurable = new CheckBox();
            check_countable = new CheckBox();
            label_unitType = new Label();
            comboBox_categories = new ComboBox();
            text_detailNama = new TextBox();
            label_categories = new Label();
            label2 = new Label();
            groupBox_transactional = new GroupBox();
            label_delevery = new Label();
            label_totaTransaksi = new Label();
            NUP_quantity = new NumericUpDown();
            button2 = new Button();
            button_Buy = new Button();
            label_deleverycost = new Label();
            label_total = new Label();
            label_quantity = new Label();
            b_AddItem = new Button();
            b_EditItem = new Button();
            b_DeleteItem = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_product).BeginInit();
            groupBox_Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_UnitStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_prince).BeginInit();
            groupBox_transactional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUP_quantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 27);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 0;
            label1.Text = "Product Area";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_product);
            groupBox1.Location = new Point(45, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(873, 206);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "List";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dgv_product
            // 
            dgv_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_product.Location = new Point(6, 25);
            dgv_product.Name = "dgv_product";
            dgv_product.RowHeadersWidth = 62;
            dgv_product.Size = new Size(864, 181);
            dgv_product.TabIndex = 0;
            dgv_product.CellClick += dgv_product_CellClick;
            dgv_product.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox_Detail
            // 
            groupBox_Detail.Controls.Add(button_cancel);
            groupBox_Detail.Controls.Add(button_save);
            groupBox_Detail.Controls.Add(cbx_status);
            groupBox_Detail.Controls.Add(label_Status);
            groupBox_Detail.Controls.Add(nUD_UnitStok);
            groupBox_Detail.Controls.Add(nUD_prince);
            groupBox_Detail.Controls.Add(label_unitStok);
            groupBox_Detail.Controls.Add(label_prince);
            groupBox_Detail.Controls.Add(label_nama);
            groupBox_Detail.Controls.Add(check_Measurable);
            groupBox_Detail.Controls.Add(check_countable);
            groupBox_Detail.Controls.Add(label_unitType);
            groupBox_Detail.Controls.Add(comboBox_categories);
            groupBox_Detail.Controls.Add(text_detailNama);
            groupBox_Detail.Controls.Add(label_categories);
            groupBox_Detail.Controls.Add(label2);
            groupBox_Detail.Location = new Point(45, 364);
            groupBox_Detail.Name = "groupBox_Detail";
            groupBox_Detail.Size = new Size(518, 177);
            groupBox_Detail.TabIndex = 1;
            groupBox_Detail.TabStop = false;
            groupBox_Detail.Text = "Detail";
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.Silver;
            button_cancel.Location = new Point(402, 137);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(100, 34);
            button_cancel.TabIndex = 14;
            button_cancel.Text = "cancel";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button3_Click;
            // 
            // button_save
            // 
            button_save.BackColor = Color.Silver;
            button_save.Location = new Point(285, 138);
            button_save.Name = "button_save";
            button_save.Size = new Size(100, 34);
            button_save.TabIndex = 13;
            button_save.Text = "save";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // cbx_status
            // 
            cbx_status.FormattingEnabled = true;
            cbx_status.Location = new Point(79, 139);
            cbx_status.Name = "cbx_status";
            cbx_status.Size = new Size(141, 33);
            cbx_status.TabIndex = 12;
            // 
            // label_Status
            // 
            label_Status.AutoSize = true;
            label_Status.Location = new Point(13, 146);
            label_Status.Name = "label_Status";
            label_Status.Size = new Size(60, 25);
            label_Status.TabIndex = 11;
            label_Status.Text = "Status";
            // 
            // nUD_UnitStok
            // 
            nUD_UnitStok.Location = new Point(410, 73);
            nUD_UnitStok.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nUD_UnitStok.Name = "nUD_UnitStok";
            nUD_UnitStok.Size = new Size(108, 31);
            nUD_UnitStok.TabIndex = 10;
            // 
            // nUD_prince
            // 
            nUD_prince.Location = new Point(410, 30);
            nUD_prince.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nUD_prince.Name = "nUD_prince";
            nUD_prince.Size = new Size(108, 31);
            nUD_prince.TabIndex = 6;
            nUD_prince.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label_unitStok
            // 
            label_unitStok.AutoSize = true;
            label_unitStok.Location = new Point(328, 78);
            label_unitStok.Name = "label_unitStok";
            label_unitStok.Size = new Size(84, 25);
            label_unitStok.TabIndex = 9;
            label_unitStok.Text = "Unit Stok";
            // 
            // label_prince
            // 
            label_prince.AutoSize = true;
            label_prince.Location = new Point(328, 30);
            label_prince.Name = "label_prince";
            label_prince.Size = new Size(86, 25);
            label_prince.TabIndex = 8;
            label_prince.Text = "Price/unit";
            // 
            // label_nama
            // 
            label_nama.AutoSize = true;
            label_nama.Location = new Point(3, 27);
            label_nama.Name = "label_nama";
            label_nama.Size = new Size(56, 25);
            label_nama.TabIndex = 7;
            label_nama.Text = "nama";
            label_nama.Click += label5_Click;
            // 
            // check_Measurable
            // 
            check_Measurable.AutoSize = true;
            check_Measurable.Location = new Point(285, 111);
            check_Measurable.Name = "check_Measurable";
            check_Measurable.Size = new Size(182, 29);
            check_Measurable.TabIndex = 6;
            check_Measurable.Text = "Measurable(kg/ltr)";
            check_Measurable.UseVisualStyleBackColor = true;
            // 
            // check_countable
            // 
            check_countable.AutoSize = true;
            check_countable.Location = new Point(105, 111);
            check_countable.Name = "check_countable";
            check_countable.Size = new Size(153, 29);
            check_countable.TabIndex = 5;
            check_countable.Text = "countable(pcs)";
            check_countable.UseVisualStyleBackColor = true;
            // 
            // label_unitType
            // 
            label_unitType.AutoSize = true;
            label_unitType.Location = new Point(7, 111);
            label_unitType.Name = "label_unitType";
            label_unitType.Size = new Size(86, 25);
            label_unitType.TabIndex = 4;
            label_unitType.Text = "Unit Type";
            // 
            // comboBox_categories
            // 
            comboBox_categories.FormattingEnabled = true;
            comboBox_categories.Location = new Point(105, 70);
            comboBox_categories.Name = "comboBox_categories";
            comboBox_categories.Size = new Size(182, 33);
            comboBox_categories.TabIndex = 3;
            comboBox_categories.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // text_detailNama
            // 
            text_detailNama.Location = new Point(105, 24);
            text_detailNama.Name = "text_detailNama";
            text_detailNama.Size = new Size(182, 31);
            text_detailNama.TabIndex = 2;
            // 
            // label_categories
            // 
            label_categories.AutoSize = true;
            label_categories.Location = new Point(0, 73);
            label_categories.Name = "label_categories";
            label_categories.Size = new Size(93, 25);
            label_categories.TabIndex = 1;
            label_categories.Text = "categories";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 27);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // groupBox_transactional
            // 
            groupBox_transactional.Controls.Add(label_delevery);
            groupBox_transactional.Controls.Add(label_totaTransaksi);
            groupBox_transactional.Controls.Add(NUP_quantity);
            groupBox_transactional.Controls.Add(button2);
            groupBox_transactional.Controls.Add(button_Buy);
            groupBox_transactional.Controls.Add(label_deleverycost);
            groupBox_transactional.Controls.Add(label_total);
            groupBox_transactional.Controls.Add(label_quantity);
            groupBox_transactional.Location = new Point(599, 364);
            groupBox_transactional.Name = "groupBox_transactional";
            groupBox_transactional.Size = new Size(344, 150);
            groupBox_transactional.TabIndex = 10;
            groupBox_transactional.TabStop = false;
            groupBox_transactional.Text = "Transactional Area";
            // 
            // label_delevery
            // 
            label_delevery.AutoSize = true;
            label_delevery.Location = new Point(134, 102);
            label_delevery.Name = "label_delevery";
            label_delevery.Size = new Size(59, 25);
            label_delevery.TabIndex = 7;
            label_delevery.Text = "label4";
            // 
            // label_totaTransaksi
            // 
            label_totaTransaksi.AutoSize = true;
            label_totaTransaksi.Location = new Point(83, 65);
            label_totaTransaksi.Name = "label_totaTransaksi";
            label_totaTransaksi.Size = new Size(59, 25);
            label_totaTransaksi.TabIndex = 6;
            label_totaTransaksi.Text = "label3";
            label_totaTransaksi.Click += label3_Click;
            // 
            // NUP_quantity
            // 
            NUP_quantity.Location = new Point(82, 30);
            NUP_quantity.Name = "NUP_quantity";
            NUP_quantity.Size = new Size(116, 31);
            NUP_quantity.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(204, 67);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button_Buy
            // 
            button_Buy.BackColor = Color.Silver;
            button_Buy.Location = new Point(204, 27);
            button_Buy.Name = "button_Buy";
            button_Buy.Size = new Size(112, 34);
            button_Buy.TabIndex = 3;
            button_Buy.Text = "Buy Item";
            button_Buy.UseVisualStyleBackColor = false;
            button_Buy.Click += button_Buy_Click;
            // 
            // label_deleverycost
            // 
            label_deleverycost.AutoSize = true;
            label_deleverycost.Location = new Point(6, 102);
            label_deleverycost.Name = "label_deleverycost";
            label_deleverycost.Size = new Size(122, 25);
            label_deleverycost.TabIndex = 2;
            label_deleverycost.Text = "Delivery cost :";
            // 
            // label_total
            // 
            label_total.AutoSize = true;
            label_total.Location = new Point(6, 67);
            label_total.Name = "label_total";
            label_total.Size = new Size(58, 25);
            label_total.TabIndex = 1;
            label_total.Text = "Total :";
            // 
            // label_quantity
            // 
            label_quantity.AutoSize = true;
            label_quantity.Location = new Point(3, 27);
            label_quantity.Name = "label_quantity";
            label_quantity.Size = new Size(80, 25);
            label_quantity.TabIndex = 0;
            label_quantity.Text = "Quantity";
            // 
            // b_AddItem
            // 
            b_AddItem.BackColor = Color.Silver;
            b_AddItem.Location = new Point(305, 303);
            b_AddItem.Name = "b_AddItem";
            b_AddItem.Size = new Size(112, 34);
            b_AddItem.TabIndex = 6;
            b_AddItem.Text = "Add Item";
            b_AddItem.UseVisualStyleBackColor = false;
            b_AddItem.Click += b_AddItem_Click;
            // 
            // b_EditItem
            // 
            b_EditItem.BackColor = Color.FromArgb(224, 224, 224);
            b_EditItem.Location = new Point(435, 303);
            b_EditItem.Name = "b_EditItem";
            b_EditItem.Size = new Size(112, 34);
            b_EditItem.TabIndex = 7;
            b_EditItem.Text = "Edit Item";
            b_EditItem.UseVisualStyleBackColor = false;
            b_EditItem.Click += b_EditItem_Click;
            // 
            // b_DeleteItem
            // 
            b_DeleteItem.BackColor = Color.Silver;
            b_DeleteItem.Location = new Point(559, 303);
            b_DeleteItem.Name = "b_DeleteItem";
            b_DeleteItem.Size = new Size(112, 34);
            b_DeleteItem.TabIndex = 8;
            b_DeleteItem.Text = "Delete Item";
            b_DeleteItem.UseVisualStyleBackColor = false;
            b_DeleteItem.Click += b_DeleteItem_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 8F);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(83, 34);
            button1.TabIndex = 11;
            button1.Text = "kembali";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(955, 536);
            Controls.Add(button1);
            Controls.Add(b_AddItem);
            Controls.Add(b_EditItem);
            Controls.Add(b_DeleteItem);
            Controls.Add(groupBox_transactional);
            Controls.Add(groupBox_Detail);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_product).EndInit();
            groupBox_Detail.ResumeLayout(false);
            groupBox_Detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_UnitStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_prince).EndInit();
            groupBox_transactional.ResumeLayout(false);
            groupBox_transactional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUP_quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgv_product;
        private GroupBox groupBox_Detail;
        private Label label_categories;
        private Label label2;
        private CheckBox check_Measurable;
        private CheckBox check_countable;
        private Label label_unitType;
        private ComboBox comboBox_categories;
        private TextBox text_detailNama;
        private Label label_unitStok;
        private Label label_prince;
        private Label label_nama;
        private GroupBox groupBox_transactional;
        private Label label_quantity;
        private Label label_total;
        private Button button2;
        private Button button_Buy;
        private Label label_deleverycost;
        private NumericUpDown nUD_prince;
        private NumericUpDown NUP_quantity;
        private NumericUpDown nUD_UnitStok;
        private Button b_AddItem;
        private Button b_EditItem;
        private Button b_DeleteItem;
        private Label label_delevery;
        private Label label_totaTransaksi;
        private Button button_save;
        private ComboBox cbx_status;
        private Label label_Status;
        private Button button_cancel;
        private Button button1;
    }
}