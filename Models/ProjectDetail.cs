using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depman.Models
{
    public class ProjectDetail
    {
        public long ProjectDetailID { get; set; }

        public string ProjectDescription { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? FinishDate { get; set; }

        public long? DepartmentFK { get; set; }

        public long? ProjectFK { get; set; }

        [ForeignKey("DepartmentFK")]
        public Department Department { get; set; }

        [ForeignKey("ProjectFK")]
        public Project Project { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
