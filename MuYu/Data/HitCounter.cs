using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MuYu.Data
{
    public static class HitCounter
    {
        private static long count;
        private static long todayCount;
        private static string today;

        static HitCounter()
        {
            count = Preferences.Default.Get("all_num", 0L);
            todayCount = 0;
            today = DateTime.Now.ToShortDateString();
            if (today == Preferences.Default.Get("today", ""))
            {
                todayCount = Preferences.Default.Get("today_num", 0L);
            }
        }

        /// <summary>
        /// 敲击后更新计数
        /// </summary>
        public static void Increment()
        {
            if (today != DateTime.Now.ToShortDateString())
            {
                today = DateTime.Now.ToShortDateString();
                todayCount = 0;
            }
            count++;
            todayCount++;
        }

        /// <summary>
        /// 保存数据到 Preferences
        /// </summary>
        public static void Save()
        {
            if (today != DateTime.Now.ToShortDateString())
            {
                today = DateTime.Now.ToShortDateString();
                todayCount = 0;
            }
            Preferences.Default.Set("today_num", todayCount);
            Preferences.Default.Set("today", today);
            Preferences.Default.Set("all_num", count);
        }

        /// <summary>
        /// 重置计数
        /// </summary>
        public static void Reset()
        {
            count = 0;
            todayCount = 0;
            Save();
        }

        /// <summary>
        /// 总计数
        /// </summary>
        public static long Count
        {
            get { return count; }
        }

        /// <summary>
        /// 当日计数
        /// </summary>
        public static long TodayCount
        {
            get { return todayCount; }
        }
    }
}
