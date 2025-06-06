using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace rocnikovy_projekt
{
    internal class UserManager
    {
        private const string FilePath = "users.json";
        private List<User> users = new List<User>();

        public UserManager()
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
        }

        private void SaveUsers()
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public bool Register(string username, string hashedPassword)
        {
            if (users.Any(u => u.name == username))
                return false;

            users.Add(new User(username, hashedPassword));
            return true;
        }

        public bool Login(string username, string password)
        {
            return users.Any(u => u.name == username && u.PasswordHash == password);
        }

        public bool AddAssingmentToUser(string username, string assignment) 
        {
            var user = users.FirstOrDefault(u => u.name == username);
            Assingment Aassignment = new Assingment(assignment, false);
            if (user != null)
            {
                user.assignments.Add(Aassignment);
                SaveUsers();
                return true;
            }
            return false;
        }

        public List<Assingment> GetAssingmentOfUser (string username)
        {
            var user = users.FirstOrDefault(u => u.name == username);
            return user?.assignments ?? new List<Assingment>();
        }

        public bool RemoveAssingmentToUser(string username, string assignment)
        {
            var user = users.FirstOrDefault(u => u.name == username);
            if (user != null)
            {
                var itemToRemove = user.assignments.FirstOrDefault(a => a.jmeno == assignment);
                if (itemToRemove != null)
                {
                    user.assignments.Remove(itemToRemove);
                    SaveUsers();
                    return true;
                }
            }
                return false;
        }

        public bool CompleteAssingmentToUser(string userName, string assignment)
        {
            var user = users.FirstOrDefault(u => u.name == userName);
            if (user != null)
            {

                var itemToComplete = user.assignments.FirstOrDefault(a => a.jmeno == assignment);
                if (itemToComplete != null) 
                {
                    itemToComplete.splneno = true;
                    itemToComplete.datum_splneni = DateTime.Now;
                    SaveUsers();
                    return true;
                }
            }
            return false;
        }

        public string GetHashForUser(string username)
        {
            var user = users.FirstOrDefault(u => u.name == username);
            return user?.PasswordHash;
        }

    }
}
