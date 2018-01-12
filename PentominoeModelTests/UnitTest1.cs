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
    }
}
