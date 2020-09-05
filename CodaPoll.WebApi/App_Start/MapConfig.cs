using AutoMapper;
using CodaPoll.Data.Models;
using CodaPoll.Model.Models;
using CodaPoll.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodaPoll.WebApi.App_Start
{
    public class MapConfig
    {
        public static void RegisterMap()
        {
            Mapper.Initialize(cfg => cfg.AddProfile(new HackerMappingProfile()));
        }
    }
}