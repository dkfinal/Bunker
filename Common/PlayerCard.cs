using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class PlayerCard
    {
        bool isAlive;

        string
            age,
            health,
            hobby,
            item,
            profession,
            race,
            sex,
            skill,
            weakness;

        int
            ageID,
            healthID,
            hobbyID,
            itemID,
            professionID,
            raceID,
            sexID,
            skillID,
            weaknessID;

        public PlayerCard()
        {
            isAlive = true;
        }

        public void UseSkill()
        {

        }
    }
}
