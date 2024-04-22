using MainForm.Classes.Cinema;
using MainForm.Classes.UserClasses;
using MainForm.Enums;
using System.Windows.Forms;

namespace MainForm
{
    public partial class GuestForm : Form
    {
        SessionList sessions;
        public GuestForm(SessionList sessions)
        {
            InitializeComponent();
            this.sessions = sessions;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            Session session1 = new Session(DateTime.Today, "Film 1", Halls.FirstHall, new TimeSpan(10, 0, 0));
            Session session2 = new Session(DateTime.Now.Date, "Film 2", Halls.SecondHall, new TimeSpan(13, 0, 0));
            Session session3 = new Session(DateTime.Now.Date, "Film 3", Halls.ThirdHall, new TimeSpan(16, 0, 0));
            
            sessions.AddSession(session1);
            sessions.AddSession(session2);
            sessions.AddSession(session3);

            DateTime selectedDate = datePickerForViewSession.Value;

            Guest guest = new Guest();
           
            try
            {
                bool isTrue = guest.ViewSessions(selectedDate, sessions, SessionlistBox);
                if (!isTrue)
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
    }
}
