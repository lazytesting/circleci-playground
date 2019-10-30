using System;

namespace SimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Now;
            var logic = new SomeLogic();
            var day = logic.GetDayOfWeek(today);
            Console.WriteLine("Hello World! i's " + day);
        }
    }
}
