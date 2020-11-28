using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESSLAYER
{
    public class Assessment
    {
        public int assessmentID { get; set; }
        public string decription { get; set; }
        public int StudentLecturerModuleID { get; set; }
        public string DueDate { get; set; }
        public int AssessmentTypeID { get; set; }
        public string AssessmentStatus { get; set; }
    }
}
