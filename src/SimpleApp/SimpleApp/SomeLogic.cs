using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleApp
{
    public class SomeLogic
    {
        public string GetDayOfWeek(DateTime date)
        {
            return date.DayOfWeek.ToString();
        }
    }
}
