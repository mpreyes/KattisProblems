using System;
using System.Linq;
using System.Collections.Generic;
namespace Kornislav
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string [] l = Console.ReadLine().Split(' ');
            List<int> p = new List<int>();

            for (int i = 0; i < l.Length; i++){
                p.Add(int.Parse(l[i]));
            }
            p.Sort();

            Console.WriteLine(p[2] * p[0]);

             
		
        



		}
    }
}
