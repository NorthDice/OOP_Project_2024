using MainForm.Classes.Cinema;
using MainForm.Classes.UserClasses;
using MainForm.Enums;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MainForm
{
    public partial class LoginForm : Form
    {
        Guest guest;
        UserList users;
        SessionList sessions;

        public LoginForm(Guest guest, UserList users, SessionList sessions)
        {
            this.users = users;
            this.guest = guest;
            this.sessions = sessions;

            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {

                string guestLogin = textBoxLogin.Text;
                string guestPassword = textBoxPassword.Text;


                bool isTrue = guest.SignUp(guestLogin, guestPassword, users);
                Classes.UserClasses.User currentUser = CurrentUserManager.GetCurrentUser();
                Debug.WriteLine(currentUser);

                if (isTrue)
                {

                    if (currentUser.UserRole == Role.RegistredUser)
                    {
                        CloseForm(this);
                        RegistredUser registeredUser = (RegistredUser)currentUser;
                        RegistredUserForm registred = new RegistredUserForm(sessions);
                        registred.Show();
                    }
                    else //if(currentUser.UserRole == Role.Admin)
                    {

                        CloseForm(this);
                        AdminForm adminForm = new AdminForm(sessions, users);
                        Admin admin = (Admin)CurrentUserManager.GetCurrentUser();// = (Admin)currentUser;
                        adminForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Logining failed! \n Please check your login & password and try again!");
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

        private void CloseForm(Form formToClose)
        {
            formToClose.Close();
        }
    }
}