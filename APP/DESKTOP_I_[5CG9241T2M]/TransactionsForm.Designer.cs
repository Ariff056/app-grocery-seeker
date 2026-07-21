namespace DESKTOP_I__5CG9241T2M_
{
    partial class TransactionsForm
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
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            DGV_pending = new DataGridView();
            groupBox3 = new GroupBox();
            button_Decline = new Button();
            button_Approve = new Button();
            button_cabcelTransaktions = new Button();
            label_DeliveryCost = new Label();
            label_TotalTransaksi = new Label();
            label11 = new Label();
            label10 = new Label();
            label_pricePerUnit = new Label();
            label_Quantity = new Label();
            label_VendorName = new Label();
            label_productName = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_pending).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(357, 26);
            label1.Name = "label1";
            label1.Size = new Size(185, 38);
            label1.TabIndex = 0;
            label1.Text = "Transactoins";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(36, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(917, 201);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "History";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(911, 171);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DGV_pending);
            groupBox2.Location = new Point(42, 283);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(911, 150);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pending";
            // 
            // DGV_pending
            // 
            DGV_pending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_pending.Location = new Point(6, 30);
            DGV_pending.Name = "DGV_pending";
            DGV_pending.RowHeadersWidth = 62;
            DGV_pending.Size = new Size(899, 120);
            DGV_pending.TabIndex = 0;
            DGV_pending.CellClick += DGV_pending_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button_Decline);
            groupBox3.Controls.Add(button_Approve);
            groupBox3.Controls.Add(button_cabcelTransaktions);
            groupBox3.Controls.Add(label_DeliveryCost);
            groupBox3.Controls.Add(label_TotalTransaksi);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label_pricePerUnit);
            groupBox3.Controls.Add(label_Quantity);
            groupBox3.Controls.Add(label_VendorName);
            groupBox3.Controls.Add(label_productName);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(139, 439);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(745, 189);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detail";
            // 
            // button_Decline
            // 
            button_Decline.BackColor = Color.FromArgb(224, 224, 224);
            button_Decline.Font = new Font("Segoe UI", 11F);
            button_Decline.Location = new Point(584, 126);
            button_Decline.Name = "button_Decline";
            button_Decline.Size = new Size(112, 40);
            button_Decline.TabIndex = 14;
            button_Decline.Text = "Decline";
            button_Decline.UseVisualStyleBackColor = false;
            button_Decline.Click += button_Decline_Click;
            // 
            // button_Approve
            // 
            button_Approve.BackColor = Color.FromArgb(224, 224, 224);
            button_Approve.Font = new Font("Segoe UI", 11F);
            button_Approve.Location = new Point(584, 40);
            button_Approve.Name = "button_Approve";
            button_Approve.Size = new Size(112, 47);
            button_Approve.TabIndex = 13;
            button_Approve.Text = "Approve";
            button_Approve.UseVisualStyleBackColor = false;
            button_Approve.Click += button_Approve_Click;
            // 
            // button_cabcelTransaktions
            // 
            button_cabcelTransaktions.BackColor = Color.FromArgb(224, 224, 224);
            button_cabcelTransaktions.Location = new Point(564, 80);
            button_cabcelTransaktions.Name = "button_cabcelTransaktions";
            button_cabcelTransaktions.Size = new Size(152, 63);
            button_cabcelTransaktions.TabIndex = 12;
            button_cabcelTransaktions.Text = "CANCEL TRANSACTIONS";
            button_cabcelTransaktions.UseVisualStyleBackColor = false;
            button_cabcelTransaktions.Click += button_cabcelTransaktions_Click;
            // 
            // label_DeliveryCost
            // 
            label_DeliveryCost.AutoSize = true;
            label_DeliveryCost.Location = new Point(478, 135);
            label_DeliveryCost.Name = "label_DeliveryCost";
            label_DeliveryCost.Size = new Size(69, 25);
            label_DeliveryCost.TabIndex = 11;
            label_DeliveryCost.Text = "label13";
            label_DeliveryCost.Click += label13_Click;
            // 
            // label_TotalTransaksi
            // 
            label_TotalTransaksi.AutoSize = true;
            label_TotalTransaksi.Location = new Point(478, 94);
            label_TotalTransaksi.Name = "label_TotalTransaksi";
            label_TotalTransaksi.Size = new Size(69, 25);
            label_TotalTransaksi.TabIndex = 10;
            label_TotalTransaksi.Text = "label12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(359, 135);
            label11.Name = "label11";
            label11.Size = new Size(113, 25);
            label11.TabIndex = 9;
            label11.Text = "Delivery cost";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(348, 94);
            label10.Name = "label10";
            label10.Size = new Size(124, 25);
            label10.TabIndex = 8;
            label10.Text = "Total Transaksi";
            // 
            // label_pricePerUnit
            // 
            label_pricePerUnit.AutoSize = true;
            label_pricePerUnit.Location = new Point(188, 152);
            label_pricePerUnit.Name = "label_pricePerUnit";
            label_pricePerUnit.Size = new Size(59, 25);
            label_pricePerUnit.TabIndex = 7;
            label_pricePerUnit.Text = "label9";
            // 
            // label_Quantity
            // 
            label_Quantity.AutoSize = true;
            label_Quantity.Location = new Point(188, 115);
            label_Quantity.Name = "label_Quantity";
            label_Quantity.Size = new Size(59, 25);
            label_Quantity.TabIndex = 6;
            label_Quantity.Text = "label8";
            // 
            // label_VendorName
            // 
            label_VendorName.AutoSize = true;
            label_VendorName.Location = new Point(188, 80);
            label_VendorName.Name = "label_VendorName";
            label_VendorName.Size = new Size(59, 25);
            label_VendorName.TabIndex = 5;
            label_VendorName.Text = "label7";
            // 
            // label_productName
            // 
            label_productName.AutoSize = true;
            label_productName.Location = new Point(188, 52);
            label_productName.Name = "label_productName";
            label_productName.Size = new Size(59, 25);
            label_productName.TabIndex = 4;
            label_productName.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 152);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 3;
            label5.Text = "Price per Unit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 115);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 2;
            label4.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 80);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 1;
            label3.Text = "Vendor Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 52);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 0;
            label2.Text = "Produk Name";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 8F);
            button1.Location = new Point(8, 5);
            button1.Name = "button1";
            button1.Size = new Size(82, 34);
            button1.TabIndex = 3;
            button1.Text = "kembali";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 654);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "TransactionsForm";
            Text = "TransactionsForm";
            Load += TransactionsForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_pending).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private DataGridView DGV_pending;
        private GroupBox groupBox3;
        private Label label_productName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label_DeliveryCost;
        private Label label_TotalTransaksi;
        private Label label11;
        private Label label10;
        private Label label_pricePerUnit;
        private Label label_Quantity;
        private Label label_VendorName;
        private Button button_cabcelTransaktions;
        private Button button_Decline;
        private Button button_Approve;
        private Button button1;
    }
}