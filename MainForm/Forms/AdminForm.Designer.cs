namespace MainForm
{
    partial class AdminForm
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
            buttonAddSession = new Button();
            buttonDeleteSession = new Button();
            buttonEditSession = new Button();
            textBoxFilmName = new TextBox();
            textBoxHall = new TextBox();
            textBoxTime = new TextBox();
            labelDate = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePickerDate = new DateTimePicker();
            labelNewTime = new Label();
            textBoxNewTime = new TextBox();
            SessionListBox = new ListBox();
            buttonShowSessionList = new Button();
            SuspendLayout();
            // 
            // buttonAddSession
            // 
            buttonAddSession.BackColor = SystemColors.ControlLight;
            buttonAddSession.FlatAppearance.BorderSize = 0;
            buttonAddSession.FlatStyle = FlatStyle.Flat;
            buttonAddSession.Location = new Point(42, 25);
            buttonAddSession.Name = "buttonAddSession";
            buttonAddSession.Size = new Size(169, 40);
            buttonAddSession.TabIndex = 0;
            buttonAddSession.Text = "AddSession";
            buttonAddSession.UseVisualStyleBackColor = false;
            buttonAddSession.Click += buttonAddSession_Click;
            // 
            // buttonDeleteSession
            // 
            buttonDeleteSession.BackColor = SystemColors.ControlLight;
            buttonDeleteSession.FlatAppearance.BorderSize = 0;
            buttonDeleteSession.FlatStyle = FlatStyle.Flat;
            buttonDeleteSession.Location = new Point(42, 91);
            buttonDeleteSession.Name = "buttonDeleteSession";
            buttonDeleteSession.Size = new Size(169, 42);
            buttonDeleteSession.TabIndex = 1;
            buttonDeleteSession.Text = "DeleteSession";
            buttonDeleteSession.UseVisualStyleBackColor = false;
            buttonDeleteSession.Click += buttonDeleteSession_Click;
            // 
            // buttonEditSession
            // 
            buttonEditSession.BackColor = SystemColors.ControlLight;
            buttonEditSession.FlatAppearance.BorderSize = 0;
            buttonEditSession.FlatStyle = FlatStyle.Flat;
            buttonEditSession.Location = new Point(42, 157);
            buttonEditSession.Name = "buttonEditSession";
            buttonEditSession.Size = new Size(169, 46);
            buttonEditSession.TabIndex = 2;
            buttonEditSession.Text = "EditSession";
            buttonEditSession.UseVisualStyleBackColor = false;
            buttonEditSession.Click += buttonEditSession_Click;
            // 
            // textBoxFilmName
            // 
            textBoxFilmName.BackColor = Color.FromArgb(107, 94, 94);
            textBoxFilmName.BorderStyle = BorderStyle.None;
            textBoxFilmName.Location = new Point(235, 129);
            textBoxFilmName.Name = "textBoxFilmName";
            textBoxFilmName.Size = new Size(189, 20);
            textBoxFilmName.TabIndex = 5;
            // 
            // textBoxHall
            // 
            textBoxHall.BackColor = Color.FromArgb(107, 94, 94);
            textBoxHall.BorderStyle = BorderStyle.None;
            textBoxHall.Location = new Point(508, 127);
            textBoxHall.Name = "textBoxHall";
            textBoxHall.Size = new Size(183, 20);
            textBoxHall.TabIndex = 6;
            // 
            // textBoxTime
            // 
            textBoxTime.BackColor = Color.FromArgb(107, 94, 94);
            textBoxTime.BorderStyle = BorderStyle.None;
            textBoxTime.Location = new Point(508, 54);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(183, 20);
            textBoxTime.TabIndex = 7;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(298, 18);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(41, 20);
            labelDate.TabIndex = 8;
            labelDate.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(576, 18);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 9;
            label2.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(298, 91);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 10;
            label3.Text = "Film Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(576, 91);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 11;
            label4.Text = "Hall";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.CalendarForeColor = Color.FromArgb(107, 94, 94);
            dateTimePickerDate.CalendarMonthBackground = Color.FromArgb(107, 94, 94);
            dateTimePickerDate.CalendarTitleBackColor = Color.FromArgb(107, 94, 94);
            dateTimePickerDate.CalendarTitleForeColor = Color.FromArgb(107, 94, 94);
            dateTimePickerDate.CalendarTrailingForeColor = Color.FromArgb(107, 94, 94);
            dateTimePickerDate.Location = new Point(235, 54);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(189, 27);
            dateTimePickerDate.TabIndex = 12;
            // 
            // labelNewTime
            // 
            labelNewTime.AutoSize = true;
            labelNewTime.Location = new Point(423, 183);
            labelNewTime.Name = "labelNewTime";
            labelNewTime.Size = new Size(76, 20);
            labelNewTime.TabIndex = 13;
            labelNewTime.Text = "New Time";
            // 
            // textBoxNewTime
            // 
            textBoxNewTime.BackColor = Color.FromArgb(107, 94, 94);
            textBoxNewTime.BorderStyle = BorderStyle.None;
            textBoxNewTime.Location = new Point(360, 215);
            textBoxNewTime.Name = "textBoxNewTime";
            textBoxNewTime.Size = new Size(189, 20);
            textBoxNewTime.TabIndex = 14;
            // 
            // SessionListBox
            // 
            SessionListBox.FormattingEnabled = true;
            SessionListBox.Location = new Point(158, 284);
            SessionListBox.Name = "SessionListBox";
            SessionListBox.Size = new Size(571, 104);
            SessionListBox.TabIndex = 15;
            SessionListBox.Visible = false;
            // 
            // buttonShowSessionList
            // 
            buttonShowSessionList.BackColor = SystemColors.ControlLight;
            buttonShowSessionList.FlatAppearance.BorderSize = 0;
            buttonShowSessionList.FlatStyle = FlatStyle.Flat;
            buttonShowSessionList.Location = new Point(42, 215);
            buttonShowSessionList.Name = "buttonShowSessionList";
            buttonShowSessionList.Size = new Size(169, 50);
            buttonShowSessionList.TabIndex = 18;
            buttonShowSessionList.Text = "Show sesions on date";
            buttonShowSessionList.UseVisualStyleBackColor = false;
            buttonShowSessionList.Click += buttonShowSessionList_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 164, 165);
            ClientSize = new Size(768, 421);
            Controls.Add(buttonShowSessionList);
            Controls.Add(SessionListBox);
            Controls.Add(textBoxNewTime);
            Controls.Add(labelNewTime);
            Controls.Add(dateTimePickerDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelDate);
            Controls.Add(textBoxTime);
            Controls.Add(textBoxHall);
            Controls.Add(textBoxFilmName);
            Controls.Add(buttonEditSession);
            Controls.Add(buttonDeleteSession);
            Controls.Add(buttonAddSession);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddSession;
        private Button buttonDeleteSession;
        private Button buttonEditSession;
        private TextBox textBoxFilmName;
        private TextBox textBoxHall;
        private TextBox textBoxTime;
        private Label labelDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePickerDate;
        private Label labelNewTime;
        private TextBox textBoxNewTime;
        private ListBox SessionListBox;
        private Button buttonShowSessionList;
    }
}