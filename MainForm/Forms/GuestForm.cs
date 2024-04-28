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
    
            try
            {
                DateTime selectedDate = datePickerForViewSession.Value;

                bool isViewed = guest.ViewSessions(selectedDate, sessions, SessionlistBox);
                if (!isViewed)
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
