using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Acurenz.Logging
{
    /// <summary>
    /// ILogger and ITraceWriter implementation using nlog
    /// </summary>
    public class NLogLogger: ILogger
    {


        private NLog.Logger log;

        /// <summary>
        /// Constructor - will set up underlying logging implementation
        /// </summary>
        public NLogLogger()
        {
            log = NLog.LogManager.GetLogger("AcurenzWebLog");
        }

        #region ILogger Members
        /// <summary>
        /// Enable Information Logging
        /// </summary>
        public bool InformationEnabled { get; set; }
        
        /// <summary>
        /// Enable Warning Logging
        /// </summary>
        public bool WarningEnabled { get; set; }
        
        /// <summary>
        /// Enable Error Logging
        /// </summary>
        public bool ErrorEnabled { get; set; }
        
        /// <summary>
        /// Enable Debug Logging
        /// </summary>
        public bool DebugEnabled { get; set; }

        /// <summary>
        /// Enable Debug Logging
        /// </summary>
        public bool TraceEnabled { get; set; }
      
        /// <summary>
        /// Enable Exception Logging
        /// </summary>
        public bool ExceptionEnabled { get; set; }

        private ITraceWriter traceWriter;

        public ITraceWriter TraceWriter
        {
            get 
            {
                if (traceWriter == null)
                {
                    traceWriter = new NLogTraceWriter();
                }
                return traceWriter; 
            }
            set { traceWriter = value; }
        }
        

        /// <summary>
        /// Log Information with message
        /// </summary>
        /// <param name="message">message to log</param>
        public void Information(string message)
        {
            if (InformationEnabled)
            {
                log.Info(message);
            }
        }

        /// <summary>
        /// Log Warning with message
        /// </summary>
        /// <param name="message">message to log</param>
        public void Warning(string message)
        {
            if (WarningEnabled)
            {
                log.Warn(message);
            }
        }


        /// <summary>
        /// Log Error with message
        /// </summary>
        /// <param name="message">message to log</param>
        public void Error(string message)
        {
            if (ErrorEnabled)
            {
                log.Error(message);
            }
        }

        /// <summary>
        /// Log Debug with message
        /// </summary>
        /// <param name="message">message to log</param>
        public void Debug(string message)
        {
            if (DebugEnabled)
            {
                log.Debug(message);
            }
        }

        /// <summary>
        /// Log Exception with message
        /// </summary>
        /// <param name="message">message to log</param>
        public void Exception(string message, Exception ex)
        {
            if (ExceptionEnabled)
            {
                log.Info(message, ex);
            }
        }

        //(commented code below) alternatively, we could reduce the number of log methods and pass in enums to indicate the type of message we are logging, but I thought this would be more cumbersome for the developer as having method names will involve less typing due to intellisense.
        //public void LogException(string message, MessageType messageType, Exception ex)
        //{
        //    switch (messageType)
        //    {
        //        case(MessageType.Debug):
        //            log.DebugException(message, ex);
        //            break;
        //        case(MessageType.Error):
        //            log.ErrorException(message, ex);
        //            break;
        //        case(MessageType.Information):
        //            log.InfoException(message, ex);
        //            break;
        //        case(MessageType.Warning):
        //            log.WarnException(message, ex);
        //            break;
        //        default:
        //            throw new ArgumentException("Unsupported MessageType for NLogger.LogException");
        //    }
        //}

        //public void Log(string message, MessageType messageType)
        //{
        //    switch (messageType)
        //    {
        //        case (MessageType.Debug):
        //            log.Debug(message);
        //            break;
        //        case (MessageType.Error):
        //            log.Error(message);
        //            break;
        //        case (MessageType.Information):
        //            log.Info(message);
        //            break;
        //        case (MessageType.Warning):
        //            log.Warn(message);
        //            break;
        //        default:
        //            throw new ArgumentException("Unsupported MessageType for NLogger.Log");
        //    }
        //}
        //public bool IsDebugEnabled
        //{
        //    get { return log.IsDebugEnabled; }
        //}
        #endregion

        
    }
}
