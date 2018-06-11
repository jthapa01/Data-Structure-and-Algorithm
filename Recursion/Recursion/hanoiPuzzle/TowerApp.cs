using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hanoiPuzzle
{
    class TowerApp
    {
        static int nDisks = 3;

        static void Main(string[] args)
        {
            DoTowers(3, 'A', 'B', 'C');
            Console.ReadLine();
        }

        public static void DoTowers(int topN, char from,
                                char inter, char to)
        {

            if(topN == 1)
            {
                Console.WriteLine("Disk 1 from " + from + " to " + to);
            }
            else
            {
                DoTowers(topN - 1, from, to, inter);        //from--> inter
                Console.WriteLine("Disk " + topN +
                                   " from " + from + " to "+ to);
                DoTowers(topN-1, inter, from, to );         //inter--> to
            }
        }
    }
}
