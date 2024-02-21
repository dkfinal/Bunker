using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNKDatabase.Types
{
    public static class BnkDbStruct
    {
        internal struct WinConditionTable
        {
            public const string
                wincondition = "Win Condition",
                wcitems = "WC Items",
                wcprofessions = "WC Professions";
        }

        internal struct WinConditionCol
        {
            public const string
                id = "id",
                name = "name",
                maxplayers = "max players",
                breed = "breed",
                professions = "professions",
                items = "items",
                opening = "opening",
                goodend = "good end",
                badend = "bad end";
        }

        internal struct WCItemsCol
        {
            public const string
                id = "id",
                item1 = "item1",
                item2 = "item2",
                item3 = "item3",
                item4 = "item4",
                item5 = "item5",
                item6 = "item6",
                item7 = "item7",
                item8 = "item8";
        }

        internal struct WCProfessionsCol
        {
            public const string
                id = "id",
                profession1 = "profession1",
                profession2 = "profession2",
                profession3 = "profession3",
                profession4 = "profession4",
                profession5 = "profession5",
                profession6 = "profession6",
                profession7 = "profession7",
                profession8 = "profession";
        }

        internal struct PersonPropertyCol
        {
            public const string
                id = "id",
                name = "name";
        }

        public struct PersonTable
        {
            public const string
                age = "Person Age",
                health = "Person Health",
                hobby = "Person Hobby",
                item = "Person Item",
                profession = "Person Profession",
                race = "Person Race",
                sex = "Person Sex",
                skill = "Person Skill",
                weakness = "Person Weakness";
        }
    }
}
