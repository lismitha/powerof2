﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccprogram
{
    public class flipcoin
    {
        public static void Headortail()
        {
            string[] coin = { "heads", "tails" };
            int user;
            int heads = 0;
            int tails = 0;
            var rand = new Random();
            const int faces = 2;


            Console.Write("enter 1 to flip a coin, or 2 to leave: ");
            user = Convert.ToInt32(Console.ReadLine());

            while (user == 1)
            {
                int second = rand.Next(faces);
                if (second == 1)
                {
                    Console.WriteLine("coin landed on heads");
                    heads += 1;
                    Console.WriteLine($"you have landed on heads: {heads} time(s)");

                    Console.WriteLine($"you have landed on tails: {tails} time(s)");
                }
                else
                {
                    Console.WriteLine("coin landed on tails");
                    tails += 1;
                    Console.WriteLine($"you have landed on heads: {heads} time(s)");

                    Console.WriteLine($"you have landed on tails: {tails} time(s)");
                }
                    Console.Write("enter 1 to flip again, or 2 to leave: ");
                     user = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
