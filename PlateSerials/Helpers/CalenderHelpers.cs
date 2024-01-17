using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlateSerials.Helpers
{
    public static class CalenderHelpers
    {
        public static string ToShamsi(this DateTime miladiDate)
        {
            PersianCalendar persianCalendar = new PersianCalendar();

            // Convert the Gregorian date to Shamsi
            int year = persianCalendar.GetYear(miladiDate);
            int month = persianCalendar.GetMonth(miladiDate);
            int day = persianCalendar.GetDayOfMonth(miladiDate);

            // Format the Shamsi date
            return $"{year:0000}/{month:00}/{day:00}";
        }

        public static string ToShamsiWithTime(this DateTime miladiDate)
        {
            PersianCalendar persianCalendar = new PersianCalendar();

            // Convert the Gregorian date to Shamsi
            int year = persianCalendar.GetYear(miladiDate);
            int month = persianCalendar.GetMonth(miladiDate);
            int day = persianCalendar.GetDayOfMonth(miladiDate);

            // Format the Shamsi date
            return $"{year:0000}/{month:00}/{day:00} | {miladiDate.ToString("HH:mm:ss")}";
        }
    }
}
