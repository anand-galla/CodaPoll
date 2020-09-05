using CodaPoll.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodaPoll.Services
{
    public interface IHackerService
    {
        Hacker GetHacker(int id);

        List<Hacker> GetHackers();

        bool AddHacker(Hacker hacker);

        bool UpdateHacker(int id, Hacker hacker);

        bool DeleteHacker(int id);
    }
}
