using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNKDatabase;
using Common.BNKProperties;

namespace Bunker_Server
{
    internal class BNKCore
    {
        BnkDb bnkdb;

        public BNKCore()
        {
            bnkdb = new BnkDb();
            bnkdb.Connect();
            var ids = bnkdb.GetWCProfessionsIDs(1);
            if (ids != null)    //debug
            {
                foreach (var id in ids)
                {
                    var s = bnkdb.GetPersonProp(id, PersonProperty.profession);
                }
            }
        }

        public List<string> GetStoryList()
        {


            return null;
        }

        //TO-DO: слушатель событий, на который можно было бы повесить модификации окон из формы.
    }
}
