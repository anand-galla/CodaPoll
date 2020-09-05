using CodaPoll.Model.Models;
using CodaPoll.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodaPoll.WebApi.Controllers
{
    [RoutePrefix("api/hackerpoll/participants")]
    public class HackerPollController : ApiController
    {
        private IHackerPollService HackerPollService { get; set; }

        public HackerPollController(IHackerPollService hackerPollService)
        {
            this.HackerPollService = hackerPollService;
        }

        [Route("all")]
        public List<HackerPollParticipant> GetHackerPollParticipants()
        {
            return this.HackerPollService.GetHackerPollParticipants();
        }

        [Route("{hackerId}/add")]
        public HackerPollParticipant PostParticipantToHackerPoll(int hackerId)
        {
            return this.HackerPollService.AddParticipantToHackerPoll(hackerId);
        }

        [Route("{hackerId}/delete")]
        public bool DeleteHackerPollParticipant(int hackerId)
        {
            return this.HackerPollService.DeleteHackerPollParticipant(hackerId);
        }

        [Route("{hackerId}/vote")]
        public bool PutVoteForParticipantInHackerPoll(int hackerId)
        {
            return this.HackerPollService.VoteForParticipantInHackerPoll(hackerId);
        }
    }
}
