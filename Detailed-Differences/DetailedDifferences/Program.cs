using System;
using System.Collections.Generic;
using System.Linq;

namespace DetailedDifferences
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++){

                List<char> l = Console.ReadLine().ToCharArray().ToList();
                List<char> p = Console.ReadLine().ToCharArray().ToList();
                String result = "";

                for (int j = 0; j < l.Count; j++){
                    if(l[j].Equals(p[j])){
                        result += ".";
                    }
                    else{
                        result += "*";
                    }

                }
                string f = "";
                string s = "";
                foreach(char e in l){
                    f += e;
                }
				foreach (char v in p)
				{
					s += v;
				}
				Console.WriteLine(f);
				Console.WriteLine(s);
                Console.WriteLine(result);
                Console.WriteLine();
                l.Clear();
                p.Clear();
                result = "";
                f = "";
                s = "";

            }



        }
    }
}
