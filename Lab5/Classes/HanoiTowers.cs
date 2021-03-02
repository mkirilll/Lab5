using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab5
{
    public class HanoiTowers
    {
        public int RingsQuantity { get; set; }

        public void PrintHanoiTowers(int ringsQuantity, int from, int to, int other)
        {
            if (ringsQuantity > 0)
            {
                PrintHanoiTowers(ringsQuantity - 1, from, other, to);
                Console.WriteLine("\nMove disk {0} from tower {1} to tower {2}", ringsQuantity, from, to);
                PrintHanoiTowers(ringsQuantity - 1, other, to, from);
            }
        }
        public void SolveHanoiTowers(int ringsQuantity)
        {
            PrintHanoiTowers(ringsQuantity, from: 1, to: 3, other: 2);
        }
    }
}
