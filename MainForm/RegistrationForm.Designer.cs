namespace MainForm
{
    partial class RegistrationForm
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
            buttonRegistration = new Button();
            labelLogin = new Label();
            labelPassword = new Label();
            labelName = new Label();
            labelSurname = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // buttonRegistration
            // 
            buttonRegistration.Location = new Point(322, 371);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(147, 40);
            buttonRegistration.TabIndex = 0;
            buttonRegistration.Text = "Registration";
            buttonRegistration.UseVisualStyleBackColor = true;
            buttonRegistration.Click += button1_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(178, 99);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(46, 20);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(178, 161);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(178, 223);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 3;
            labelName.Text = "Name";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(178, 288);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(67, 20);
            labelSurname.TabIndex = 4;
            labelSurname.Text = "Surname";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(279, 281);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(279, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(279, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(247, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(279, 216);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(247, 27);
            textBox4.TabIndex = 8;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(buttonRegistration);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRegistration;
        private Label labelLogin;
        private Label labelPassword;
        private Label labelName;
        private Label labelSurname;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}