using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depman.Models
{
    public class Project
    {
        public long ProjectID { get; set; }

        public string ProjectTitle { get; set; }

        public long? ProjectLeaderEmployeeFK { get; set; }

        [ForeignKey("ProjectLeaderEmployeeFK")]
        public Employee Employee { get; set; }
    }
}
