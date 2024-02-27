using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class StoryCard
    {
        int id;
        string name;
        int maxPlayers;
        bool breed;
        List<int> professions;
        List<int> items;
        string opening;
        string goodend;
        string badend;

        public StoryCard(int id, string name, int maxPlayers, bool breed, List<int> professions, List<int> items, string opening, string goodend, string badend)
        {
            this.id = id;
            this.name = name;
            this.maxPlayers = maxPlayers;
            this.breed = breed;
            this.professions = professions;
            this.items = items;
            this.opening = opening;
            this.goodend = goodend;
            this.badend = badend;
        }
    }
}
