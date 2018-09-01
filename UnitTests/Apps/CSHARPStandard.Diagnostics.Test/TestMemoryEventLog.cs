namespace CSHARPStandard.Diagnostics.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestMemoryEventLog
    {
        [TestMethod]
        public void TestLogEventLevelWithinRange()
        {
            var eventLog = new MemoryEventLog
            {
                ConnectionString = string.Empty
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
            var eventLog = new MemoryEventLog
            {
                ConnectionString = string.Empty
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
            var eventLog = new MemoryEventLog
            {
                ConnectionString = string.Empty
            };
            eventLog.LogEvent(-1, string.Empty);
        }

        [TestMethod]
        public void TestLogEventEmptyMessageLevelAboveRange()
        {
            var eventLog = new MemoryEventLog
            {
                ConnectionString = string.Empty
            };
            eventLog.LogEvent(11, string.Empty);
        }

        [TestMethod]
        public void TestLogEventLevelBelowRange()
        {
            var eventLog = new MemoryEventLog
            {
                ConnectionString = string.Empty
            };
            eventLog.LogEvent(-1, "LEVEL -1");
        }

        [TestMethod]
        public void TestLogEventLevelAboveRange()
        {
            var eventLog = new MemoryEventLog
            {
                ConnectionString = string.Empty
            };
            eventLog.LogEvent(-1, "LEVEL 11");
        }

        [TestMethod]
        public void TestFlushEventLog()
        {
        }
    }
}
