using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBot
{
    internal class User
    {
        private string password;
        private string user_id;
        public User()
        {
            password = "";
            user_id = "";
            Get_Data();
        }
        private void Get_Data()
        {
            using (StreamReader sr = File.OpenText("UsrDet.txt"))
            {
#pragma warning disable CS8601 // Possible null reference assignment.
                password = sr.ReadLine();
                user_id = sr.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
            }
        }
        public void Details(out string User_id, out string Password)
        {
            User_id = user_id;
            Password = password;
        }
        public string User_id => user_id;
        public string Password => password;
    }
}
