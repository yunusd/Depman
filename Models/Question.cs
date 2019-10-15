using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depman.Models
{
    public class Question
    {
        public long QuestionID { get; set; }

        public string QuestionTitle { get; set; }

        public float? Rating { get; set; }

        public long? ProjectFK { get; set; }

        [ForeignKey("ProjectFK")]
        public Project Project { get; set; }
    }
}
