using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.BNKProperties
{
    public class StoryProperty
    {
        public const string
            name = "story_name",                //short story header
            maxplayers = "story_maxplayers",    //recommended players for thisstory
            breed = "story_breed",              //is breeding needed
            //professions = "story_professions",  //key professions required for victory
            //items = "story_items",              //key items required for victory
            opening = "story_opening",          //story prologue
            goodend = "story_goodend",          //win
            badend = "story_badend";            //lose
    }
}
