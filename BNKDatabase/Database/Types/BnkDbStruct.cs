using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNKDatabase.Types
{
    internal class BnkDbStruct
    {
        internal struct WinConditionTable
        {
            public const string
                wincondition = "Win Condition",
                wcitems = "WC Items",                   //Contain ID's of PersonTable.item
                wcprofessions = "WC Professions";       //Contain ID's of PersonTable.profession

            public const int 
                wcProfAmount = 8,
                wcItemsAmount = 8;
        }

        internal struct WinConditionCol
        {
            public const string
                id = "id",
                name = "name",
                maxplayers = "max players",
                breed = "breed",
                professions = "professions",            //foreign key linked to WinConditionTable - wcprofessions
                items = "items",                        //foreign key linked to WinConditionTable - wcitems
                opening = "opening",
                goodend = "good end",
                badend = "bad end";
        }

        internal struct WCItemsColumnSketch
        {
            public const string
                id = "id",                              //id is a primary key of wcitems table
                name = "item";                          //usage name + 1.ToString() 
        }

        internal struct WCProfessionsColumnSketch
        {
            public const string
                id = "id",                              //primary key of wcprofessions table
                name = "profession";                    //usage name + 1.ToString() => profession1
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
