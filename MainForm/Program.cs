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
            SessionList sessions = new SessionList();//= JsonManager.ReadFromFile<SessionList>(@"C:\Visual Studio Projects\OOP_Project_2024_Balychev\json", "sessions.json");

            UserList users = JsonManager.ReadUserListFromFile(@"C:\Visual Studio Projects\OOP_Project_2024_Balychev\json", "users.json");

            Guest guest = new Guest();
            
            ApplicationConfiguration.Initialize();
            
            AdminForm adminForm = new AdminForm(sessions,users);
            RegistredUserForm registredUser = new RegistredUserForm(sessions);
            GuestForm guestForm = new GuestForm(sessions,users);
            LoginForm loginForm = new LoginForm(guest,users, sessions);
           

            Application.Run(guestForm);
          
        }
    }
}