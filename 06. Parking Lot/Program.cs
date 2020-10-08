using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();

            HashSet<string> parking = new HashSet<string>();

            while (input[0] != "END" )
            {
                

                if (input[0] == "IN")
                {
                    parking.Add(input[1]);
                }
                else
                {
                    parking.Remove(input[1]);
                }
                input = Console.ReadLine().Split(", ").ToArray();
            }

            if (parking.Count > 0)
            {
                foreach (var item in parking)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
