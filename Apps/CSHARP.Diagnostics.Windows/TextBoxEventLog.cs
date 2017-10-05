/********************************************************************************
 * CSHARP Windows Diagnostics Library - General utility to write log messages to 
 * different log types. 
 * 
 * NOTE: Adapted from Clinch.Core
 * 
 *          chris.williams@readwatchcreate.com
 ********************************************************************************/

using System;
using System.Windows.Forms;

namespace CSHARP.Diagnostics.Windows
{
    /// <summary>
    /// Logs events to a Windows TextBox
    /// </summary>
    public class TextBoxEventLog : IEventLog
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
        /// TextBox to write event log to
        /// </summary>
        public TextBox EventLogTextBox { get; set; }

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
            if (VerboseLevel == 0 || level <= VerboseLevel) EventLogTextBox.Text = EventLogTextBox.Text + message;

            // This will pause the thread so it can display the log message.
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
        }

    }
}
