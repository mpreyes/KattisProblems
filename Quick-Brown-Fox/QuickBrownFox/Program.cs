using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace QuickBrownFox
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            List<char> A = new List<char>(new char [] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' });
            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine().ToLower();
                s = Regex.Replace(s, @"[^A-Za-z0-9]+", "");
                 s = Regex.Replace(s, "[0-9]", "");
               // Console.WriteLine("s: "+ s);
                string result = "";

                foreach (char p in s)
                {
                    if(A.Contains(p)){
                        A.Remove(p); 
                    }
                }
                for (int j = 0; j < A.Count;j++){
                    
                    result += A[j];
                }

                if (result.Equals(""))
                {
                    Console.WriteLine("pangram");
                }
                else
                {
                    Console.WriteLine("missing " + result);
					
                }
				A.Clear();
				A = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
				result = "";
            }
           

        
    }

}
}
