using Acurenz.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDemoRepository
{
    public class StuffRepository:BaseRepository
    {

        public List<object> GetThings()
        {
            Logger.Debug("Stuff Repository.GetThings...");

            return new List<object>();
        }

        public List<object> GetThingsThatWillThrowException()
        {
            Logger.Debug("more debugging here...");
            try
            {
                throw new Exception("Generic Exception here!");
            }
            catch (Exception ex)
            {
                Logger.Exception("Some message from developer here!", ex);
            }
            return new List<object>();
        }
    }
}
