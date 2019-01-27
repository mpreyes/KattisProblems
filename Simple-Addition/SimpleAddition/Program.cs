using System;
using System.IO;
using Microsoft.CSharp;
using System.Numerics;


namespace SimpleAddition
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BigInteger one = BigInteger.Parse(Console.ReadLine());
            BigInteger two = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(one + two);
         



        }
    }
}
