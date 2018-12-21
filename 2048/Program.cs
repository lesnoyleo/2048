using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] square = generationSquare();

            updateSquare(square);

            while (true)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        moveUp(square);
                        //generationOneBox(square);
                        updateSquare(square);
                        break;
                    case ConsoleKey.DownArrow:
                        moveDown(square);
                        //generationOneBox(square);
                        updateSquare(square);
                        break;
                    case ConsoleKey.LeftArrow:
                        moveLeft(square);
                        //generationOneBox(square);
                        updateSquare(square);
                        break;
                    case ConsoleKey.RightArrow:
                        moveRight(square);
                        //generationOneBox(square);
                        updateSquare(square);
                        break;
                }
            }
        }

        public static int[,] generationOneBox(int[,] square)
        {
            Random ran = new Random();
            int[] value = new int[] { 2, 4 };
            int insexI, insexB, indexC = 0;

            insexI = ran.Next(1, 4);
            insexB = ran.Next(1, 4);
            indexC = ran.Next(0, 2);

            if (square[insexI, insexB]==0)
            {
                square[insexI, insexB] = value[indexC];
            }
            return square;
        }


        public static void updateSquare(int[,] square)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t", square[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int[,] generationSquare()
        {
            Random ran = new Random();
            int[] value = new int[] { 2, 4 };
            int[,] square = new int[4, 4];
            int insexI, insexB, indexC = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    square[i, j] = 0;
                }
            }


            for (int k = 0; k < 2; k++)
            {
                insexI = ran.Next(1, 4);
                insexB = ran.Next(1, 4);
                indexC = ran.Next(0, 2);
                square[insexI, insexB] = value[indexC];
            }
            return square;
        }

        public static int[,] moveUp(int[,] square)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if ((square[i, j] != 0) && (i != 0) && (square[i-1, j] == square[i, j]) )
                    {
                        square[i-1, j] += square[i, j];
                        square[i, j] = 0;
                    }

                    if ((square[i, j] != 0) && (i != 0) && (square[i - 1, j] != square[i, j]) && (square[i - 1, j]==0))
                    {
                        square[i - 1, j] = square[i, j];
                        square[i, j] = 0;
                    }

                    if ((square[i, j] != 0) && (i == 0))
                    {
                        square[i , j] = square[i, j];
                    }
                }
            }
            return square;
        }

        public static int[,] moveDown(int[,] square)
        {
            for (int i = 0; i < 4; i++)
            {
            
                for (int j = 0; j < 4; j++)
                {
                
                    if ((square[i, j] != 0) && (i != 3) && (square[i + 1, j] == square[i, j]))
                    {
                        square[i + 1, j] += square[i, j];
                        square[i, j] = 0;
                    }

                    if ((square[i, j] != 0) && (i != 3) && (square[i + 1, j] != square[i, j]) && (square[i + 1, j] == 0))
                    {
                        square[i + 1, j] = square[i, j];
                        square[i, j] = 0;

                    }

                    if ((square[i, j] != 0) && (i == 3))
                    {
                        square[i, j] = square[i, j];

                    }
                }
            }
            
            return square;
        }

        public static int[,] moveLeft(int[,] square)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if ((square[i, j] != 0) && (j != 0) && (square[i, j-1] == square[i, j]))
                    {
                        square[i, j-1] += square[i, j];
                        square[i, j] = 0;
                    }

                    if ((square[i, j] != 0) && (j != 0) && (square[i, j-1] != square[i, j]))
                    {
                        square[i, j - 1] = square[i, j];
                        square[i, j] = 0;
                    }

                    if ((square[i, j] != 0) && (j != 0) && (square[i, j - 1] != square[i, j]))
                    {
                        square[i, j] = square[i, j];
                    }

                    if ((square[i, j] != 0) && (j == 0))
                    {
                        square[i, j] = square[i, j];
                    }

                }
            }
            return square;
        }
        public static int[,] moveRight(int[,] square)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if ((square[i, j] != 0) && (j != 3) && (square[i, j + 1] == square[i, j]))
                    {
                        square[i, j + 1] += square[i, j];
                        square[i, j] = 0;
                    }

                    if ((square[i, j] != 0) && (j != 3) && (square[i, j + 1] != square[i, j]))
                    {
                        square[i, j + 1] = square[i, j];
                        square[i, j] = 0;
                    }

                    if ((square[i, j] != 0) && (j != 3) && (square[i, j + 1] == 0))
                    {
                        square[i, j + 1] = square[i, j];
                        square[i, j] = 0;
                    }


                    if ((square[i, j] != 0) && (j == 3))
                    {
                        square[i, j] = square[i, j];
                    }

                }
            }
            return square;
        }



    }
}
