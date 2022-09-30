using System;
namespace Uppgift_3._15
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int Tim = int.Parse(Console.ReadLine());
            int Tot = Tim * 80;
            
            if (Tim <= 11)
            {
                Console.WriteLine("Okej det kommer att kosta " + Tot + "kr");
            }
            else if (Tim >= 11)
            {
                Console.WriteLine("Du får tyvär inte hyra bilen, det är för många timmar");
            }

        
         
        }
    }
}