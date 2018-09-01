namespace CSHARPStandard.Diagnostics.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class TestFileSystemEventLog
    {
        [TestMethod]
        public void TestLogEventLevelWithinRange()
        {
            string FileSystemConnectionString = "log_" + System.DateTime.Now.Year + "_" + System.DateTime.Now.Month + "_" + System.DateTime.Now.Day + "_" + System.DateTime.Now.Hour + ".txt";
            var eventLog = new FileSystemEventLog
            {
                ConnectionString = FileSystemConnectionString
            };
            eventLog.LogEvent(0, "LEVEL 0 - SUCCESS");
            eventLog.LogEvent(1, "LEVEL 1 - SUCCESS");
            eventLog.LogEvent(2, "LEVEL 2 - SUCCESS");
            eventLog.LogEvent(3, "LEVEL 3 - SUCCESS");
            eventLog.LogEvent(4, "LEVEL 4 - SUCCESS");
            eventLog.LogEvent(5, "LEVEL 5 - SUCCESS");
            eventLog.LogEvent(6, "LEVEL 6 - SUCCESS");
            eventLog.LogEvent(7, "LEVEL 7 - SUCCESS");
            eventLog.LogEvent(8, "LEVEL 8 - SUCCESS");
            eventLog.LogEvent(9, "LEVEL 9 - SUCCESS");
            eventLog.LogEvent(10, "LEVEL 10 - SUCCESS");
        }

        [TestMethod]
        public void TestLogEventEmptyMessageLevelWithinRange()
        {
            string FileSystemConnectionString = "log_" + System.DateTime.Now.Year + "_" + System.DateTime.Now.Month + "_" + System.DateTime.Now.Day + "_" + System.DateTime.Now.Hour + ".txt";
            var eventLog = new FileSystemEventLog
            {
                ConnectionString = FileSystemConnectionString
            };
            eventLog.LogEvent(0, string.Empty);
            eventLog.LogEvent(1, string.Empty);
            eventLog.LogEvent(2, string.Empty);
            eventLog.LogEvent(3, string.Empty);
            eventLog.LogEvent(4, string.Empty);
            eventLog.LogEvent(5, string.Empty);
            eventLog.LogEvent(6, string.Empty);
            eventLog.LogEvent(7, string.Empty);
            eventLog.LogEvent(8, string.Empty);
            eventLog.LogEvent(9, string.Empty);
            eventLog.LogEvent(10, string.Empty);
        }

        [TestMethod]
        public void TestLogEventEmptyMessageLevelBelowRange()
        {
            string FileSystemConnectionString = "log_" + System.DateTime.Now.Year + "_" + System.DateTime.Now.Month + "_" + System.DateTime.Now.Day + "_" + System.DateTime.Now.Hour + ".txt";
            var eventLog = new FileSystemEventLog
            {
                ConnectionString = FileSystemConnectionString
            };
            eventLog.LogEvent(-1, string.Empty);
        }

        [TestMethod]
        public void TestLogEventEmptyMessageLevelAboveRange()
        {
            string FileSystemConnectionString = "log_" + System.DateTime.Now.Year + "_" + System.DateTime.Now.Month + "_" + System.DateTime.Now.Day + "_" + System.DateTime.Now.Hour + ".txt";
            var eventLog = new FileSystemEventLog
            {
                ConnectionString = FileSystemConnectionString
            };
            eventLog.LogEvent(11, string.Empty);
        }

        [TestMethod]
        public void TestLogEventLevelBelowRange()
        {
            string FileSystemConnectionString = "log_" + System.DateTime.Now.Year + "_" + System.DateTime.Now.Month + "_" + System.DateTime.Now.Day + "_" + System.DateTime.Now.Hour + ".txt";
            var eventLog = new FileSystemEventLog
            {
                ConnectionString = FileSystemConnectionString
            };
            eventLog.LogEvent(-1, "LEVEL -1");
        }

        [TestMethod]
        public void TestLogEventLevelAboveRange()
        {
            string FileSystemConnectionString = "log_" + System.DateTime.Now.Year + "_" + System.DateTime.Now.Month + "_" + System.DateTime.Now.Day + "_" + System.DateTime.Now.Hour + ".txt";
            var eventLog = new FileSystemEventLog
            {
                ConnectionString = FileSystemConnectionString
            };
            eventLog.LogEvent(-1, "LEVEL 11");
        }

        [TestMethod]
        public void TestLogEventLevelWithinRangeNoFileName()
        {
            string FileSystemConnectionString = "log_" + System.DateTime.Now.Year + "_" + System.DateTime.Now.Month + "_" + System.DateTime.Now.Day + "_" + System.DateTime.Now.Hour + ".txt";
            var eventLog = new FileSystemEventLog
            {
                ConnectionString = string.Empty
            };

            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(0, "LEVEL 0 - SUCCESS"));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(1, "LEVEL 1 - SUCCESS"));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(2, "LEVEL 2 - SUCCESS"));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(3, "LEVEL 3 - SUCCESS"));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(4, "LEVEL 4 - SUCCESS"));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(5, "LEVEL 5 - SUCCESS"));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(6, "LEVEL 6 - SUCCESS"));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(7, "LEVEL 7 - SUCCESS"));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(8, "LEVEL 8 - SUCCESS"));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(9, "LEVEL 9 - SUCCESS"));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(10, "LEVEL 10 - SUCCESS"));
        }

        [TestMethod]
        public void TestLogEventEmptyMessageLevelWithinRangeNoFileName()
        {
            string FileSystemConnectionString = "log_" + System.DateTime.Now.Year + "_" + System.DateTime.Now.Month + "_" + System.DateTime.Now.Day + "_" + System.DateTime.Now.Hour + ".txt";
            var eventLog = new FileSystemEventLog
            {
                ConnectionString = string.Empty
            };
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(0, string.Empty));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(1, string.Empty));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(2, string.Empty));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(3, string.Empty));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(4, string.Empty));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(5, string.Empty));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(6, string.Empty));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(7, string.Empty));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(8, string.Empty));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(9, string.Empty));
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(10, string.Empty));
        }

        [TestMethod]
        public void TestLogEventEmptyMessageLevelBelowRangeNoFileName()
        {
            string FileSystemConnectionString = "log_" + System.DateTime.Now.Year + "_" + System.DateTime.Now.Month + "_" + System.DateTime.Now.Day + "_" + System.DateTime.Now.Hour + ".txt";
            var eventLog = new FileSystemEventLog
            {
                ConnectionString = string.Empty
            };
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(-1, string.Empty));
        }

        [TestMethod]
        public void TestLogEventEmptyMessageLevelAboveRangeNoFileName()
        {
            string FileSystemConnectionString = "log_" + System.DateTime.Now.Year + "_" + System.DateTime.Now.Month + "_" + System.DateTime.Now.Day + "_" + System.DateTime.Now.Hour + ".txt";
            var eventLog = new FileSystemEventLog
            {
                ConnectionString = string.Empty
            };
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(11, string.Empty));
        }

        [TestMethod]
        public void TestLogEventLevelBelowRangeNoFileName()
        {
            string FileSystemConnectionString = "log_" + System.DateTime.Now.Year + "_" + System.DateTime.Now.Month + "_" + System.DateTime.Now.Day + "_" + System.DateTime.Now.Hour + ".txt";
            var eventLog = new FileSystemEventLog
            {
                ConnectionString = string.Empty
            };
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(-1, "LEVEL -1"));
        }

        [TestMethod]
        public void TestLogEventLevelAboveRangeNoFileName()
        {
            string FileSystemConnectionString = "log_" + System.DateTime.Now.Year + "_" + System.DateTime.Now.Month + "_" + System.DateTime.Now.Day + "_" + System.DateTime.Now.Hour + ".txt";
            var eventLog = new FileSystemEventLog
            {
                ConnectionString = string.Empty
            };
            Assert.ThrowsException<ArgumentException>(() => eventLog.LogEvent(-1, "LEVEL 11"));
        }

        [TestMethod]
        public void TestFlushEventLog()
        {
        }
    }
}
