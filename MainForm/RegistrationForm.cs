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
    public partial class RegistrationForm : Form
    {
        Guest guest;
        UserList users;
        public RegistrationForm(Guest guest,UserList users)
        {
            this.guest = guest;
            this.users = users;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                guest.Login = textBox1.Text;
                guest.Password = textBox2.Text;
                guest.Name = textBox3.Text;
                guest.Surname = textBox4.Text;

                bool isTrue = guest.Registration(guest.Login, guest.Password,guest.Name,guest.Surname,users);

                if(isTrue) 
                {
                    MessageBox.Show("Succsess!");
                }
                else
                {
                    MessageBox.Show("fuuu!");
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
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
