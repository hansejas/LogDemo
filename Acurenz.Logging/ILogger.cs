using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acurenz.Logging
{
    /// <summary>
    /// Acurenz logging
    /// </summary>
    public interface ILogger
    {

        /// <summary>
        /// Enable Information Logging
        /// </summary>
        bool InformationEnabled {get; set;}

        /// <summary>
        /// Enable Warning Logging
        /// </summary>
        bool WarningEnabled { get; set; }

        /// <summary>
        /// Enable Error Logging
        /// </summary>
        bool ErrorEnabled {get; set;}

        /// <summary>
        /// Enable Debug Logging
        /// </summary>
        bool DebugEnabled {get; set;}

        /// <summary>
        /// Enable Exception Logging
        /// </summary>
        bool ExceptionEnabled { get; set; }

        /// <summary>
        /// Property responsible for writing trace messages
        /// </summary>
        ITraceWriter TraceWriter { get; set; }

        /// <summary>
        /// Property responsible for writing informational messages
        /// </summary>
        void Information(string message);

        /// <summary>
        /// Property responsible for warning messages
        /// </summary>
        void Warning(string message);

        /// <summary>
        /// Property responsible for writing error messages
        /// </summary>
        void Error(string message);

        /// <summary>
        /// Property responsible for writing debug messages
        /// </summary>
        void Debug(string message);

        /// <summary>
        /// Property responsible for writing exception messages
        /// </summary>
        void Exception(string message, Exception ex);
    }
}
