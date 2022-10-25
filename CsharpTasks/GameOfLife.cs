using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTasks
{
    public class GameOfLife

    {
        public static string[,] Create2DArray(int firstLength, int secondLength)
        {
            string[,] twoDArray = new string[firstLength, secondLength];
            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                Console.Write($"Row:{i}");
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    string randomInput = (new Random().Next() % 2 == 1 ? "-" : "+");
                    twoDArray[i, j] = randomInput;

                    Console.Write(twoDArray[i, j] + " ");
                }
            }
            return twoDArray;
        }
       public static string[,] startGame(string[,] twoDArray)
        {
            int countOfChanges = 1;
            int generation = 0;
            while (countOfChanges > 0)
            {
                Console.WriteLine("generation -->" + generation);
                generation++;
                countOfChanges = 0;
                for (int i = 0; i < twoDArray.GetLength(0); i++)
                {
                    for (int j = 0; j < twoDArray.GetLength(1); j++)
                    {
                        int livePointAround = 0;
                        if (j - 1 >= 0)
                        {
                            if (twoDArray[i, j - 1] == "+")
                            {
                                livePointAround++;
                            }


                            if (i - 1 >= 0)
                            {
                                if (twoDArray[i - 1, j - 1] == "+")
                                {
                                    livePointAround++;
                                }
                            }

                            if (i + 1 < twoDArray.GetLength(0))
                            {
                                if (twoDArray[i + 1, j - 1] == "+")
                                {
                                    livePointAround++;
                                }

                                if (twoDArray[i + 1, j] == "+")
                                {
                                    livePointAround++;
                                }
                            }

                            if (i - 1 >= 0)
                            {
                                if (twoDArray[i - 1, j] == "+")
                                {
                                    livePointAround++;
                                }

                                if (j + 1 < twoDArray.GetLength(1))
                                {
                                    if (twoDArray[i - 1, j + 1] == "+")
                                    {
                                        livePointAround++;
                                    }
                                }
                            }
                            if (j + 1 < twoDArray.GetLength(1))
                            {
                                if (twoDArray[i, j + 1] == "+")
                                {
                                    livePointAround++;
                                }

                                if (i + 1 < twoDArray.GetLength(0))
                                {
                                    if (twoDArray[i + 1, j + 1] == "+")
                                    {
                                        livePointAround++;
                                    }
                                }
                            }

                        }

                        if (twoDArray[i, j] == "+" && (livePointAround < 2 || livePointAround > 3))
                        {
                            twoDArray[i, j] = "-";
                            countOfChanges++;
                        }
                        if (twoDArray[i, j] == "-" && livePointAround == 3)
                        {
                            twoDArray[i, j] = "+";
                            countOfChanges++;
                        }
                    }
                }


            }
            Console.WriteLine("GAME OVER");
            return twoDArray;
        }

     

     
        }
    }
