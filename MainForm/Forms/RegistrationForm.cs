using MainForm.Classes.UserClasses;
using System;
using System.Windows.Forms;

namespace MainForm
{
    public partial class RegistrationForm : Form
    {
        Guest guest;
        UserList users;

        public RegistrationForm(Guest guest, UserList users)
        {
            this.guest = guest;
            this.users = users;
            users.UsersUpdated += Users_Updated;
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                guest.Login = textBoxLogin.Text;
                guest.Password = textBoxPassword.Text;
                guest.Name = textBoxName.Text;
                guest.Surname = textBoxSurname.Text;

                bool isRegistered = guest.Registration(guest.Login, guest.Password, guest.Name, guest.Surname, users);

                if (isRegistered)
                {
                    users.OnUsersUpdated(EventArgs.Empty);
                    MessageBox.Show("Successfuly registrated!");
                    CloseForm(this);
                }
                else
                {
                    MessageBox.Show("Unsuccessfuly registrated!");
                }

            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
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

        private void Users_Updated(object sender, EventArgs e)
        {
            JsonManager jsonManager = new JsonManager();
            jsonManager.WriteToFile(users, @"C:\Visual Studio Projects\OOP_Project_2024_Balychev\json", "users.json");
        }
    }
}
