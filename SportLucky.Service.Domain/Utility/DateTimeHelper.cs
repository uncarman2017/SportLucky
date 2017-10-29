using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportLucky.Service.Domain.Utility
{
    public class DateTimeHelper
    {
        /// <summary>
        /// 获取某天是一年中的第几周
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static int WeekOfYear(DateTime dateTime)
        {
            int firstdayofweek = System.Convert.ToDateTime(dateTime.Year.ToString() + "- " + "1-1 ").DayOfWeek.GetHashCode();
            int days = dateTime.DayOfYear;
            int daysOutOneWeek = days - (7 - firstdayofweek);
            if (daysOutOneWeek <= 0)
            {
                return 1;
            }
            else
            {
                int weeks = daysOutOneWeek / 7;
                if (daysOutOneWeek % 7 != 0)
                {
                    weeks++;
                }
                return weeks;
            }
        }
    }
}
