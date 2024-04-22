using MainForm.Classes.UserClasses;
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
        public LoginForm(Guest guest, UserList users)
        {
            this.users = users;
            this.guest = guest;
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool isTrue = guest.SignUp(guest.Login,guest.Password,users);
                if(isTrue) 
                {
                    MessageBox.Show("Nice!");

                }
                else
                {
                    MessageBox.Show("Huita!");
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
    }
}
