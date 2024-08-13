using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notlar = { 100, 50, 85, 90, 25, 45, 37, 75, 87 };

            foreach (int not in notlar)
            {

                if (not >= 85)
                {
                    Console.WriteLine(not + " :AA");
                }
                else if(not >= 80 && not <=84)
                {
                    Console.WriteLine(not + " :BA");
                }
                else if (not >= 70 && not <= 79)
                {
                    Console.WriteLine(not + " :BB");
                }
                else if (not >= 65 && not <= 69)
                {
                    Console.WriteLine(not + " :CB");
                }
                else if (not >= 60 && not <= 64)
                {
                    Console.WriteLine(not + " :CC");
                }
                else if (not >= 50 && not <= 59)
                {
                    Console.WriteLine(not + " :DC");
                }
                else if (not >= 45 && not <= 49)
                {
                    Console.WriteLine(not + " :DD");
                }
                else
                {
                    Console.WriteLine(not + " :FF");
                }

            }
            Console.ReadLine(); 
        }
    }
}
