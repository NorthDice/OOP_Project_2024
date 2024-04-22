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
            Session session1 = new Session(DateTime.Today, "Film 1", Halls.FirstHall, new TimeSpan(10, 0, 0));
            Session session2 = new Session(DateTime.Now.Date, "Film 2", Halls.SecondHall, new TimeSpan(13, 0, 0));
            Session session3 = new Session(DateTime.Now.Date, "Film 3", Halls.ThirdHall, new TimeSpan(16, 0, 0));

            sessions.AddSession(session1);
            sessions.AddSession(session2);
            sessions.AddSession(session3);

            // Получаем выбранную дату из DateTimePicker
            DateTime selectedDate = dateTimePickerForSession.Value;


            // Вызываем метод ViewSessions для вывода сеансов на экран
            try
            {
                bool success = user.ViewSessions(selectedDate, sessions, SessionlistBox);

                // Если вывод сеансов прошел успешно, обновляем ListBox с информацией о сеансах
                if (success)
                {
                    MessageBox.Show("Sessions viewed successfully.");
                }
                else
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
                Halls selectedHall = (Halls)Enum.Parse(typeof(Halls), textBoxHall.Text);
                string selectedFilm = textBoxFilmName.Text;

           
                bool success = user.BuyTicket(selectedDate, selectedTime, selectedHall, selectedFilm, sessions);

                if (success)
                {
                    MessageBox.Show("Ticket purchased successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to purchase ticket. Please check the details and try again.");
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
                Halls selectedHall = (Halls)Enum.Parse(typeof(Halls), textBoxHall.Text);
                string selectedFilm = textBoxFilmName.Text;

                bool success = user.ReturnTicket(selectedDate, selectedTime, selectedHall, selectedFilm, sessions);

                if (success)
                {
                    MessageBox.Show("Ticket returned successfully!");
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
    }
}
