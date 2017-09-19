using System;
using Sitecore.Diagnostics;

namespace CSHARP.Diagnostics.Sitecore
{
    /// <summary>
    /// Sitecore Event Log Handler
    /// </summary>
    public class SitecoreLogEventLog : IEventLog
    {
        /// <summary>
        /// WARNING: Not Applicable to this event log. Automatically uses Sitecore.Diagnostics.Log
        /// </summary>
        public string ConnectionString 
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// WARNING: Not Applicable to this event log, use EventLogTextBox instead
        /// </summary>
        public string Parameters
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Levels to log (0 = all, 1 to 10 level of verbosity)
        /// </summary>
        public int VerboseLevel { get { return 0; /* TO DO: Should read from app.config */ } }

        /// <summary>
        /// Flushes log events to textbox 
        /// </summary>
        public void FlushEventLog()
        {
            // TO DO: Could provide cached writing 
            return;
        }

        /// <summary>
        /// Writes event message to log
        /// </summary>
        /// <param name="level">1 to 10 increased level of verbosity</param>
        /// <param name="message">message to write</param>
        public void LogEvent(int level, string message)
        {
            if (VerboseLevel == 0 || level <= VerboseLevel)
            {
                Log.Error(message, this);
            } 
        }

    }
}
