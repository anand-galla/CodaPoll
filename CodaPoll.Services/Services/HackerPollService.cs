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
    public class HackerPollService : IHackerPollService
    {
        public List<HackerPollParticipant> GetHackerPollParticipants()
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var pollParticipants = new List<HackerPollParticipant>();
                    dbContext.HackerPollParticipants.ToList().ForEach((participant) =>
                    {
                        pollParticipants.Add(Mapper.Map<DBHackerPollParticipant, HackerPollParticipant>(participant));
                    });

                    return pollParticipants;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in getting list of participants in hacker poll", ex);
            }
        }

        public HackerPollParticipant GetHackerPollParticipant(int id)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var dbParticipant = dbContext.HackerPollParticipants.SingleOrDefault(parti => parti.Id == id);
                    return Mapper.Map<DBHackerPollParticipant, HackerPollParticipant>(dbParticipant);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in getting hacker poll participant", ex);
            }
        }

        public HackerPollParticipant AddParticipantToHackerPoll(int hackerId)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var dbHacker = dbContext.Hackers.SingleOrDefault(h => h.Id == hackerId);
                    var hacker = Mapper.Map<DBHacker, Hacker>(dbHacker);
                    var hackerPollParticipant = new HackerPollParticipant
                    {
                        HackerId = hacker.Id,
                        HackerName = hacker.Name,
                        NoOfVotes = 0,
                    };

                    var dbHackerPollParticipant = Mapper.Map<HackerPollParticipant, DBHackerPollParticipant>(hackerPollParticipant);
                    dbContext.HackerPollParticipants.Add(dbHackerPollParticipant);
                    dbContext.SaveChanges();
                    return hackerPollParticipant;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in adding participant to hacker poll", ex);
            }
        }

        public bool VoteForParticipantInHackerPoll(int hackerId)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var dbParticipant = dbContext.HackerPollParticipants.SingleOrDefault(parti => parti.HackerId == hackerId);
                    if (dbParticipant == null)
                    {
                        throw new Exception("Selected participant is not found in hacker poll");
                    }

                    dbParticipant.NoOfVotes++;
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in voting the participant in hacker poll", ex);
            }
        }

        public bool DeleteHackerPollParticipant(int id)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    var participant = dbContext.HackerPollParticipants.SingleOrDefault(parti => parti.HackerId == id);
                    dbContext.HackerPollParticipants.Remove(participant);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in deleting the participant from hacker poll", ex);
            }
        }
    }
}
