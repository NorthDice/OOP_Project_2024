using MainForm.Classes.Cinema;
using MainForm.Classes.UserClasses;

namespace MainForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Создаем экземпляр SessionList
            SessionList sessions = new SessionList();
            UserList users = new UserList();
           Guest guest = new Guest();
            // Запускаем приложение, передавая экземпляр SessionList в форму RegistredUserForm
            ApplicationConfiguration.Initialize();
            //RegistredUserForm registredUserForm = new RegistredUserForm(sessions);
           LoginForm loginForm = new LoginForm(guest,users);
            loginForm.Show();
            Application.Run(new RegistrationForm(guest,users));
          
        }
    }
}