using MainForm.Classes.Cinema;
using MainForm.Classes.UserClasses;
using MainForm.Enums;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace MainForm
{
    public partial class GuestForm : Form
    {
        Guest guest;
        SessionList sessions;
        UserList users;

        public GuestForm(SessionList sessions, UserList users)
        {
            InitializeComponent();
            this.sessions = sessions;
            this.users = users;
            guest = new Guest();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            Session session1 = new Session(DateTime.Today, "Film 1", Halls.FirstHall, new TimeSpan(10, 0, 0));
            Session session2 = new Session(DateTime.Now.Date, "Film 2", Halls.SecondHall, new TimeSpan(13, 0, 0));
            Session session3 = new Session(DateTime.Now.Date, "Film 3", Halls.ThirdHall, new TimeSpan(16, 0, 0));

            //sessions.AddSession(session1);
            //sessions.AddSession(session2);
            //sessions.AddSession(session3);
            
            try
            {
                DateTime selectedDate = datePickerForViewSession.Value;

                bool isVIewed = guest.ViewSessions(selectedDate, sessions, SessionlistBox);
                if (!isVIewed)
                {
                    MessageBox.Show("Cannot view sessions for the selected date.");
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(guest, users);
            registrationForm.Show();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(guest, users,sessions);
            loginForm.Show();
            
        }
      
    }
}
