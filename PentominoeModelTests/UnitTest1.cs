using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myFirstAzureWebApp.Models;

namespace PentominoeModelTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PlacePieceXOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlacePiece(piece, 0, 0);
            Assert.IsTrue(!ret);
           
        }

        [TestMethod]
        public void PlacePieceXInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlacePiece(piece, 3, 3);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void PlacePieceIOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("I");
            bool ret = board.PlacePiece(piece, 0, 0);
            Assert.IsTrue(!ret);

        }

        [TestMethod]
        public void PlacePieceIInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("I");
            bool ret = board.PlacePiece(piece, 0, 4);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void PlacePieceTOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("T");
            bool ret = board.PlacePiece(piece, 9, 0);
            Assert.IsTrue(!ret);

        }

        [TestMethod]
        public void PlacePieceTInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("T");
            bool ret = board.PlacePiece(piece, 8, 2);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void PlacePieceUOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("U");
            bool ret = board.PlacePiece(piece, 7, 0);
            Assert.IsTrue(!ret);

        }

        [TestMethod]
        public void PlacePieceUInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("U");
            bool ret = board.PlacePiece(piece, 7, 1);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void PlacePieceLOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("L");
            bool ret = board.PlacePiece(piece, 0, 6);
            Assert.IsTrue(!ret);

        }

        [TestMethod]
        public void PlacePieceLInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("L");
            bool ret = board.PlacePiece(piece, 4, 4);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void PlacePieceWOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("W");
            bool ret = board.PlacePiece(piece, 8, 5);
            Assert.IsTrue(!ret);

        }

        [TestMethod]
        public void PlacePieceWInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("W");
            bool ret = board.PlacePiece(piece, 5, 5);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void PlacePieceYOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("Y");
            bool ret = board.PlacePiece(piece, 0, 0);
            Assert.IsTrue(!ret);

        }

        [TestMethod]
        public void PlacePieceYInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("Y");
            bool ret = board.PlacePiece(piece, 5, 3);
            Assert.IsTrue(ret);
        }
    }
}
