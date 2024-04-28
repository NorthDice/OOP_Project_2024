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
            buttonRegistration.BackColor = SystemColors.ControlLight;
            buttonRegistration.FlatAppearance.BorderSize = 0;
            buttonRegistration.FlatStyle = FlatStyle.Flat;
            buttonRegistration.ForeColor = SystemColors.WindowText;
            buttonRegistration.Location = new Point(218, 291);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(165, 51);
            buttonRegistration.TabIndex = 0;
            buttonRegistration.Text = "Registration";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(82, 40);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(46, 20);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(82, 102);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(82, 164);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 3;
            labelName.Text = "Name";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(82, 229);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(67, 20);
            labelSurname.TabIndex = 4;
            labelSurname.Text = "Surname";
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.FromArgb(107, 94, 94);
            textBoxLogin.BorderStyle = BorderStyle.None;
            textBoxLogin.Location = new Point(183, 37);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(247, 20);
            textBoxLogin.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(107, 94, 94);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Location = new Point(183, 102);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(247, 20);
            textBoxPassword.TabIndex = 6;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.FromArgb(107, 94, 94);
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Location = new Point(183, 164);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(247, 20);
            textBoxName.TabIndex = 7;
            // 
            // textBoxSurname
            // 
            textBoxSurname.BackColor = Color.FromArgb(107, 94, 94);
            textBoxSurname.BorderStyle = BorderStyle.None;
            textBoxSurname.Location = new Point(183, 229);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(247, 20);
            textBoxSurname.TabIndex = 8;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 164, 165);
            ClientSize = new Size(576, 366);
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