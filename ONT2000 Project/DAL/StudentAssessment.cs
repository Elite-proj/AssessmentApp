using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentAssessment
    {
        public int StudentAssessmentID { get; set; }
        public int userID { get; set; }
        public int assessmentID { get; set; }
        public string date { get; set; }
        public string status { get; set; }
    }
}
