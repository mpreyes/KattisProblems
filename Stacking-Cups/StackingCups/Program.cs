using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;


namespace StackingCups
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<String> p = new List<string>();

            for (int i = 0; i < N; i++)
            {
                List<String> l = Console.ReadLine().Split(' ').ToList();
                //Console.WriteLine(l[0]);
                //Console.WriteLine(l[1]);
                int num;
                if(Int32.TryParse(l[0], out num)){
                    double Gp = double.Parse(l[0]) / 2;
                   // Console.Write("Hello"+ Gp);
                    p.Add(Gp.ToString() + " "+ l[1]);
                    l.Remove(l[0]);
                    l.Remove(l[0]);
           
                }
                else{
                    p.Add(l[1] + " " + l[0]);          
                    l.Remove(l[0]);
                    l.Remove(l[0]);

                }

                }


			var ordered = p.Select(s => new { Str = s, Split = s.Split(' ') })
			 .OrderBy(x => int.Parse(x.Split[0]))
			 .ThenBy(x => x.Split[1])
			 .Select(x => x.Str)
			 .ToList();

			foreach (string s in ordered)
				Console.WriteLine(Regex.Replace(s, "[^a-zA-Z]", String.Empty));
            
            //for (int j = 0; j < p.Count; j++){
              // Console.WriteLine(p[j]);
               // Console.WriteLine(ordered.ToString());
               // Console.WriteLine(Regex.Replace(p[j], "[^a-zA-Z]", String.Empty));
           // }
           






        }

	

    }

}