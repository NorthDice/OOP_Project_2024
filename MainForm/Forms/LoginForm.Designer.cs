namespace MainForm
{
    partial class LoginForm
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
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            labelPassword = new Label();
            labelLogin = new Label();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(107, 94, 94);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Location = new Point(142, 99);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(247, 20);
            textBoxPassword.TabIndex = 16;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(107, 94, 94);
            textBoxLogin.BorderStyle = BorderStyle.None;
            textBoxLogin.Location = new Point(142, 37);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(247, 20);
            textBoxLogin.TabIndex = 15;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(41, 106);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 11;
            labelPassword.Text = "Password";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(41, 44);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(46, 20);
            labelLogin.TabIndex = 10;
            labelLogin.Text = "Login";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ControlLight;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Location = new Point(160, 191);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(147, 40);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 164, 165);
            ClientSize = new Size(458, 256);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(buttonLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private TextBox textBox1;
        private Label labelSurname;
        private Label labelName;
        private Label labelPassword;
        private Label labelLogin;
        private Button buttonLogin;
    }
}