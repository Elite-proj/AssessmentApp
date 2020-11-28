using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DATAACCESSLAYER;

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

        // Student Forms

        public DataTable GetStudentModule(User user)
        {
            return dal.GetStudentModules(user);
        }

        public DataTable SearchStudentModule(Module mod, User user)
        {
            return dal.SearchStudentModule(mod, user);
        }

        public int SaveStudentAssessment(StudentAssessment studAssess)
        {
            return dal.SaveStudentAssessment(studAssess);
        }

        public DataTable GetStudentAssessmentByStatus(StudentAssessment st)
        {
            return dal.GetStudentAssessmentByStatus(st);
        }
        public DataTable ListAllStudentAssessments(User user)
        {
            return dal.ListAllStudentAssessments(user);
        }
    }
}
