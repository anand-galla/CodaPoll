using AutoMapper;
using CodaPoll.Data.Models;
using CodaPoll.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodaPoll.Services
{
    public class HackerMappingProfile : Profile
    {
        public HackerMappingProfile()
        {
            this.CreateMap<DBHacker, Hacker>()
                .ReverseMap();

            this.CreateMap<DBHackerPollParticipant, HackerPollParticipant>()
                .ReverseMap();
        }
    }
}
