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
        private bool isNull = false;
        public User()
        {
            password = "";
            user_id = "";
            LoadData();
        }
        private void LoadData()
        {
            using (StreamReader sr = File.OpenText("UsrDet.txt"))
            {
#pragma warning disable CS8601 // Possible null reference assignment.
                password = sr.ReadLine();
                user_id = sr.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.
                if (password == null || user_id == null) isNull = true;
            }
        }
        //GET only properties to return User_id and Password.
        public string User_id => user_id;
        public string Password => password;
        public bool IsNull => isNull;
    }
}
