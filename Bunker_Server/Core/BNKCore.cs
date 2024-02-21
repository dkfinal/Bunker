using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNKDatabase;

namespace Bunker_Server
{
    internal class BNKCore
    {
        BnkDb bnkdb;

        public BNKCore()
        {
            bnkdb = new BnkDb();
            bnkdb.Connect();
        }

        public List<string> GetStoryList()
        {


            return null;
        }

        //TO-DO: слушатель событий, на который можно было бы повесить модификации окон из формы.
    }
}
