using LogDemoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDemoServices
{
    public class SomeService : ServiceBase
    {
        public List<object> GetSomeStuff()
        {
            Logger.Information("GetSomeStuff called"); //TODO: we should have an AOP mechanism like CastleWindor Interception (or the Unity equivalent) to allow us to inject logging so we don't have to write this into every method call.
            return new StuffRepository().GetThings();
        }

        public List<object> GetSomeOtherStuff()
        {
            Logger.Warning("GetSomeOtherStuff - something isn't right here...");
            return new StuffRepository().GetThingsThatWillThrowException();
        }
    }
}
