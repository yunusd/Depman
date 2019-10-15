using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depman.Models
{
    public class Department
    {
        public long DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
