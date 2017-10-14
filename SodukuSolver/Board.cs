using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SodukuSolver
{
    public class Board
    {
        private int[][] _inputValues;

        public Board()
        {
            SolvedSimpleBoard();
        }

        public Board(string board)
        {
            ConvertFromStringToArray(board);
        }

        public Board(int[][] board)
        {
            _inputValues = board;
        }

        public string PrintBoard()
        {
            string ret = "";
            foreach (int[] i in _inputValues)
            {
                foreach (int j in i)
                {
                    if (j == 0)
                    {
                        ret = ret + "  ";
                    }
                    else
                    {
                        ret = ret + j + " ";
                    }
                }
                ret = ret + "\n";
            }

            return ret;
        }

        public void Solve()
        {
            //while (!IsComplete())
            //{
            //    Console.WriteLine("Solving...");
            //}
        }

        public bool CheckIfValueExistsInXRow(int value, int rowValue)
        {
            return _inputValues[rowValue].Contains(value);
        }

        public bool CheckIfValueExistsInYRow(int value, int column)
        {
            return _inputValues.Any(row => row[column] == value);
        }

        public bool CheckIfValueExistsInBlock(int value, int locationX, int locationY)
        {
            int blockX = (locationX / 3) * 3;
            int blockY = (locationY / 3) * 3;

            for (int i = blockX; i < 3; i++)
            {
                for (int j = blockY; j < 3; j++)
                {
                    if (_inputValues[i][j] == value) return true;
                }
            }

            return false;
        }

        public bool IsComplete()
        {
            return _inputValues.All(x => x.All(y => y != 0));
        }

        public void ChangeValue(int value, int x, int y)
        {
            _inputValues[x][y] = value;
        }

        private void ConvertFromStringToArray(string board)
        {
            char[] boardCharArr = board.ToCharArray();

            _inputValues = new int[9][];

            for (int i = 0; i < 9; i++)
            {
                _inputValues[i] = new int[9];

                for (int j = 0; j < 9; j++)
                {
                    if (!int.TryParse(boardCharArr[(i * 9) + j].ToString(), out _inputValues[i][j]))
                    {
                        _inputValues[i][j] = 0;
                    }
                }
            }
        }

        private void SolvedSimpleBoard()
        {
            _inputValues = new[]
            {
                new[]
                {
                    1, 4, 7, 2, 5, 8, 3, 6, 9
                },
                new[]
                {
                    2, 5, 8, 3, 6, 9, 4, 7, 1
                },
                new[]
                {
                    3, 6, 9, 4, 7, 1, 5, 8, 2
                },
                new[]
                {
                    4, 7, 1, 5, 8, 2, 6, 9, 3
                },
                new[]
                {
                    5, 8, 2, 6, 9, 3, 7, 1, 4
                },
                new[]
                {
                    6, 9, 3, 7, 1, 4, 8, 2, 5
                },
                new[]
                {
                    7, 1, 4, 8, 2, 5, 9, 3, 6
                },
                new[]
                {
                    8, 2, 5, 9, 3, 6, 1, 4, 7
                },
                new[]
                {
                    9, 3, 6, 1, 4, 7, 2, 5, 8
                }

            };
        }
    }
}
