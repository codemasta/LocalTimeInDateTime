using System;

namespace DateTimeOffSet_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentTime = DateTime.Now;
            var nigerianTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, "W. Central Africa Standard Time");
            Console.WriteLine(nigerianTime.ToLongTimeString());
            Console.ReadLine();
        }
    }
}
