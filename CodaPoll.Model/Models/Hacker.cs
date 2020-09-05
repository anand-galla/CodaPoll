using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodaPoll.Model.Models
{
    public class Hacker
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LoginId { get; set; }

        public int NoOfChallengesSolved { get; set; }

        public int ExpertiseLevel { get; set; }

        public string Summary { get; set; }
    }
}
