using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User
{
    public class Calculations
    {
        public string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            try
            {
                List<string> ranges = new List<string>();

                var time = beginWorkingTime;


                for (int i = 0; i < startTimes.Length && time < endWorkingTime;)
                {
                    if (time + new TimeSpan(0, consultationTime, 0) <= startTimes[i])
                    {
                        var new_time = new TimeSpan(0, consultationTime, 0);
                        ranges.Add($"{time:hh}:{time:mm}-{time + new_time:hh}:{time + new_time:mm}");
                        time += new_time;
                    }
                    else
                    {
                        time = startTimes[i] + new TimeSpan(0, durations[i], 0);
                        i++;
                    }
                }

                while (time < endWorkingTime)
                {
                    var new_time = new TimeSpan(0, consultationTime, 0);
                    ranges.Add($"{time:hh}:{time:mm}-{time + new_time:hh}:{time + new_time:mm}");
                    time += new_time;
                }

                return ranges.ToArray();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
