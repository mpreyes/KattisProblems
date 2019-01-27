using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;

namespace DifferentDistances
{
    class MainClass
    {
        public static void Main(string[] args)
        {



            for (int i = 0; i < 1000; i++)
            {
                List<String> l = Console.ReadLine().Split(' ').ToList();
                decimal x1 = decimal.Parse(l[0]);
                if (x1 == 0)
                {
                    break;
                }

                decimal y1 = decimal.Parse(l[1]);

                decimal x2 = decimal.Parse(l[2]);
                decimal y2 = decimal.Parse(l[3]);
                decimal p = decimal.Parse(l[4]);
                // Console.WriteLine("x1 " + x1 + "x2 " + x2 + "y1 " + y1 + "y2 " + y2 + "p " + p);
                decimal result = 0;

                decimal xdiff = Math.Abs(x1 - x2);
                decimal ydiff = Math.Abs(y1 - y2);
                double xpow = Math.Pow((double)xdiff, (double)p);
                double ypow = Math.Pow((double)ydiff, (double)p);
                // Console.WriteLine(xpow + " " + ypow);

                result = (decimal)Math.Pow(xpow + ypow, (double)(1 / p));
                Console.WriteLine(result);
                l.Clear();
            }



        }
    }
}
