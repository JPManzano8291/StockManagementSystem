namespace StockManagementSystem
{
    partial class loginForm
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
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            cbShowPass = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 74);
            label1.Name = "label1";
            label1.Size = new Size(104, 45);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(149, 193);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(293, 35);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(150, 266);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(292, 35);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(241, 160);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(241, 233);
            label3.Name = "label3";
            label3.Size = new Size(105, 30);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.Highlight;
            btnLogin.Location = new Point(149, 349);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(136, 37);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.Location = new Point(150, 307);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(108, 19);
            cbShowPass.TabIndex = 6;
            cbShowPass.Text = "Show Password";
            cbShowPass.UseVisualStyleBackColor = true;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(306, 349);
            button1.Name = "button1";
            button1.Size = new Size(136, 37);
            button1.TabIndex = 7;
            button1.Text = "Add User";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAdd;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(598, 450);
            Controls.Add(button1);
            Controls.Add(cbShowPass);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            FormClosing += loginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private CheckBox cbShowPass;
        private Button button1;
    }
}
