using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

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



        //Admin forms code
        public DataTable InsertToComboBoxModuleType()
        {
            return dal.InsertToComboBoxModuleType();
        }

        public int InsertModule(Module mod)
        {
            return dal.InsertModule(mod);
        }

        public DataTable ListAllModules()
        {
            return dal.ListAllModules();
        }

        public int UpdateModule(Module mod)
        {
            return dal.UpdateModule(mod);
        }

        public int DeleteModule(Module mod)
        {
            return dal.DeleteModule(mod);
        }

        public DataTable GetModuleByID(Module mod)
        {
            return dal.GetModuleByID(mod);
        }
        public int AssignLecturerModule(LecturerModule lecturerModule)
        {
            return dal.AssignLecturerModule(lecturerModule);
        }

        public DataTable ListAllLecturers(User user)
        {
            return dal.ListAllLecturers(user);
        }

        public DataTable ListAssignedLecturers()
        {
            return dal.ListAllAssignedLecturers();
        }

        public DataTable GetAssignedLectureByID(LecturerModule lecturerModule)
        {
            return dal.GetAssignedLecturerByID(lecturerModule);
        }

        public int UpdateLecturerModule(LecturerModule lecturer)
        {
            return dal.UpdateLecturerModule(lecturer);
        }

        public int DeleteLecturerModule(LecturerModule lecMod)
        {
            return dal.DeleteLecturerModule(lecMod);
        }
        public int UpdateStudentModule(StudentModule studMod)
        {
            return dal.UpdateStudentModule(studMod);
        }

        public int DeleteStudentModule(StudentModule studMod)
        {
            return dal.DeleteStudentModule(studMod);
        }
        public int DeleteUser(User user)
        {
            return dal.DeleteUser(user);
        }

        public DataTable ListStudentModule()
        {
            return dal.ListStudentModule();
        }
        public DataTable ListAllStudents(User user)
        {
            return dal.ListAllStudents(user);
        }
        public DataTable ListAllModulesForStudents()
        {
            return dal.ListAllModulesForStudents();
        }
        public int EnrolStudentToModule(StudentModule studModule)
        {
            return dal.EnrollStudentToModule(studModule);
        }
        public DataTable SearchModule(Module mod)
        {
            return dal.SearchModule(mod);
        }
        public DataTable GetUserByID(User user)
        {
            return dal.GetUserByID(user);
        }
        public DataTable SearchUserByName(User user)
        {
            return dal.SearchUserByNames(user);
        }
        public int UpdateUser(User user)
        {
            return dal.UpdateUser(user);
        }



        //Lecturer Main Form
        public int InsertAssessment(Assessment assess)
        {
            return dal.InsertAssessment(assess);
        }

        public DataTable GetLecturerModuleByUserID(User user)
        {
            return dal.GetLecturerModuleByUser(user);
        }

        public DataTable ListAssessmentType()
        {
            return dal.ListAssessmentType();
        }

        public DataTable ListAssessment(User user)
        {
            return dal.ListAssessment(user);
        }
        public DataTable GetAssessmentByID(Assessment assess)
        {
            return dal.GetAssessmentByID(assess);
        }
        public int UpdateAssessment(Assessment assess)
        {
            return dal.UpdateAssessment(assess);
        }
        public DataTable GetAssessmentByModuleID(Module mod)
        {
            return dal.GetAssessmentByModuleID(mod);
        }
        public DataTable ListStudentAssessment(Assessment assess)
        {
            return dal.ListStudentAssessment(assess);
        }

        public int DeleteAssessment(Assessment assess)
        {
            return dal.DeleteAssessment(assess);
        }

        public DataTable GetAssessmentTypeByUserID(User user)
        {
            return dal.GetAssessmentTypeByUserID(user);
        }

        public DataTable SearchAssessment(Assessment assess, int userID)
        {
            return dal.SearchAssessment(assess, userID);
        }

        public DataTable GetAssessmentByType(Assessment assess, int userID)
        {
            return dal.GetAssessmentByType(assess, userID);
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

        //Additionals

        public DataTable GetTotalStudentsEnrolledINModule()
        {
            return dal.GetTotalStudentsEnrolledINModule();
        }

        public int AdminRegisterUser(User user)
        {
            return dal.AdminRegisterUser(user);
        }

        public DataTable GetUserByEmail(User user)
        {
            return dal.GetUserByEmail(user);
        }

        public int UserSetPassword(User user)
        {
            return dal.UserSetPassword(user);
        }

        public int InsertAssessmentType(string desc)
        {
            return dal.InsertAssessmentType(desc);
        }

        public int UpdateAssessmentType(string desc, int id)
        {
            return dal.UpdateAssessmentType(desc, id);
        }

        public int DeleteAssessmentType(int id)
        {
            return dal.DeleteAssessmentType(id);
        }
    }
}
