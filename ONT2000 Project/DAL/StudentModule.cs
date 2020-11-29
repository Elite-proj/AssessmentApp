using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentModule
    {
        public int studentModuleID { get; set; }
        public int lecturerModuleID { get; set; }
        public int userID { get; set; }
        public string date { get; set; }
        public string status { get; set; }
    }
}
