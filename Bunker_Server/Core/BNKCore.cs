using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNKDatabase;
using Common;
using Common.BNKProperties;

namespace Bunker_Server
{
    internal class BNKCore
    {
        BnkDb bnkdb;
        StoryCard story;

        public BNKCore()
        {
            bnkdb = new BnkDb();
            bnkdb.Connect();
        }

        public List<string> GetStoryList()
        {
            List<string> storylst = new List<string>();
            int stroyamount = bnkdb.GetPropertyAmount(StoryProperty.name);
            for (int i = 0; i < stroyamount; i++)
            {
                string storyname = bnkdb.GetWCProp(i + 1, StoryProperty.name);
                if (storyname != null)
                {
                    storylst.Add(storyname);
                }
                else
                {
                    storylst.Add("Unnamed story" + (i + 1).ToString());
                }
            }
            return storylst;
        }

        public void CreateStory(int id)
        {
            story = StoryCardMethod(id);
        }

        StoryCard StoryCardMethod(int id)
        {
            //todo
            return null;
        }

        PlayerCard PlayerCardMethod(int id)
        {
            //todo
            return new PlayerCard();
        }

        //TO-DO: listener..?
    }
}
