using Nager.Date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitauswertung
{
    class DateChecker
    {
        public bool isWorkDay(DateTime date)
        {
            if (DateSystem.IsWeekend(date, CountryCode.DE))
            {
                return false;
            }
            if (DateSystem.IsPublicHoliday(date, CountryCode.DE))
            {
                return false;
            }

            var publicHolidays = DateSystem.GetPublicHoliday(DateTime.Now.Year, "DE");
            object[] test;
            foreach (var publicHoliday in publicHolidays)
            {
                test = publicHoliday.Counties;
            }

                return true;
        }
    }
}
