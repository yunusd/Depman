using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depman.Models
{
    public class Report
    {
        public long ReportID { get; set; }

        public string ReportDescription { get; set; }

        public float Rating { get; set; }

        public long EmployeeFK { get; set; }

        [ForeignKey("EmployeeFK")]
        public Employee Employee { get; set; }

        public ICollection<Question> Questions { get; set; }
    
    }
}
