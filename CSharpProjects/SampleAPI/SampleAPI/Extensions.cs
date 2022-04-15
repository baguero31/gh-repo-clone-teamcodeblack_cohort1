using System;

namespace SampleAPI
{
    public static class Extensions
    {
        internal static DateTime GetDate(string dateIn)
        {
            if (DateTime.TryParseExact(dateIn, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture,
                System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            {
                return parsedDate;
            }
            else
            {
                return DateTime.Today;
            }
        }
    }
}
