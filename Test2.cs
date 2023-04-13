using System;

namespace MineSweeperV2
{
    public class Test2
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

            for (int x = 0; x < MapHeight; x++)
            {
                for (int y = 0; y < MapWidth; y++)
                {
                    switch (Map[x, y])
                    {
                        case "*":
                            Console.Write("*");
                            break;
                        case " ":
                            int Mine = 0;
                            int[,] Neighbor =
                            {
                                { x - 1, y - 1 },
                                { x - 1, y },
                                { x - 1, y + 1 },
                                { x, y - 1 },
                                { x, y + 1 },
                                { x + 1, y - 1 },
                                { x + 1, y },
                                { x + 1, y + 1}
                            };
                            
                            for (int i =0; i < Neighbor.GetLength(0); i++)
                            {
                                int XofNeighbor = Neighbor[i, 0];
                                int YofNeighbor = Neighbor[i, 1];

                                bool isOutOfBound = XofNeighbor < 0s
                                    || XofNeighbor == MapHeight
                                    || YofNeighbor < 0
                                    || YofNeighbor == MapWidth;

                                if (isOutOfBound) { continue; }
                                if (Map[XofNeighbor, YofNeighbor].Equals("*"))
                                {
                                    Mine++;
                                }
                            }
                            Console.Write(Mine);
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
