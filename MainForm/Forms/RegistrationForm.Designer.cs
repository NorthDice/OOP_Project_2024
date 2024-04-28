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
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
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
            buttonRegistration.Click += buttonRegistration_Click;
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
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(279, 96);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(247, 27);
            textBoxLogin.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(279, 161);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(247, 27);
            textBoxPassword.TabIndex = 6;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(279, 223);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(247, 27);
            textBoxName.TabIndex = 7;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(279, 288);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(247, 27);
            textBoxSurname.TabIndex = 8;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
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
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
    }
}