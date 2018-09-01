using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;

namespace CSHARPStandard.Diagnostics.IoT
{
    public class IoTFileSystemEventLog : IEventLog
    {
        /// <summary>
        /// Connection string used to write to log
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Additional parameters used to write to log
        /// </summary>
        public string Parameters { get; set; }

        /// <summary>
        /// Levels to log (0 = all, 1 to 10 level of verbosity)
        /// </summary>
        public int VerboseLevel { get { return 0; /* TO DO: Should read from app.config */ } }

        /// <summary>
        /// Writes event message to log
        /// </summary>
        /// <param name="level">1 to 10 increased level of verbosity</param>
        /// <param name="message">message to write</param>
        /// <remarks>V1.0.0.1 Added end of line marker for console error messages if error message does not end in end of line marker.</remarks>
        public void LogEvent(int level, string message)
        {
        }

        private static async Task WriteLog(string strLog, string strFormat, params string[] strParams)
        {
            DateTime dtNow;
            string strLogFile;
            string strLogData;
            StorageFolder storageFolder;
            StorageFile storageFile;

            try
            {
                dtNow = DateTime.Now;
                strLogFile = string.Format("{0}_{1}.Log", strLog, dtNow.ToString("yyyyMMdd"));
                strLogData = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss.ff ") + string.Format(strFormat, strParams);

                Debug.WriteLine(strLogData);

                // Apply Asynchronous Lock here
                {
                    storageFolder = ApplicationData.Current.LocalFolder;
                    storageFile = await storageFolder.CreateFileAsync(strLogFile, CreationCollisionOption.OpenIfExists);

                    using (StreamWriter writer = new StreamWriter(await storageFile.OpenStreamForWriteAsync()))
                    {
                        writer.BaseStream.Seek(0, SeekOrigin.End);
                        await writer.WriteLineAsync(strLogData);
                        writer.Flush();
                    }
                }
            }
            catch (Exception eException)
            {
                Debug.WriteLine(string.Format("Error: WriteSystemLog() {0}", eException.Message));
            }
        }

        public void FlushEventLog()
        {
            throw new NotImplementedException();
        }

        public void LogEvent(int level, string message)
        {
            throw new NotImplementedException();
        }
    }
}
