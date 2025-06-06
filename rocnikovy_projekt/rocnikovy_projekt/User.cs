using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocnikovy_projekt
{
    internal class User
    {
        public string name {  get; set; }
        public string PasswordHash { get; set; }
        public List <Assingment> assignments{ get; set; } = new List<Assingment>();

        public User(string Name, string passwordHash) 
        {
            name = Name;
            PasswordHash = passwordHash;
        }
    }
}
