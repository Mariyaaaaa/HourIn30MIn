using System;

namespace Start
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            int newMinutes = minutes + 30;
            


            if (newMinutes >= 60 )
            {
                hour= hour + 1;
                newMinutes = newMinutes - 60;
            }
            if (hour >= 24)
            {
                hour = 0;
            }
            if (newMinutes < 10)
            {
                Console.WriteLine($"{hour}:{newMinutes:D2}");
            }
            else
            {
                 Console.WriteLine($"{hour}:{newMinutes}");

            }

        }
    }
}
