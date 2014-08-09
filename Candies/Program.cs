using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRankCore;

namespace Candies
{
    class CandiesMain
    {
        static void Main(string[] args)
        {
            HackerRankCoreCls oHr = new HackerRankCoreCls();
            try
            {
                ArrayList oAl = oHr.ReadFile4Ints("Input.txt");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
