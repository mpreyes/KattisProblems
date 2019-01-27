using System;

namespace SodaSurpler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] l = Console.ReadLine().Split(' ');
            int e = int.Parse(l[0]); //number of empty bottles at start of day
            int f = int.Parse(l[1]); //number of emplty bottles found during the day
            int c = int.Parse(l[2]); //empty bottles required to buy a new soda

            int total = 0;
            int fs = e / c;
            int ef = e % c;
            total = fs;
            int bottles = (fs + ef + f);
           // Console.WriteLine("bottles start "+ bottles);
          //  Console.WriteLine("initial t "+ total );

            while (bottles >= c)
            {
				int bot = bottles / c;
               // Console.WriteLine("bot "+ bot);
                int rem = bottles % c;
                //Console.WriteLine("rem "+ rem);
                total += bot;
                bottles = (bot + rem);
				//Console.WriteLine("bottles "+ bottles);
				//Console.WriteLine("total "+total);
			}

            Console.WriteLine(total);

        }
    }
}
