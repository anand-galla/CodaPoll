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
    /// <summary>
    /// Class represents the Hacker Controller
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    [RoutePrefix("api/hacker")]
    public class HackerController : ApiController
    {
        private IHackerService HackerService { get; set; }

        public HackerController(IHackerService hackerService)
        {
            this.HackerService = hackerService;
        }

        [Route("{id}")]
        public Hacker GetHacker(int id)
        {
            return this.HackerService.GetHacker(id);
        }

        [Route("all")]
        public List<Hacker> GetAllHackers()
        {
            return this.HackerService.GetHackers();
        }

        [Route("add")]
        public bool PostHacker([FromBody]Hacker hacker)
        {
            return this.HackerService.AddHacker(hacker);
        }

        [Route("{id}/update")]
        public bool PutHacker(int id, [FromBody]Hacker hacker)
        {
            return this.HackerService.UpdateHacker(id, hacker);
        }

        [Route("{id}/delete")]
        public bool DeleteHacker(int id)
        {
            return this.HackerService.DeleteHacker(id);
        }
    }
}
