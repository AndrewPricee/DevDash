using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Models
{
    public class Project
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string ProjectName { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectDueDate { get; set; }
        public string ProjectDescription { get; set; }
        public bool ProjectComplete { get; set; }
        public int ProjectType { get; set; }
    }
}
