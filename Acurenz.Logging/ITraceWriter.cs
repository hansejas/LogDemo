using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acurenz.Logging
{
    /// <summary>
    /// Trace Writing
    /// </summary>
    public interface ITraceWriter
    {
        /// <summary>
        /// Enable Debug Logging
        /// </summary>
        bool TraceEnabled { get; set; }

        /// <summary>
        /// Open trace writer (implementation may not be necessary for all providers)
        /// </summary>
        void Open();

        /// <summary>
        /// Write using trace writer
        /// </summary>
        /// <param name="message">Message to be written to trace</param>
        void Write(string message);

        /// <summary>
        /// Close trace writer (implementation may not be necessary for all providers)
        /// </summary>
        void Close();
    }
}
