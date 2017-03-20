/********************************************************************************
 * CSHARP Windows Diagnostics Library - General utility to write log messages to 
 * different log types. 
 * 
 * NOTE: Adapted from Clinch.Core
 * 
 * LICENSE: Free to use provided details on fixes and/or extensions emailed to 
 *          chris.williams@readwatchcreate.com
 ********************************************************************************/

using System;
using System.Diagnostics;

namespace CSHARP.Diagnostics.Windows
{
    /// <summary>
    /// Logs events to a Windows Event Logs
    /// </summary>
    public class WindowsEventLog : IEventLog
    {
        /// <summary>
        /// WARNING: Not Applicable to this event log, use EventLogTextBox instead
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
        /// Name of application appended to log entries
        /// </summary>
        public string ApplicationName { get; set; }
        
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
            if (VerboseLevel != 0 && level > VerboseLevel) return;
            
            if (!EventLog.SourceExists(ApplicationName, Environment.MachineName))
            {
                EventLog.CreateEventSource(
                    new EventSourceCreationData(
                        ApplicationName,
                        Environment.MachineName
                        )
                    );
            }

            EventLog.WriteEntry(ApplicationName, message);
        }
    }
}
