using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodaPoll.Model.Models
{
    public class HackerPollParticipant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int HackerId { get; set; }

        [Required]
        public string HackerName { get; set; }

        public int NoOfVotes { get; set; }
    }
}
