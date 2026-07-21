namespace DESKTOP_I__5CG9241T2M_
{
    partial class FormCreateAkun
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
            label2 = new Label();
            label3 = new Label();
            t_phoneNumber = new TextBox();
            t_Email = new TextBox();
            label4 = new Label();
            label5 = new Label();
            t_password = new TextBox();
            t_confirmPassword = new TextBox();
            label6 = new Label();
            check_customer = new CheckBox();
            check_vendor = new CheckBox();
            groupBox1 = new GroupBox();
            r_custAddress = new RichTextBox();
            t_custLongitude = new TextBox();
            t_custLatitude = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            t_custName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            r_vendorAddress = new RichTextBox();
            t_vendorLongitude = new TextBox();
            t_vendorLatitude = new TextBox();
            t_vendorName = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            button1 = new Button();
            label17 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 37);
            label1.Name = "label1";
            label1.Size = new Size(361, 30);
            label1.TabIndex = 0;
            label1.Text = "Join Us By Filling Some Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 87);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 1;
            label2.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 134);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // t_phoneNumber
            // 
            t_phoneNumber.Location = new Point(159, 81);
            t_phoneNumber.Name = "t_phoneNumber";
            t_phoneNumber.Size = new Size(150, 31);
            t_phoneNumber.TabIndex = 3;
            // 
            // t_Email
            // 
            t_Email.Location = new Point(159, 128);
            t_Email.Name = "t_Email";
            t_Email.Size = new Size(150, 31);
            t_Email.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 81);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(397, 128);
            label5.Name = "label5";
            label5.Size = new Size(156, 25);
            label5.TabIndex = 6;
            label5.Text = "Confirm Password";
            // 
            // t_password
            // 
            t_password.Location = new Point(559, 81);
            t_password.Name = "t_password";
            t_password.Size = new Size(150, 31);
            t_password.TabIndex = 7;
            t_password.TextChanged += textBox3_TextChanged;
            // 
            // t_confirmPassword
            // 
            t_confirmPassword.Location = new Point(559, 128);
            t_confirmPassword.Name = "t_confirmPassword";
            t_confirmPassword.Size = new Size(150, 31);
            t_confirmPassword.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 205);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 9;
            label6.Text = "Role Creation";
            // 
            // check_customer
            // 
            check_customer.AutoSize = true;
            check_customer.Location = new Point(159, 205);
            check_customer.Name = "check_customer";
            check_customer.Size = new Size(115, 29);
            check_customer.TabIndex = 10;
            check_customer.Text = "Customer";
            check_customer.UseVisualStyleBackColor = true;
            // 
            // check_vendor
            // 
            check_vendor.AutoSize = true;
            check_vendor.Location = new Point(294, 205);
            check_vendor.Name = "check_vendor";
            check_vendor.Size = new Size(95, 29);
            check_vendor.TabIndex = 11;
            check_vendor.Text = "Vendor";
            check_vendor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(r_custAddress);
            groupBox1.Controls.Add(t_custLongitude);
            groupBox1.Controls.Add(t_custLatitude);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(t_custName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(39, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 238);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Detail";
            // 
            // r_custAddress
            // 
            r_custAddress.Location = new Point(88, 86);
            r_custAddress.Name = "r_custAddress";
            r_custAddress.Size = new Size(150, 65);
            r_custAddress.TabIndex = 9;
            r_custAddress.Text = "";
            // 
            // t_custLongitude
            // 
            t_custLongitude.Font = new Font("Segoe UI", 6F);
            t_custLongitude.Location = new Point(267, 190);
            t_custLongitude.Name = "t_custLongitude";
            t_custLongitude.Size = new Size(75, 23);
            t_custLongitude.TabIndex = 8;
            // 
            // t_custLatitude
            // 
            t_custLatitude.Font = new Font("Segoe UI", 6F);
            t_custLatitude.Location = new Point(85, 190);
            t_custLatitude.Name = "t_custLatitude";
            t_custLatitude.Size = new Size(75, 23);
            t_custLatitude.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(169, 185);
            label11.Name = "label11";
            label11.Size = new Size(92, 25);
            label11.TabIndex = 6;
            label11.Text = "Longitude";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 185);
            label10.Name = "label10";
            label10.Size = new Size(81, 25);
            label10.TabIndex = 5;
            label10.Text = "Lattitude";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 142);
            label9.Name = "label9";
            label9.Size = new Size(83, 25);
            label9.TabIndex = 4;
            label9.Text = "Location:";
            // 
            // t_custName
            // 
            t_custName.Location = new Point(85, 41);
            t_custName.Name = "t_custName";
            t_custName.Size = new Size(150, 31);
            t_custName.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 79);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 1;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 41);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 0;
            label7.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(r_vendorAddress);
            groupBox2.Controls.Add(t_vendorLongitude);
            groupBox2.Controls.Add(t_vendorLatitude);
            groupBox2.Controls.Add(t_vendorName);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(461, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 238);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Vendor Detail";
            // 
            // r_vendorAddress
            // 
            r_vendorAddress.Location = new Point(100, 88);
            r_vendorAddress.Name = "r_vendorAddress";
            r_vendorAddress.Size = new Size(150, 65);
            r_vendorAddress.TabIndex = 14;
            r_vendorAddress.Text = "";
            r_vendorAddress.TextChanged += richTextBox1_TextChanged;
            // 
            // t_vendorLongitude
            // 
            t_vendorLongitude.Font = new Font("Segoe UI", 6F);
            t_vendorLongitude.Location = new Point(278, 195);
            t_vendorLongitude.Name = "t_vendorLongitude";
            t_vendorLongitude.Size = new Size(81, 23);
            t_vendorLongitude.TabIndex = 8;
            // 
            // t_vendorLatitude
            // 
            t_vendorLatitude.Font = new Font("Segoe UI", 6F);
            t_vendorLatitude.Location = new Point(93, 195);
            t_vendorLatitude.Name = "t_vendorLatitude";
            t_vendorLatitude.Size = new Size(81, 23);
            t_vendorLatitude.TabIndex = 7;
            // 
            // t_vendorName
            // 
            t_vendorName.Location = new Point(98, 30);
            t_vendorName.Name = "t_vendorName";
            t_vendorName.Size = new Size(150, 31);
            t_vendorName.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(180, 190);
            label16.Name = "label16";
            label16.Size = new Size(92, 25);
            label16.TabIndex = 4;
            label16.Text = "Longitude";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 190);
            label15.Name = "label15";
            label15.Size = new Size(81, 25);
            label15.TabIndex = 3;
            label15.Text = "Lattitude";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 142);
            label14.Name = "label14";
            label14.Size = new Size(83, 25);
            label14.TabIndex = 2;
            label14.Text = "Location:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 88);
            label13.Name = "label13";
            label13.Size = new Size(77, 25);
            label13.TabIndex = 1;
            label13.Text = "Address";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 41);
            label12.Name = "label12";
            label12.Size = new Size(59, 25);
            label12.TabIndex = 0;
            label12.Text = "Name";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(364, 563);
            button1.Name = "button1";
            button1.Size = new Size(151, 47);
            button1.TabIndex = 9;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Red;
            label17.Location = new Point(150, 525);
            label17.Name = "label17";
            label17.Size = new Size(542, 25);
            label17.TabIndex = 13;
            label17.Text = "passwod comfirmation doesn\"t match with the impluted password";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.Font = new Font("Segoe UI", 8F);
            button2.Location = new Point(3, 2);
            button2.Name = "button2";
            button2.Size = new Size(73, 34);
            button2.TabIndex = 14;
            button2.Text = "kembali";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormCreateAkun
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(860, 651);
            Controls.Add(button2);
            Controls.Add(label17);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(check_vendor);
            Controls.Add(check_customer);
            Controls.Add(label6);
            Controls.Add(t_confirmPassword);
            Controls.Add(t_password);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(t_Email);
            Controls.Add(t_phoneNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCreateAkun";
            Text = "FormCreateAkun";
            Load += FormCreateAkun_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox t_phoneNumber;
        private TextBox t_Email;
        private Label label4;
        private Label label5;
        private TextBox t_password;
        private TextBox t_confirmPassword;
        private Label label6;
        private CheckBox check_customer;
        private CheckBox check_vendor;
        private GroupBox groupBox1;
        private TextBox t_custName;
        private Label label8;
        private Label label7;
        private GroupBox groupBox2;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox t_custLatitude;
        private TextBox t_custLongitude;
        private TextBox t_vendorLongitude;
        private TextBox t_vendorLatitude;
        private TextBox t_vendorName;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Button button1;
        private Label label17;
        private RichTextBox r_custAddress;
        private RichTextBox r_vendorAddress;
        private Button button2;
    }
}