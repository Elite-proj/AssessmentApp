using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();

        public int InsertUser(User user)
        {
            return dal.InsertUser(user);
        }

        public DataTable SignIn(string email, string password)
        {
            return dal.SignIn(email, password);
        }
    }
}
