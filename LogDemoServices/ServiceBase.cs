using Acurenz.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDemoServices
{
    /// <summary>
    /// Base class for all services.
    /// </summary>
    public abstract class ServiceBase
    {
        ILogger _logger;

        /// <summary>
        /// Service Log Component
        /// </summary>
        protected ILogger Logger
        {
            get
            {
                if (_logger == null)
                {
                    _logger = new NLogLogger(); //HACK: use DI here

                }
                return _logger;
            }
        }
    }
}
