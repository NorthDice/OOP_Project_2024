namespace MainForm
{
    partial class RegistredUserForm
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
            buttonViewSession = new Button();
            buttonBuy = new Button();
            buttonReturn = new Button();
            dateTimePickerForSession = new DateTimePicker();
            SessionlistBox = new ListBox();
            textBoxTime = new TextBox();
            textBoxFilmName = new TextBox();
            textBoxHall = new TextBox();
            labelTime = new Label();
            labelFilmName = new Label();
            labelHall = new Label();
            SuspendLayout();
            // 
            // buttonViewSession
            // 
            buttonViewSession.BackColor = SystemColors.ControlLight;
            buttonViewSession.FlatAppearance.BorderSize = 0;
            buttonViewSession.FlatStyle = FlatStyle.Flat;
            buttonViewSession.Location = new Point(25, 53);
            buttonViewSession.Name = "buttonViewSession";
            buttonViewSession.Size = new Size(124, 29);
            buttonViewSession.TabIndex = 0;
            buttonViewSession.Text = "View Sessions";
            buttonViewSession.UseVisualStyleBackColor = false;
            buttonViewSession.Click += buttonViewSession_Click;
            // 
            // buttonBuy
            // 
            buttonBuy.BackColor = SystemColors.ControlLight;
            buttonBuy.FlatAppearance.BorderSize = 0;
            buttonBuy.FlatStyle = FlatStyle.Flat;
            buttonBuy.ForeColor = SystemColors.ActiveCaptionText;
            buttonBuy.Location = new Point(25, 218);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(114, 29);
            buttonBuy.TabIndex = 1;
            buttonBuy.Text = "Buy ticket";
            buttonBuy.UseVisualStyleBackColor = false;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // buttonReturn
            // 
            buttonReturn.BackColor = SystemColors.ControlLight;
            buttonReturn.FlatAppearance.BorderSize = 0;
            buttonReturn.FlatStyle = FlatStyle.Flat;
            buttonReturn.Location = new Point(25, 276);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(114, 29);
            buttonReturn.TabIndex = 2;
            buttonReturn.Text = "Return ticket";
            buttonReturn.UseVisualStyleBackColor = false;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // dateTimePickerForSession
            // 
            dateTimePickerForSession.Location = new Point(316, 52);
            dateTimePickerForSession.Name = "dateTimePickerForSession";
            dateTimePickerForSession.Size = new Size(250, 27);
            dateTimePickerForSession.TabIndex = 3;
            // 
            // SessionlistBox
            // 
            SessionlistBox.FormattingEnabled = true;
            SessionlistBox.Location = new Point(207, 218);
            SessionlistBox.Name = "SessionlistBox";
            SessionlistBox.Size = new Size(519, 184);
            SessionlistBox.TabIndex = 4;
            // 
            // textBoxTime
            // 
            textBoxTime.BackColor = Color.FromArgb(107, 94, 94);
            textBoxTime.BorderStyle = BorderStyle.None;
            textBoxTime.Location = new Point(207, 137);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(125, 20);
            textBoxTime.TabIndex = 6;
            // 
            // textBoxFilmName
            // 
            textBoxFilmName.BackColor = Color.FromArgb(107, 94, 94);
            textBoxFilmName.BorderStyle = BorderStyle.None;
            textBoxFilmName.Location = new Point(361, 137);
            textBoxFilmName.Name = "textBoxFilmName";
            textBoxFilmName.Size = new Size(125, 20);
            textBoxFilmName.TabIndex = 7;
            // 
            // textBoxHall
            // 
            textBoxHall.BackColor = Color.FromArgb(107, 94, 94);
            textBoxHall.BorderStyle = BorderStyle.None;
            textBoxHall.Location = new Point(516, 137);
            textBoxHall.Name = "textBoxHall";
            textBoxHall.Size = new Size(125, 20);
            textBoxHall.TabIndex = 8;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(237, 105);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(42, 20);
            labelTime.TabIndex = 10;
            labelTime.Text = "Time";
            // 
            // labelFilmName
            // 
            labelFilmName.AutoSize = true;
            labelFilmName.Location = new Point(388, 105);
            labelFilmName.Name = "labelFilmName";
            labelFilmName.Size = new Size(78, 20);
            labelFilmName.TabIndex = 11;
            labelFilmName.Text = "Film name";
            // 
            // labelHall
            // 
            labelHall.AutoSize = true;
            labelHall.Location = new Point(546, 105);
            labelHall.Name = "labelHall";
            labelHall.Size = new Size(36, 20);
            labelHall.TabIndex = 12;
            labelHall.Text = "Hall";
            // 
            // RegistredUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 164, 165);
            ClientSize = new Size(800, 450);
            Controls.Add(labelHall);
            Controls.Add(labelFilmName);
            Controls.Add(labelTime);
            Controls.Add(textBoxHall);
            Controls.Add(textBoxFilmName);
            Controls.Add(textBoxTime);
            Controls.Add(SessionlistBox);
            Controls.Add(dateTimePickerForSession);
            Controls.Add(buttonReturn);
            Controls.Add(buttonBuy);
            Controls.Add(buttonViewSession);
            Name = "RegistredUserForm";
            Text = "RegistredUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonViewSession;
        private Button buttonBuy;
        private Button buttonReturn;
        private DateTimePicker dateTimePickerForSession;
        private ListBox SessionlistBox;
        private TextBox textBoxTime;
        private TextBox textBoxFilmName;
        private TextBox textBoxHall;
        private Label labelTime;
        private Label labelFilmName;
        private Label labelHall;
    }
}