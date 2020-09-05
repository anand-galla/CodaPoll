using CodaPoll.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodaPoll.Services
{
    public interface IHackerPollService
    {
        List<HackerPollParticipant> GetHackerPollParticipants();

        HackerPollParticipant GetHackerPollParticipant(int id);

        HackerPollParticipant AddParticipantToHackerPoll(int hackerId);

        bool DeleteHackerPollParticipant(int id);

        bool VoteForParticipantInHackerPoll(int id);
    }
}
