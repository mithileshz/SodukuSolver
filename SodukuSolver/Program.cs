using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace SodukuSolver
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string board = "52...6.........7.13...........4..8..6......5...........418.........3..2...87.....";
            string board = "521111111111111111111111111111111111111111111111111111111111111111111111111111111";

            char[] boardCharArr = board.ToCharArray();

            int[][] boardIntArr = new int[9][];

            for (int i = 0; i < 9; i++)
            {
                boardIntArr[i] = new int[9];

                for (int j = 0; j < 9; j++)
                {
                    if (!int.TryParse(boardCharArr[(i * 9) + j].ToString(), out boardIntArr[i][j]))
                    {
                        boardIntArr[i][j] = 0;
                    }
                }
            }

            bool x = CheckIfValueExistsInYRow(1, 1, boardIntArr);

            while (!CheckIfComplete(boardIntArr))
            {

            }

            PrintBoard(boardIntArr);
        }

        public static void PrintBoard(int[][] boardIntArr)
        {
            foreach (int[] i in boardIntArr)
            {
                foreach (int j in i)
                {
                    if (j == 0)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public static bool CheckIfComplete(int[][] boardArr)
        {
            return boardArr.All(x => x.All(y => y != 0));
        }

        public static bool CheckIfValueExistsInXRow(int value, int[] xRow)
        {
            return xRow.Contains(value);
        }

        public static bool CheckIfValueExistsInYRow(int value, int column, int[][] boardIntArr)
        {
            return boardIntArr.Any(row => row[column] == value);
        }

        public static bool CheckIfValueExistsInBlock(int value, int locationX, int locationY, int[][] boardIntArr)
        {
            int blockX = (locationX / 3) * 3;
            int blockY = (locationY / 3) * 3;

            for (int i = blockX; i < 3; i++)
            {
                for (int j = blockY; j < 3; j++)
                {
                    if (boardIntArr[i][j] == value) return true;
                }
            }

            return false;
        }

        //public static string GetAllPossibleValues(int locationX, int locationY, int[][] boardIntArr)
        //{
        //    List<int> possibleNumbers = new List<int>();

        //    for (int i = 1; i < 10; i++)
        //    {
        //        if (boardIntArr[locationX][locationY] != 0) return ;
        //        if(CheckIfValueExistsInXRow(i, boardIntArr[locationX]) || )
        //    }
        //}
    }

}
