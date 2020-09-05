using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodaPoll.Data.Models
{
    [Table("HackerPollParticipant")]
    public class DBHackerPollParticipant
    {
        public int Id { get; set; }

        public int HackerId { get; set; }

        public string HackerName { get; set; }

        public int NoOfVotes { get; set; }
    }
}
