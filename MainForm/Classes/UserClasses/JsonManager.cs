using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using MainForm.Classes.Cinema;
using Formatting = Newtonsoft.Json.Formatting;
using Newtonsoft.Json.Linq;
using MainForm.Enums;
using Microsoft.VisualBasic.ApplicationServices;

namespace MainForm.Classes.UserClasses
{
    public class JsonManager
    {
        public void WriteToFile<T>(T obj, string directoryPath, string fileName)
        {
            string fullPath = Path.Combine(directoryPath, fileName);

            // Serialize the object to JSON format
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);

            // Write JSON data to the file
            File.WriteAllText(fullPath, json);
        }



        public static T ReadFromFile<T>(string filePath, string fileName)
        {
            string fullPath = Path.Combine(filePath, fileName);

            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException("File not found", fullPath);
            }

            // Read JSON data from the file
            string json = File.ReadAllText(fullPath);

            // Десериализуем объект JSON
            return JsonConvert.DeserializeObject<T>(json);
        }
        public static UserList ReadUserListFromFile(string filePath, string fileName)
        {
            string fullPath = Path.Combine(filePath, fileName);

            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException("File not found", fullPath);
            }

            // Read JSON data from the file
            string json = File.ReadAllText(fullPath);

            // Deserialize JSON data into a list of dynamic objects
            var dynamicList = JsonConvert.DeserializeObject<List<dynamic>>(json);

            // Convert dynamic objects to RegistredUser objects
            List<User> userList = dynamicList.Select(item =>
            {
                // Создаем новый объект RegistredUser
                RegistredUser user = new RegistredUser();

                // Устанавливаем значения свойств из динамического объекта
                user.Login = item.Login;
                user.Password = item.Password;
                user.Name = item.Name;
                user.Surname = item.Surname;
                user.UserRole = (Role)item.UserRole;

                // Возвращаем объект RegistredUser
                return user;
            }).Cast<User>().ToList();

            UserList users = new UserList();
            users.AddRange(userList);

            return users;
        }
    }
}

