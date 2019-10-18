using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depman.Models
{
    public class Employee
    {
        public long EmployeeID { get; set; }

        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }

        public string Sex { get; set; }

        public string Degree { get; set; }

        public string Address { get; set; }


        [StringLength(11)]
        public string Phone { get; set; }

        public string Email { get; set; }

        public string EmployeeImgPath { get; set; }

        public float? Rating { get; set; }

        public decimal Salary { get; set; }

        public DateTime HireDate { get; set; }

        public long DepartmentFK { get; set; }

        public long? EmployeeFK { get; set; }

        [ForeignKey("DepartmentFK")]
        public Department Department { get; set; }

        [ForeignKey("EmployeeFK")]
        public Employee Manager { get; set; }

        public ICollection<Report> Reports { get; set; }

        public ICollection<ProjectDetail> ProjectDetails { get; set; }
    }
}
