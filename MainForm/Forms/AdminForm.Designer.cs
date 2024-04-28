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
            SuspendLayout();
            // 
            // buttonAddSession
            // 
            buttonAddSession.Location = new Point(42, 61);
            buttonAddSession.Name = "buttonAddSession";
            buttonAddSession.Size = new Size(138, 56);
            buttonAddSession.TabIndex = 0;
            buttonAddSession.Text = "AddSession";
            buttonAddSession.UseVisualStyleBackColor = true;
            buttonAddSession.Click += buttonAddSession_Click;
            // 
            // buttonDeleteSession
            // 
            buttonDeleteSession.Location = new Point(42, 151);
            buttonDeleteSession.Name = "buttonDeleteSession";
            buttonDeleteSession.Size = new Size(138, 57);
            buttonDeleteSession.TabIndex = 1;
            buttonDeleteSession.Text = "DeleteSession";
            buttonDeleteSession.UseVisualStyleBackColor = true;
            buttonDeleteSession.Click += buttonDeleteSession_Click;
            // 
            // buttonEditSession
            // 
            buttonEditSession.Location = new Point(42, 247);
            buttonEditSession.Name = "buttonEditSession";
            buttonEditSession.Size = new Size(138, 56);
            buttonEditSession.TabIndex = 2;
            buttonEditSession.Text = "EditSession";
            buttonEditSession.UseVisualStyleBackColor = true;
            buttonEditSession.Click += buttonEditSession_Click;
            // 
            // textBoxFilmName
            // 
            textBoxFilmName.Location = new Point(235, 207);
            textBoxFilmName.Name = "textBoxFilmName";
            textBoxFilmName.Size = new Size(189, 27);
            textBoxFilmName.TabIndex = 5;
            // 
            // textBoxHall
            // 
            textBoxHall.Location = new Point(508, 205);
            textBoxHall.Name = "textBoxHall";
            textBoxHall.Size = new Size(183, 27);
            textBoxHall.TabIndex = 6;
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(508, 97);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(183, 27);
            textBoxTime.TabIndex = 7;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(298, 61);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(41, 20);
            labelDate.TabIndex = 8;
            labelDate.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(576, 61);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 9;
            label2.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(298, 169);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 10;
            label3.Text = "Film Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(576, 169);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 11;
            label4.Text = "Hall";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(235, 97);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(189, 27);
            dateTimePickerDate.TabIndex = 12;
            // 
            // labelNewTime
            // 
            labelNewTime.AutoSize = true;
            labelNewTime.Location = new Point(298, 265);
            labelNewTime.Name = "labelNewTime";
            labelNewTime.Size = new Size(76, 20);
            labelNewTime.TabIndex = 13;
            labelNewTime.Text = "New Time";
            // 
            // textBoxNewTime
            // 
            textBoxNewTime.Location = new Point(235, 303);
            textBoxNewTime.Name = "textBoxNewTime";
            textBoxNewTime.Size = new Size(189, 27);
            textBoxNewTime.TabIndex = 14;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
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
    }
}