using MainForm.Classes.Cinema;
using MainForm.Classes.UserClasses;
using MainForm.Enums;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
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
    public partial class LoginForm : Form
    {
        Guest guest;
        UserList users;
        SessionList sessions;

        public LoginForm(Guest guest, UserList users,SessionList sessions)
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
                AdminForm adminForm = new AdminForm(sessions,users);
                string guestLogin = textBoxLogin.Text;
                string guestPassword = textBoxPassword.Text;

               
                bool isTrue = guest.SignUp(guestLogin, guestPassword, users);
                Classes.UserClasses.User currentUser = CurrentUserManager.GetCurrentUser();

                if (isTrue) 
                {

                    if (currentUser.Role == Role.RegistredUser)
                    {
                        // Обработка зарегистрированного пользователя
                       CloseForm(this);
                        RegistredUser registeredUser = (RegistredUser)currentUser;
                        RegistredUserForm registred = new RegistredUserForm(sessions);
                        registred.Show();
                    }
                    else if(currentUser.Role == Role.Admin)
                    {
                        // Обработка администратора
                        CloseForm(this);
                        Admin admin = (Admin)currentUser;
                        adminForm.Show();
                    }
                    //MessageBox.Show("Successfully logged!");
                    //CloseForm(this);

                    //RegistredUser registredUser = new RegistredUser();
                    //registredUser = (RegistredUser)CurrentUserManager.GetCurrentUser();

                    //if(registredUser.UserRole == Role.RegistredUser)
                    ////RegistredUser registredUser = new RegistredUser(guest.Login, guest.Password, guest.Surname, guest.Name , Role.RegistredUser);



                    //{
                    //    RegistredUserForm registred = new RegistredUserForm(sessions);
                    //    registred.Show();
                    //}
                }
                else
                {
                   
                    adminForm.Show();
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
