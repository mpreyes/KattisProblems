using System;
using System.Linq;
using System.Collections.Generic;

namespace Eligibility
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<String> l = new List<string>();

            for (int i = 0; i < N; i++){
				l = Console.ReadLine().Split(' ').ToList();
				List<String> date = l[1].Split('/').ToList();
                List<String> dob = l[2].Split('/').ToList();
                if(int.Parse(date[0]) >= 2010){
                    Console.WriteLine(l[0] + " eligible");
                }
                else if(int.Parse(dob[0]) >= 1991){
                    
					Console.WriteLine(l[0] + " eligible");
                }
                else if (int.Parse(l[3]) >= 41){
                    Console.WriteLine(l[0] + " ineligible");
                }
                else{
					Console.WriteLine(l[0] + " coach petitions");
                    
                }

                l.Clear();
                date.Clear();
                dob.Clear();
              
            }
           



        }
    }
}
