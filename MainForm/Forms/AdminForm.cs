using MainForm.Classes.Cinema;
using MainForm.Classes.UserClasses;
using MainForm.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MainForm
{
    public partial class AdminForm : Form
    {
        private UserList users;
        private SessionList sessions;
        private Admin admin;

        public AdminForm(SessionList sessions, UserList users)
        {
            InitializeComponent();
            this.sessions = sessions;
            this.users = users;
            admin = new Admin("adminn", "adminn", "Johnss", "Dossse", Role.Admin);
            users.Add(admin);
            sessions.SessionsUpdated += Sessions_Updated;
        }

        private void buttonAddSession_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dateTimePickerDate.Value.Date;
                TimeSpan time = TimeSpan.Parse(textBoxTime.Text);
                DateTime combinedDateTime = date.Add(time);
                string filmName = textBoxFilmName.Text;
                Halls hallNumber = (Halls)Enum.Parse(typeof(Halls), textBoxHall.Text);


                bool isAdded = admin.AddSession(combinedDateTime, time, hallNumber, filmName, sessions);
                if (isAdded)
                {
                    sessions.OnSessionsUpdated(EventArgs.Empty);
                    MessageBox.Show("Session added succesfully!");
                    ClearTextBoxes(textBoxTime, textBoxNewTime, textBoxHall, textBoxFilmName);
                }
                else
                {
                    MessageBox.Show("Session wasn't added!");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonDeleteSession_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dateTimePickerDate.Value.Date;
                TimeSpan time = TimeSpan.Parse(textBoxTime.Text);
                DateTime combinedDateTime = date.Add(time);
                string filmName = textBoxFilmName.Text;
                Halls hallNumber = (Halls)Enum.Parse(typeof(Halls), textBoxHall.Text);


                bool isDeleted = admin.DeleteSession(combinedDateTime, time, hallNumber, filmName, sessions);
                if (isDeleted)
                {
                    sessions.OnSessionsUpdated(EventArgs.Empty);
                    MessageBox.Show("Session deleted succesfully!");
                    ClearTextBoxes(textBoxTime, textBoxNewTime, textBoxHall, textBoxFilmName);
                }
                else
                {
                    MessageBox.Show("Session wasn't deleted!");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEditSession_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime selectedDate = dateTimePickerDate.Value.Date;
                TimeSpan selectedTime = TimeSpan.Parse(textBoxTime.Text);
                DateTime combinedDateTime = selectedDate.Add(selectedTime);
                TimeSpan newTime = TimeSpan.Parse(textBoxNewTime.Text);


                bool isEdited = admin.EditSession(selectedDate, selectedTime, newTime, sessions);

                if (isEdited)
                {
                    sessions.OnSessionsUpdated(EventArgs.Empty);
                    MessageBox.Show("Session edited successfully.");
                    ClearTextBoxes(textBoxTime, textBoxNewTime, textBoxHall, textBoxFilmName);
                }
                else
                {
                    MessageBox.Show("Failed to edit session. Please check the input values.");
                }

            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ClearTextBoxes(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Sessions_Updated(object sender, EventArgs e)
        {
            JsonManager jsonManager = new JsonManager();
            jsonManager.WriteToFile(sessions, @"C:\Visual Studio Projects\OOP_Project_2024_Balychev\json", "sessions.json");
        }


        private void buttonShowSessionList_Click(object sender, EventArgs e)
        {
            SessionListBox.Visible = true;

            DateTime selectedDate = dateTimePickerDate.Value;

            bool isViewed = admin.ViewSessions(selectedDate, sessions, SessionListBox);
            if (!isViewed)
            {
                MessageBox.Show("Cannot view sessions for the selected date.");
            }
        }
    }

}

