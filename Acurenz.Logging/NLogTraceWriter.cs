using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acurenz.Logging
{
    public class NLogTraceWriter: ITraceWriter
    {
        private NLog.Logger log;

        public NLogTraceWriter()
        {
            log = NLog.LogManager.GetLogger("NlogTrace");
        }

        #region ITraceWriter Members
        public bool TraceEnabled { get; set; }

        public void Open()
        {
            //not used for nlog implementation
        }

        public void Write(string message)
        {
            if (TraceEnabled)
            {
                log.Trace(message);
            }
        }

        public void Close()
        {
            //not used for nlog implementation
        }
        #endregion
    }
}
