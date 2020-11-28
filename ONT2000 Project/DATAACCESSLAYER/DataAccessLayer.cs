using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace DATAACCESSLAYER
{
    public class DataAccessLayer
    {
        static string connString = "Data Source= localhost; Initial Catalog= AssessmentDB; Integrated Security=true";

        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        public int InsertUser(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_RegisterUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", user.name);
            dbComm.Parameters.AddWithValue("@Surname", user.surname);
            dbComm.Parameters.AddWithValue("@Title", user.title);
            dbComm.Parameters.AddWithValue("@Role", user.Role);
            dbComm.Parameters.AddWithValue("@Email", user.email);
            dbComm.Parameters.AddWithValue("@Password", user.password);
            dbComm.Parameters.AddWithValue("@UserStatus", user.userStatus);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;


        }

        public DataTable SignIn(string email, string password)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_SignIn", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Email", email);
            dbComm.Parameters.AddWithValue("@Password", password);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
    }
}
