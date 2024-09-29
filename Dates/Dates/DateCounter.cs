using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    internal class DateCounter
    { 
        public int CalculateDifference(string date1, string date2)
        {
            DateTime Sdate1 = DateTime.Parse(date1);
            DateTime Sdate2 = DateTime.Parse(date2);

            TimeSpan diff = Sdate2 - Sdate1;
            return Math.Abs(diff.Days);

        }
    }
}
