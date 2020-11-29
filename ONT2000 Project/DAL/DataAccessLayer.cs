using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
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

        //Admin Forms Code

        public DataTable InsertToComboBoxModuleType()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_AddModuleTypeToComboBox", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public int InsertModule(Module mod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_InsertModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("Name", mod.name);
            dbComm.Parameters.AddWithValue("Duration", mod.Duration);
            dbComm.Parameters.AddWithValue("ModuleTypeID", mod.moduleTypeID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }

        public DataTable ListAllModules()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_ListModules", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }

        public int UpdateModule(Module mod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_UpdateModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", mod.name);
            dbComm.Parameters.AddWithValue("@Duration", mod.Duration);
            dbComm.Parameters.AddWithValue("@ModuleTypeID", mod.moduleTypeID);
            dbComm.Parameters.AddWithValue("@ModuleID", mod.moduleID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }

        public int DeleteModule(Module mod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_DeleteModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleID", mod.moduleID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public DataTable GetUserByID(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_GetUserByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", user.UserID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;

        }

        public DataTable GetModuleByID(Module mod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_GetModuleByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleID", mod.moduleID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }

        public int AssignLecturerModule(LecturerModule lecMod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_AssignLecturerModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@LecturerID", lecMod.userID);
            dbComm.Parameters.AddWithValue("@ModuleID", lecMod.moduleID);
            dbComm.Parameters.AddWithValue("@Date", lecMod.date);
            dbComm.Parameters.AddWithValue("@Status", lecMod.status);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public DataTable ListAllLecturers(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_ListAllLecturers", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Role", user.Role);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public DataTable ListAllAssignedLecturers()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_ListAssignedLecturers", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public DataTable GetAssignedLecturerByID(LecturerModule lecMod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_GetAssignLecturerByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@LecturerModuleID", lecMod.lecturerModuleID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }

        public int UpdateLecturerModule(LecturerModule lecMod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_UpdateLecturerModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@LecturerModuleID", lecMod.lecturerModuleID);
            dbComm.Parameters.AddWithValue("@UserID", lecMod.userID);

            dbComm.Parameters.AddWithValue("@Date", lecMod.date);
            dbComm.Parameters.AddWithValue("@Status", lecMod.status);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }

        public int DeleteLecturerModule(LecturerModule lecMod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_DeleteLecturerModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@LecturerModuleID", lecMod.lecturerModuleID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public DataTable ListStudentModule()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_ListStudentModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public int UpdateStudentModule(StudentModule studMod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_UpdateStudentModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Status", studMod.status);
            dbComm.Parameters.AddWithValue("@StudentModuleID", studMod.studentModuleID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();

            return x;
        }

        public int DeleteStudentModule(StudentModule studMod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_DeleteStudentModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@StudentModuleID", studMod.studentModuleID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public int DeleteUser(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_DeleteUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", user.UserID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public DataTable ListAllStudents(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_ListAllStudents", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Role", user.Role);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public DataTable ListAllModulesForStudents()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_ListModulesToStudents", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public int EnrollStudentToModule(StudentModule studModule)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_EnrollStudentModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("LecturerModuleID", studModule.lecturerModuleID);
            dbComm.Parameters.AddWithValue("UserID", studModule.userID);
            dbComm.Parameters.AddWithValue("@Date", studModule.date);
            dbComm.Parameters.AddWithValue("@Status", studModule.status);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }

        public DataTable SearchModule(Module mod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_SearchModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleName", mod.name);
            //dbComm.Parameters.AddWithValue("@ModuleID", mod.moduleID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }
        public DataTable SearchUserByNames(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_SearchUserByName", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", user.name);
            dbComm.Parameters.AddWithValue("@Surname", user.surname);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public int UpdateUser(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_UpdateUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", user.name);
            dbComm.Parameters.AddWithValue("@Surname", user.surname);
            dbComm.Parameters.AddWithValue("@Title", user.title);
            dbComm.Parameters.AddWithValue("@Role", user.Role);
            dbComm.Parameters.AddWithValue("@Email", user.email);
            dbComm.Parameters.AddWithValue("@Status", user.userStatus);
            dbComm.Parameters.AddWithValue("@UserID", user.UserID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;

        }


        //Lecturer Forms Code
        public int InsertAssessment(Assessment assess)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_InsertAssessment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description", assess.decription);
            dbComm.Parameters.AddWithValue("@ModuleID", assess.StudentLecturerModuleID);
            dbComm.Parameters.AddWithValue("@DueDate", assess.DueDate);
            dbComm.Parameters.AddWithValue("@AssessmentTypeID", assess.AssessmentTypeID);
            dbComm.Parameters.AddWithValue("@AssessmentStatus", assess.AssessmentStatus);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetLecturerModuleByUser(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_GetLecturerModuleByUserID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("UserID", user.UserID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public DataTable ListAssessmentType()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_ListAssessmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }

        public DataTable ListAssessment(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_ListAssessment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", user.UserID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();

            return dt;
        }
        public DataTable GetAssessmentByID(Assessment assess)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_GetAssessmentInCellClick", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AssessmentID", assess.assessmentID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public int UpdateAssessment(Assessment assess)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_UpdateAssessment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description", assess.decription);
            dbComm.Parameters.AddWithValue("@DueDate", assess.DueDate);
            dbComm.Parameters.AddWithValue("@AssessmentStatus", assess.AssessmentStatus);
            dbComm.Parameters.AddWithValue("@AssessmentID", assess.assessmentID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public DataTable GetAssessmentByModuleID(Module mod)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_GetAssessmentsByModuleID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ModuleID", mod.moduleID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public DataTable ListStudentAssessment(Assessment assess)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_StudentsAssesments", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AssessmentID", assess.assessmentID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public int DeleteAssessment(Assessment assess)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_DeleteAssessment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AssessmentID", assess.assessmentID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }

        public DataTable GetAssessmentTypeByUserID(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_GetAssessmentTypeByID", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", user.UserID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public DataTable SearchAssessment(Assessment assessment, int userID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_SearchAssessment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", userID);
            dbComm.Parameters.AddWithValue("@AssessmentDescription", assessment.decription);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public DataTable GetAssessmentByType(Assessment assess, int userID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_GetAssessmentByType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AssessmentTypeID", assess.AssessmentTypeID);
            dbComm.Parameters.AddWithValue("@UserID", userID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }



        // Student Forms

        public DataTable GetStudentModules(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_GetStudentModules", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", user.UserID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public DataTable SearchStudentModule(Module mod, User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_SearchStudentModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", user.UserID);
            dbComm.Parameters.AddWithValue("@Description", mod.name);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public int SaveStudentAssessment(StudentAssessment stuAsses)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_SaveStudentAssessment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", stuAsses.userID);
            dbComm.Parameters.AddWithValue("@AssessmentID", stuAsses.assessmentID);
            dbComm.Parameters.AddWithValue("@AssessmentDate", stuAsses.date);
            dbComm.Parameters.AddWithValue("@Status", stuAsses.status);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public DataTable GetStudentAssessmentByStatus(StudentAssessment student)
        {
            try
            {
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_GetStudentAssessmentByStatus", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", student.userID);
            dbComm.Parameters.AddWithValue("@Status", student.status);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public DataTable ListAllStudentAssessments(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_ListAllStudentAssessments", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@UserID", user.UserID);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }


        //Additionals

        public DataTable GetTotalStudentsEnrolledINModule()
        {
            try
            {
                dbConn.Open();
            }
            catch
            { 
            }
            dbComm = new SqlCommand("sp_GetTotalStudentsForModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;

        }

        public int AdminRegisterUser(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_RegisterUserByAdmin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", user.name);
            dbComm.Parameters.AddWithValue("@Surname", user.surname);
            dbComm.Parameters.AddWithValue("@Title", user.title);
            dbComm.Parameters.AddWithValue("@Role", user.Role);
            dbComm.Parameters.AddWithValue("@Email", user.email);
            
            dbComm.Parameters.AddWithValue("@UserStatus", user.userStatus);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public DataTable GetUserByEmail(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_GetUserByEmail", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Email", user.email);
            

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();
            return dt;
        }

        public int UserSetPassword(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_UserSetNewPassword", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Password", user.password);
            
            dbComm.Parameters.AddWithValue("@UserID", user.UserID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public int InsertAssessmentType(string desc)
        {
            try
            {
                dbConn.Open();
            }
            catch
            { 
            }

            dbComm = new SqlCommand("sp_InsertAssessmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description", desc);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }
        public int UpdateAssessmentType(string desc,int id)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_UpdateAssessmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AssessmentTypeID", id);
            dbComm.Parameters.AddWithValue("@AssessmentDesc", desc);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public int DeleteAssessmentType(int id)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }

            dbComm = new SqlCommand("sp_DeleteAssessmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AssessmentTypeID", id);
            

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

    }
}
