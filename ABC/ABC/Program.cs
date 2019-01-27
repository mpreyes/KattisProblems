using System;
using System.Text;
using System.Collections.Generic;

namespace ABC
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string [] nums = input.Split(' ');
           
            List<int> l = new List<int> { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2])};
            string order = Console.ReadLine();
            l.Sort();
            int A = l[0];
            int B = l[1];
            int C = l[2];
           // Console.WriteLine("A " + A + "B " + B + "C " + C);

            foreach( char c in order){
                if(c == 'A'){
                    Console.Write(A + " ");
                }
                else if(c == 'B'){
                    Console.Write(B + " ");
                }
                else{
                    Console.Write(C + " ");
                }
            }


        }
    }
}
