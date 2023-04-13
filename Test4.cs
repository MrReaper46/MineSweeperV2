using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperV2
{
    class Test4
    {
        public static void Run()
        {
            int[,] Neighbor = { { -1, -1 }, { -1, 0 }, { -1, 1 }, { 0, -1 }, { 0, 1 }, { 1, -1 }, { 1, 0 }, { 1, 1 } };
            Console.WriteLine("Height is: " + Neighbor.GetLength(0));
            Console.WriteLine("Width is: " + Neighbor.GetLength(1));
            for (int i = 0; i < Neighbor.GetLength(0); i++)
            {
                int xOrdinateOfNeighbour = Neighbor[i, 1];
                int yOrdinateOfNeighbour = Neighbor[i, 0];
                Console.WriteLine(xOrdinateOfNeighbour);
                Console.Write(yOrdinateOfNeighbour);
            }
        }
    }
}
