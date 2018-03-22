using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibaryData.Models;

namespace LibraryServices
{
    public class DataHelpers
    {
        public static IEnumerable<string> HumanizeBusinessHours(IEnumerable<BranchHours> branchHours)
        {
            var hours = new List<string>();
            foreach (var time in branchHours)
            {
                var day = HumanizeDay(time.DayOfWeek);
                var openTime = HumanizeTime(time.OpenTime);
                var closeTime = HumanizeTime(time.CloseTime);

                var timeEntry = $"{day} {openTime} to {closeTime}";
                hours.Add(timeEntry);
            }

            return hours;
        }

        private static string HumanizeTime(int time)
        {
            return TimeSpan.FromHours(time).ToString("hh' : 'mm");
        }

        private static string HumanizeDay(int number)
        {
            return Enum.GetName(typeof(DayOfWeek), number);

        }

        
    }
}
