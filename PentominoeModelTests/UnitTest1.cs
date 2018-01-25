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
        public void PlacePieceVOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("V");
            bool ret = board.PlacePiece(piece, 0, 6);
            Assert.IsTrue(!ret);

        }

        [TestMethod]
        public void PlacePieceVInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("V");
            bool ret = board.PlacePiece(piece, 4, 4);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void PlacePieceWOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("W");
            bool ret = board.PlacePiece(piece, 9, 1);
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

        [TestMethod]
        public void PlacePieceNOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("N");
            bool ret = board.PlacePiece(piece, 8, 2);
            Assert.IsTrue(!ret);

        }

        [TestMethod]
        public void PlacePieceNInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("N");
            bool ret = board.PlacePiece(piece, 6, 1);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void PlacePiecePOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("P");
            bool ret = board.PlacePiece(piece, 4, 0);
            Assert.IsTrue(!ret);

        }

        [TestMethod]
        public void PlacePiecePInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("P");
            bool ret = board.PlacePiece(piece, 4, 3);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void PlacePieceLOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("L");
            bool ret = board.PlacePiece(piece, 2, 2);
            Assert.IsTrue(!ret);

        }

        [TestMethod]
        public void PlacePieceLInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("L");
            bool ret = board.PlacePiece(piece, 2, 4);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void PlacePieceZOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("Z");
            bool ret = board.PlacePiece(piece, 0, 2);
            Assert.IsTrue(!ret);

        }

        [TestMethod]
        public void PlacePieceZInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("Z");
            bool ret = board.PlacePiece(piece, 1, 5);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void PlacePieceFOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("F");
            bool ret = board.PlacePiece(piece, 9, 5);
            Assert.IsTrue(!ret);

        }

        [TestMethod]
        public void PlacePieceFInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("F");
            bool ret = board.PlacePiece(piece, 8, 5);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void PlacePieceFandL()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("F");
            bool ret = board.PlacePiece(piece, 4, 2);
            Assert.IsTrue(ret);
          

            piece = board.ChoosePiece("L");
            ret = board.PlacePiece(piece, 4, 0);
            Assert.IsFalse(ret);


        }

        [TestMethod]
        public void TestMultiArrays()
        {
            int[][] d = new int[2][];
            d[0] = new int[3] {1,2, 3 };
            d[1] = new int[3] { 4, 5, 6 };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + d[i][j] + " ");
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            int[,] b = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + b[i,j] + " ");
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

        }
    }
}
