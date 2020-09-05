using AutoMapper;
using CodaPoll.Data.Context;
using CodaPoll.Data.Models;
using CodaPoll.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodaPoll.Services
{
    public class HackerService : IHackerService
    {
        public HackerService() { }

        public Hacker GetHacker(int id)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var dbHacker = dbContext.Hackers.SingleOrDefault(h => h.Id == id);
                    Hacker hacker = Mapper.Map<DBHacker, Hacker>(dbHacker);
                    return hacker;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in getting hacker details", ex);
            }           
        }

        public List<Hacker> GetHackers()
        {
            try
            {
                using(var dbContext = new DBContext())
                {
                    var hackers = new List<Hacker>();
                    var dbHackers = dbContext.Hackers.ToList();
                    dbHackers.ForEach((dbHacker) => {
                        hackers.Add(Mapper.Map<DBHacker, Hacker>(dbHacker));
                    });

                    return hackers;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in getting hackers list", ex);
            }
        }

        public bool AddHacker(Hacker hacker)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var dbHacker = Mapper.Map<Hacker, DBHacker>(hacker);
                    dbContext.Hackers.Add(dbHacker);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in adding hacker", ex);
            }
        }

        public bool UpdateHacker(int id, Hacker hacker)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var existingHacker = dbContext.Hackers.SingleOrDefault(h => h.Id == id);
                    Mapper.Map(hacker, existingHacker);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in updating the hacker details", ex);
            }
        }

        public bool DeleteHacker(int id)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var hacker = dbContext.Hackers.SingleOrDefault(h => h.Id == id);
                    dbContext.Hackers.Remove(hacker);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in deleting the hacker", ex);
            }
        }
    }
}
