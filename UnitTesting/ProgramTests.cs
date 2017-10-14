using Microsoft.VisualStudio.TestTools.UnitTesting;
using SodukuSolver;

namespace UnitTesting
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void CheckIfValueExistsInXRow_ValueExists_ReturnsTrue()
        {
            int[] input =
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            bool actual = SodukuSolver.Program.CheckIfValueExistsInXRow(1, input);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckIfValueExistsInXRow_ValueDoesNotExists_ReturnsFalse()
        {
            int[] input =
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            bool actual = SodukuSolver.Program.CheckIfValueExistsInXRow(11, input);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckIfValueExistsInYRow_ValueExists_ReturnsTrue()
        {
            bool actual = SodukuSolver.Program.CheckIfValueExistsInYRow(1, 1, BasicArray());

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckIfValueExistsInYRow_ValueDoesNotExists_ReturnsFalse()
        {
            bool actual = SodukuSolver.Program.CheckIfValueExistsInYRow(11, 1, BasicArray());

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckIfValueExistsInBlock_ValueExists_ReturnsTrue()
        {
            bool actual = Program.CheckIfValueExistsInBlock(1, 1, 1, BasicArray());

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckIfValueExistsInBlock_ValueDoesNotExists_ReturnsFalse()
        {
            int[][] initalArray = BasicArray();

            initalArray[0][0] = 10;

            bool actual = Program.CheckIfValueExistsInBlock(1, 1, 1, initalArray);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckIfComplete_CompleteBoard_ReturnsTrue()
        {
            Assert.IsTrue(Program.CheckIfComplete(BasicArray()));
        }

        [TestMethod]
        public void CheckIfComplete_BoardNotCompleted_ReturnsFalse()
        {
            int[][] inputArr = BasicArray();

            inputArr[0][0] = 0;

            Assert.IsFalse(Program.CheckIfComplete(inputArr));
        }

        private static int[][] BasicArray()
        {
            return new[]
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
