using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESSLAYER
{
    public class User
    {
        public int UserID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string title { get; set; }
        public string Role { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string userStatus { get; set; }

        public int GetUserID(int id)
        {
            int userID = id;
            return userID;
        }
    }
}
