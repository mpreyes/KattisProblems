using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Datum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String[] input = Console.ReadLine().Split(' ');
			String[] dw = { "Saturday","Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
            int day = int.Parse(input[0]);
            int month = int.Parse(input[1]);
            //using the key value method
            int result = 0;
            int y = (09/4) *5;
            int r = 09 % 4;
            int p = y % 7;
            int yearcode = r + p;
           // Console.WriteLine("year code"+ y);
           // int c = 6; //century code
            int[] keyval = {-1,1,4,4,0,2,5,0,3,6,1,4,6};
            // Console.WriteLine("r "+result);
            int monthval = 0;
			for (int i = 0; i < keyval.Length; i++)
			{
				//Console.WriteLine(i);
               // Console.WriteLine("K "+ keyval[i]);
				if (month == i)
				{
                   // Console.WriteLine("i"+( i));
                   // Console.WriteLine(i);
                    monthval = keyval[i]; //adding the month code
					
				}
			}
            //Console.WriteLine("m"+monthval);
            //  Console.WriteLine("monthcode"+re
            // Console.WriteLine("result"+result);
            int rock = (day + monthval + yearcode + 6) % 7;
            result += (y + 6 + 09);
            result %= 7;
            for (int j = 0; j < dw.Length; j++){
                if(rock == j){
                    Console.WriteLine(dw[j]);
                }
            }



           
           


		}
    }
}
