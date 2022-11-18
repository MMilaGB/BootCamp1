using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] InputArray = { "hello", "2", "world", "333" };

            string[] OutputArray = new string[InputArray.Length];

            for (int i = 0; i < InputArray.Length; i++)
            {
                if (InputArray[i].Length <= 3)
                {
                    OutputArray[i] = InputArray[i];
                }
            }

            Console.WriteLine(OutputArray);
            for (int i = 0; i < OutputArray.Length; i++)
            {
                Console.Write(OutputArray[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
