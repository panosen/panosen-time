using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Panosen.Time.Test
{
    [TestClass]
    public class TimeConvertTest
    {
        [TestMethod]
        public void ToTicks()
        {
            DateTimeOffset time = new DateTimeOffset(2018, 9, 27, 21, 01, 34, new TimeSpan(8, 0, 0));
            var ticks = 1538053294;

            Assert.AreEqual(ticks, TimeConvert.ToTicks(time));
        }

        [TestMethod]
        public void TestSecond()
        {
            DateTimeOffset time = new DateTimeOffset(2018, 9, 27, 21, 01, 34, new TimeSpan(8, 0, 0));
            var ticks = 1538053294;

            Assert.AreEqual(time, TimeConvert.FromTicks(ticks));
        }

        [TestMethod]
        public void ToMilliTicks1()
        {
            var time = new DateTimeOffset(2018, 9, 27, 21, 01, 34, new TimeSpan(8, 0, 0));
            var millsTicks = 1538053294000;

            Assert.AreEqual(millsTicks, TimeConvert.ToMilliTicks(time));
        }

        [TestMethod]
        public void ToMilliTicks2()
        {
            var time = new DateTimeOffset(2018, 9, 27, 21, 01, 34, 304, new TimeSpan(8, 0, 0));
            var millsTicks = 1538053294304;

            Assert.AreEqual(millsTicks, TimeConvert.ToMilliTicks(time));
        }

        [TestMethod]
        public void FromMilliTicks1()
        {
            var time = new DateTimeOffset(2018, 9, 27, 21, 01, 34, new TimeSpan(8, 0, 0));
            var millsTicks = 1538053294000;

            Assert.AreEqual(time, TimeConvert.FromMilliTicks(millsTicks));
        }

        [TestMethod]
        public void FromMilliTicks2()
        {
            var time = new DateTimeOffset(2018, 9, 27, 21, 01, 34, 567, new TimeSpan(8, 0, 0));
            var millsTicks = 1538053294567;

            Assert.AreEqual(time, TimeConvert.FromMilliTicks(millsTicks));
        }
    }

}
