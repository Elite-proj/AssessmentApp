using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Module:ModuleType
    {
        public int moduleID { get; set; }
        public string name { get; set; }
        public string Duration { get; set; }
        public string Status { get; set; }
    }
}
