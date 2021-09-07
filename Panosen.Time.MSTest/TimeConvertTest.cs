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
            var time = new DateTime(2018, 9, 27, 21, 01, 34, DateTimeKind.Local);
            var ticks = 1538053294;

            Assert.AreEqual(ticks, TimeConvert.ToTicks(time));
        }

        [TestMethod]
        public void TestSecond()
        {
            var time = new DateTime(2018, 9, 27, 21, 01, 34, DateTimeKind.Local);
            var ticks = 1538053294;

            Assert.AreEqual(time, TimeConvert.FromTicks(ticks));
        }

        [TestMethod]
        public void ToMilliTicks()
        {
            {
                var time = new DateTime(2018, 9, 27, 21, 01, 34, DateTimeKind.Local);
                var millsTicks = 1538053294000;

                Assert.AreEqual(millsTicks, TimeConvert.ToMilliTicks(time));
            }

            {
                var time = new DateTime(2018, 9, 27, 21, 01, 34, 304, DateTimeKind.Local);
                var millsTicks = 1538053294304;

                Assert.AreEqual(millsTicks, TimeConvert.ToMilliTicks(time));
            }
        }

        [TestMethod]
        public void FromMilliTicks()
        {
            {
                var time = new DateTime(2018, 9, 27, 21, 01, 34, DateTimeKind.Local);
                var millsTicks = 1538053294000;

                Assert.AreEqual(time, TimeConvert.FromMilliTicks(millsTicks));
            }

            {
                var time = new DateTime(2018, 9, 27, 21, 01, 34, 567, DateTimeKind.Local);
                var millsTicks = 1538053294567;

                Assert.AreEqual(time, TimeConvert.FromMilliTicks(millsTicks));
            }
        }
    }

}
