using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperV2
{
    public class Test1
    {
        public static void Run()
        {
            string[,] Map =
            {
                { " " , " " , " " , " " ," "},
                { " " , " " , " " , " " ," "},
                { " " , "*" , "*" , " " ," "},
                { " " , " " , " " , "*" ," "},
                { " " , " " , " " , " " ," "},
            };

            int MapHeight = Map.GetLength(0);
            int MapWidth = Map.GetLength(1);

            /* Test Locator */
            int x = 2;
            int y = 2;
            string CurrentCell = Map[x, y];
            string LeftCell = Map[x, y - 1];
            string RightCell = Map[x, y + 1];
            string UpperCell = Map[x - 1, y];
            string LowerCell = Map[x + 1, y];
            string UpperLeftCell = Map[x - 1, y - 1];
            string LowerLeftCell = Map[x + 1, y - 1];
            string UpperRightCell = Map[x - 1, y + 1];
            string LowerRightCell = Map[x + 1, y + 1];
            Console.WriteLine("Current Cell: " + CurrentCell);
            Console.WriteLine("Left Cell: " + LeftCell);
            Console.WriteLine("Right Cell: " + RightCell);
            Console.WriteLine("Upper Cell: " + UpperCell);
            Console.WriteLine("Lower Cell: " + LowerCell);
            Console.WriteLine("Upper Left Cell: " + UpperLeftCell);
            Console.WriteLine("Lower Left Cell: " + LowerLeftCell);
            Console.WriteLine("Upper Right Cell: " + UpperRightCell);
            Console.WriteLine("Lower Right Cell: " + LowerRightCell);

            string[] NeighborCell = { LeftCell, LowerLeftCell, UpperLeftCell, RightCell, LowerRightCell, UpperRightCell, UpperCell, LowerCell };
            int Mine = 0;
            for (int i = 0; i < NeighborCell.Length; i++)
            {
                if (NeighborCell[i] == "*")
                {
                    Mine++;
                }
                else { continue; }
            }
            Console.WriteLine($"Surrounding Mines: " + Mine);
        }
    }
}
