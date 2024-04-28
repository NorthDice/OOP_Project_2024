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
            textBoxPassword.Location = new Point(327, 128);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(247, 27);
            textBoxPassword.TabIndex = 16;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(327, 66);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(247, 27);
            textBoxLogin.TabIndex = 15;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(226, 135);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 11;
            labelPassword.Text = "Password";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(226, 73);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(46, 20);
            labelLogin.TabIndex = 10;
            labelLogin.Text = "Login";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(345, 220);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(147, 40);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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