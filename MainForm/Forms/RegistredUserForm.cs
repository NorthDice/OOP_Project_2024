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
    public partial class RegistredUserForm : Form
    {
        SessionList sessions;
        RegistredUser user;
        public RegistredUserForm(SessionList sessions)
        {
            InitializeComponent();
            this.sessions = sessions;
            user = new RegistredUser("example_login", "examplepassword", "John", "Doe", Role.RegistredUser);
        }

        private void buttonViewSession_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime selectedDate = dateTimePickerForSession.Value;

           
                bool isViewed = user.ViewSessions(selectedDate, sessions, SessionlistBox);

                if (!isViewed)
                {
                    MessageBox.Show("Cannot view sessions for the selected date.");
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime selectedDate = dateTimePickerForSession.Value.Date;
                TimeSpan selectedTime = TimeSpan.Parse(textBoxTime.Text);
                DateTime combinedDateTime = selectedDate.Add(selectedTime);
                Halls selectedHall = (Halls)Enum.Parse(typeof(Halls), textBoxHall.Text);
                string selectedFilm = textBoxFilmName.Text;

           
                bool isBought = user.BuyTicket(combinedDateTime, selectedTime, selectedHall, selectedFilm, sessions);

                if (isBought)
                {
                    MessageBox.Show("Ticket purchased successfully!");
                    ClearTextBoxes(textBoxTime, textBoxHall, textBoxFilmName);
                }
                else
                {
                    MessageBox.Show("Failed to purchase ticket. Please check the details and try again.");
                    ClearTextBoxes(textBoxTime, textBoxHall, textBoxFilmName);
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
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dateTimePickerForSession.Value.Date;
                TimeSpan selectedTime = TimeSpan.Parse(textBoxTime.Text);
                DateTime combinedDateTime = selectedDate.Add(selectedTime);
                Halls selectedHall = (Halls)Enum.Parse(typeof(Halls), textBoxHall.Text);
                string selectedFilm = textBoxFilmName.Text;

                bool isReturned = user.ReturnTicket(combinedDateTime, selectedTime, selectedHall, selectedFilm, sessions);

                if (isReturned)
                {
                    MessageBox.Show("Ticket returned successfully!");
                    ClearTextBoxes(textBoxTime, textBoxHall, textBoxFilmName);
                }
                else
                {
                    MessageBox.Show("Failed to return ticket. Please check the selected session details.");
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

        private void ClearTextBoxes(TextBox textBox1, TextBox textBox2, TextBox textBox3)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
