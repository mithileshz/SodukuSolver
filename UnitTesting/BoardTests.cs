using Microsoft.VisualStudio.TestTools.UnitTesting;
using SodukuSolver;

namespace UnitTesting
{
    [TestClass]
    public class BoardTests
    {
        private Board _board;

        [TestInitialize]
        public void InitializeTests()
        {
            _board = new Board();
        }

        [TestMethod]
        public void CheckIfValueExistsInXRow_ValueExists_ReturnsTrue()
        {
            bool actual = _board.CheckIfValueExistsInXRow(1, 1);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckIfValueExistsInXRow_ValueDoesNotExists_ReturnsFalse()
        {
            bool actual = _board.CheckIfValueExistsInXRow(11, 1);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckIfValueExistsInYRow_ValueExists_ReturnsTrue()
        {
            bool actual = _board.CheckIfValueExistsInYRow(1, 1);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckIfValueExistsInYRow_ValueDoesNotExists_ReturnsFalse()
        {
            bool actual = _board.CheckIfValueExistsInYRow(11, 1);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckIfValueExistsInBlock_ValueExists_ReturnsTrue()
        {
            bool actual = _board.CheckIfValueExistsInBlock(1, 1, 1);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckIfValueExistsInBlock_ValueDoesNotExists_ReturnsFalse()
        {
            _board.ChangeValue(10, 0, 0);

            bool actual = _board.CheckIfValueExistsInBlock(1, 1, 1);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckIfComplete_CompleteBoard_ReturnsTrue()
        {
            Assert.IsTrue(_board.IsComplete());
        }

        [TestMethod]
        public void CheckIfComplete_BoardNotCompleted_ReturnsFalse()
        {
            _board.ChangeValue(0,0,0);

            Assert.IsFalse(_board.IsComplete());
        }

        [TestMethod]
        public void PrintBoard_BasicBoard_PrintsTheBoard()
        {
            string expected = "1 4 7 2 5 8 3 6 9 \n2 5 8 3 6 9 4 7 1 \n3 6 9 4 7 1 5 8 2 \n4 7 1 5 8 2 6 9 3 \n5 8 2 6 9 3 7 1 4 \n6 9 3 7 1 4 8 2 5 \n7 1 4 8 2 5 9 3 6 \n8 2 5 9 3 6 1 4 7 \n9 3 6 1 4 7 2 5 8 \n";

            string actual = _board.PrintBoard();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Solve_ChallengingString_SolvedString()
        {
            _board = new Board("52...6.........7.13...........4..8..6......5...........418.........3..2...87.....");

            _board.Solve();

            string expected = "527316489896542731314987562172453896689271354453698217941825673765134928238769145";

            string actual = _board.PrintBoard().Replace("\n", "").Replace(" ", "");

            Assert.AreEqual(expected, actual);

        }
    }
}
