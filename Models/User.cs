using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depman.Models
{
    public class User
    {
        public long UserID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int Authorization { get; set; }

        public long EmployeeFK { get; set; }

        [ForeignKey("EmployeeFK")]
        public Employee Employee { get; set; }
    }
}
