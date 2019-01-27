using System;
using System.Text;
using System.Collections.Generic;

namespace Soylent
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++){
                
                
                Console.WriteLine( Math.Ceiling(double.Parse(Console.ReadLine()) / 400));
            }
        }
    }
}
