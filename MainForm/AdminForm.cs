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
    public partial class AdminForm : Form
    {
        SessionList sessions;
        Admin admin;

        public AdminForm()
        {
            InitializeComponent();
            sessions = new SessionList();
            admin = new Admin("admin123", "password", "Johnss", "Dossse", Role.Admin);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime date = dateTimePickerDate.Value.Date;
            TimeSpan time = TimeSpan.Parse(textBoxTime.Text);
            string filmName = textBoxFilmName.Text;
            Halls hallNumber = (Halls)Enum.Parse(typeof(Halls), textBoxHall.Text);


            bool isAdded = admin.AddSession(date, time, hallNumber, filmName, sessions);
            if (isAdded)
            {
                MessageBox.Show("Session added succesfully!");
            }
            else
            {
                MessageBox.Show("Session wasn't added!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DateTime date = dateTimePickerDate.Value.Date;
            TimeSpan time = TimeSpan.Parse(textBoxTime.Text);
            string filmName = textBoxFilmName.Text;
            Halls hallNumber = (Halls)Enum.Parse(typeof(Halls), textBoxHall.Text);

            // Пытаемся удалить сеанс
            try
            {
                bool success = admin.DeleteSession(date, time, hallNumber, filmName, sessions);

                if (success)
                {
                    MessageBox.Show("Session successfully deleted.");

                }
                else
                {
                    MessageBox.Show("Session could not be deleted. Make sure the input is correct and the session exists.");
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
        }

        private void button3_Click(object sender, EventArgs e)
        {

        //    DateTime selectedDate = dateTimePickerDate.Value.Date;
        //    TimeSpan selectedTime = TimeSpan.Parse(textBoxTime.Text);
        //    TimeSpan newTime = TimeSpan.Parse(textBoxNewTime.Text);

        //    // Вызываем метод EditSession для редактирования сеанса
        //    bool success = admin.EditSession(selectedDate, selectedTime, newTime, sessions);

        //    // Если редактирование прошло успешно, обновляем ListBox с информацией о сеансах
        //    if (success)
        //    {

        //        MessageBox.Show("Session edited successfully.");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Failed to edit session. Please check the input values.");
        //    }
        }
    }
}
