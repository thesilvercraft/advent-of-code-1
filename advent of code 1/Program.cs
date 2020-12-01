using System;
using System.Collections.Generic;
using System.IO;

namespace advent_of_code_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<long> e = new List<long>();
            using (StreamReader spice = new StreamReader("PAWA"))
            {
                while (!spice.EndOfStream)
                {
                    e.Add(Convert.ToInt64(spice.ReadLine()));
                }
            }
            for (int x = 0; x < e.Count; x++)
            {
                for (int y = 0; y < e.Count; y++)
                {
                    if (x != y)
                    {
                        if (e[x] + e[y] == 2020)
                        {
                            Console.WriteLine(e[x] * e[y]);
                        }
                    }
                }
            }
            Console.WriteLine("eeeee");
            for (int x = 0; x < e.Count; x++)
            {
                for (int y = 0; y < e.Count; y++)
                {
                    for (int z = 0; z < e.Count; z++)
                    {
                        if (x != y && x != z && y != z)
                        {
                            if ((e[x] + e[y] + e[z]) == 2020)
                            {
                                Console.WriteLine(e[x] * e[y] * e[z]);
                            }
                        }
                    }
                }
            }
        }
    }
}