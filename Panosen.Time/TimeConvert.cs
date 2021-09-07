using System;

namespace Panosen.Time
{
    /// <summary>
    /// 时间转换器
    /// </summary>
    public static class TimeConvert
    {
        /// <summary>
        /// 基准时间
        /// </summary>
        public static readonly DateTime TimeBase = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// 转换为秒需要用到的
        /// </summary>
        private const int SecondBase = 10000_000;

        /// <summary>
        /// 转换为毫秒需要用到的
        /// </summary>
        private const int MillsSecondBase = 10000;

        /// <summary>
        /// 将秒数转换为时间
        /// </summary>
        /// <param name="ticks">从1970年1月1日00:00:00至起用时间的秒数</param>
        /// <returns>转换后的时间</returns>
        public static DateTimeOffset FromTicks(long ticks)
        {
            return new DateTime(TimeBase.Ticks + ticks * SecondBase, DateTimeKind.Utc).ToLocalTime();
        }

        /// <summary>
        /// 将时间转换为秒数
        /// </summary>
        /// <param name="time">需要转换的时间</param>
        /// <returns>从1970年1月1日00:00:00至起用时间的秒数</returns>
        public static long ToTicks(DateTimeOffset time)
        {
            return (time.ToUniversalTime() - TimeBase).Ticks / SecondBase;
        }

        /// <summary>
        /// 将毫秒数转换为时间
        /// </summary>
        /// <param name="millsTicks">从1970年1月1日00:00:00至起用时间的毫秒数</param>
        /// <returns>转换后的时间</returns>
        public static DateTimeOffset FromMilliTicks(long millsTicks)
        {
            return new DateTime(TimeBase.Ticks + millsTicks * MillsSecondBase, DateTimeKind.Utc).ToLocalTime();
        }

        /// <summary>
        /// 将时间转换为毫秒数
        /// </summary>
        /// <param name="time">需要转换的时间</param>
        /// <returns>从1970年1月1日00:00:00至起用时间的毫秒数</returns>
        public static long ToMilliTicks(DateTimeOffset time)
        {
            return (time.ToUniversalTime() - TimeBase).Ticks / MillsSecondBase;
        }
    }

}
