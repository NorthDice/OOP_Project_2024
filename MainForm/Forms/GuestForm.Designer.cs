namespace MainForm
{
    partial class GuestForm
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
            datePickerForViewSession = new DateTimePicker();
            buttonView = new Button();
            buttonSignUp = new Button();
            buttonRegistration = new Button();
            SessionlistBox = new ListBox();
            SuspendLayout();
            // 
            // datePickerForViewSession
            // 
            datePickerForViewSession.Location = new Point(322, 38);
            datePickerForViewSession.Name = "datePickerForViewSession";
            datePickerForViewSession.Size = new Size(283, 27);
            datePickerForViewSession.TabIndex = 0;
            // 
            // buttonView
            // 
            buttonView.Location = new Point(12, 117);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(147, 57);
            buttonView.TabIndex = 1;
            buttonView.Text = "View Session";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += buttonView_Click;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(12, 190);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(147, 56);
            buttonSignUp.TabIndex = 2;
            buttonSignUp.Text = "Login";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // buttonRegistration
            // 
            buttonRegistration.Location = new Point(12, 269);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(147, 51);
            buttonRegistration.TabIndex = 3;
            buttonRegistration.Text = "Registration";
            buttonRegistration.UseVisualStyleBackColor = true;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // SessionlistBox
            // 
            SessionlistBox.FormattingEnabled = true;
            SessionlistBox.Location = new Point(188, 96);
            SessionlistBox.Name = "SessionlistBox";
            SessionlistBox.Size = new Size(588, 264);
            SessionlistBox.TabIndex = 4;
            // 
            // GuestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SessionlistBox);
            Controls.Add(buttonRegistration);
            Controls.Add(buttonSignUp);
            Controls.Add(buttonView);
            Controls.Add(datePickerForViewSession);
            Name = "GuestForm";
            Text = "Guest Form";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker datePickerForViewSession;
        private Button buttonView;
        private Button buttonSignUp;
        private Button buttonRegistration;
        private ListBox SessionlistBox;
    }
}
