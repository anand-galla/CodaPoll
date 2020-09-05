using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodaPoll.Data.Models
{
    [Table("Hacker")]
    public class DBHacker
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LoginId { get; set; }

        public int NoOfChallengesSolved { get; set; }

        public int ExpertiseLevel { get; set; }

        public string Summary { get; set; }
    }
}
