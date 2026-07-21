namespace DESKTOP_I__5CG9241T2M_
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tex_Phone = new TextBox();
            tex_Password = new TextBox();
            button1 = new Button();
            com_Login = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 43);
            label1.Name = "label1";
            label1.Size = new Size(171, 34);
            label1.TabIndex = 0;
            label1.Text = "Login Disini";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(138, 108);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 1;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(112, 164);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(117, 229);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 3;
            label4.Text = "Login Us";
            // 
            // tex_Phone
            // 
            tex_Phone.Font = new Font("Segoe UI", 10F);
            tex_Phone.Location = new Point(211, 108);
            tex_Phone.Name = "tex_Phone";
            tex_Phone.Size = new Size(221, 34);
            tex_Phone.TabIndex = 4;
            // 
            // tex_Password
            // 
            tex_Password.Font = new Font("Segoe UI", 10F);
            tex_Password.Location = new Point(211, 164);
            tex_Password.Name = "tex_Password";
            tex_Password.PasswordChar = '*';
            tex_Password.Size = new Size(218, 34);
            tex_Password.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(266, 318);
            button1.Name = "button1";
            button1.Size = new Size(112, 47);
            button1.TabIndex = 7;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // com_Login
            // 
            com_Login.FormattingEnabled = true;
            com_Login.Items.AddRange(new object[] { "Vendor", "Customer" });
            com_Login.Location = new Point(214, 224);
            com_Login.Name = "com_Login";
            com_Login.Size = new Size(182, 33);
            com_Login.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(169, 281);
            label5.Name = "label5";
            label5.Size = new Size(305, 25);
            label5.TabIndex = 9;
            label5.Text = "sorry! we couidn't find you credential";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(183, 381);
            label6.Name = "label6";
            label6.Size = new Size(171, 25);
            label6.TabIndex = 10;
            label6.Text = "don't have account?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(360, 381);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 11;
            label7.Text = "Sign Up";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(669, 491);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(com_Login);
            Controls.Add(button1);
            Controls.Add(tex_Password);
            Controls.Add(tex_Phone);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tex_Phone;
        private TextBox tex_Password;
        private Button button1;
        private ComboBox com_Login;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
