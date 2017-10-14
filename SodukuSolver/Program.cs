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
            string inputString = "52...6.........7.13...........4..8..6......5...........418.........3..2...87.....";
            //string inputString = "521111111111111111111111111111111111111111111111111111111111111111111111111111111";

            Board board = new Board(inputString);
            
            board.Solve();

            Console.WriteLine(board.PrintBoard());

            Console.ReadLine();
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
