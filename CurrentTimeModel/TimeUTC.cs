using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentTimeModel
{
    public class TimeUTC : ITime
    {
        public DateTime GetCurrentUTCTime(int? hour = null, int? minute = null)
        {
            return DateTime.UtcNow.AddMinutes(minute ?? 0).AddHours(hour ?? 0);
        }
    }
}
