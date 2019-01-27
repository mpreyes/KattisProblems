using System;
using System.IO;



namespace PervasiveHeartMonitor
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            string c = Console.ReadLine();

            while (!string.IsNullOrEmpty(c))
            {
				String[] l = c.Split(' ');
                decimal avgheart = 0;
                string name = "";
                int count = 0;
                decimal num;

                for (int i = 0; i < l.Length; i++)
                {
                    if (decimal.TryParse(l[i], out num))
                    {

                        avgheart += decimal.Parse(l[i]);
                        count++;
                    }
                    else
                    {
                        name += l[i] + " ";
                    }
                }

                decimal result = 0;

                if(count == 0){
                    Console.WriteLine(avgheart);
                }
                else{
					 result = avgheart / count;
                }


                Console.WriteLine(result + " " + name);
                result = 0;
                name = "";
                count = 0;
                c = Console.ReadLine();
            }

              
            




       
            




            }
    }
}
