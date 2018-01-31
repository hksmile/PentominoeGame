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

        /* impossible to place I out of bounds on empty board
        [TestMethod]
        public void PlacePieceIOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("I");
            bool ret = board.PlacePiece(piece, 0, 0);
            Assert.IsTrue(!ret);

        }
        */
        

        [TestMethod]
        public void PlacePieceIInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("I");
            bool ret = board.PlacePiece(piece, 0, 4);
            Assert.IsTrue(ret);
        }

        /* T will fit in any spot on an empty board
        [TestMethod]
        public void PlacePieceTOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("T");
            bool ret = board.PlacePiece(piece, 0, 0);
            Assert.IsTrue(!ret);

        }
        */

        [TestMethod]
        public void PlacePieceTInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("T");
            bool ret = board.PlacePiece(piece, 8, 2);
            Assert.IsTrue(ret);
        }

        /*There's no way to place U out of bounds on an empty board
        [TestMethod]
        public void PlacePieceUOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("U");
            bool ret = board.PlacePiece(piece, 0, 0);
            Assert.IsTrue(!ret);
        }
        */
        

        [TestMethod]
        public void PlacePieceUInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("U");
            bool ret = board.PlacePiece(piece, 7, 1);
            Assert.IsTrue(ret);
        }

        /*impossible to place V out of bounds on empty board
        [TestMethod]
        public void PlacePieceVOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("V");
            bool ret = board.PlacePiece(piece, 0, 0);
            Assert.IsTrue(!ret);
        }*/

        [TestMethod]
        public void PlacePieceVInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("V");
            bool ret = board.PlacePiece(piece, 4, 4);
            Assert.IsTrue(ret);
        }

        /*impossible to place W out of bounds on empty board
        [TestMethod]
        public void PlacePieceWOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("W");
            bool ret = board.PlacePiece(piece, 0, 0);
            Assert.IsTrue(!ret);
        }*/

        [TestMethod]
        public void PlacePieceWInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("W");
            bool ret = board.PlacePiece(piece, 5, 5);
            Assert.IsTrue(ret);
        }

        /* Y will fit in any spot on an empty board
        [TestMethod]
        public void PlacePieceYOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("Y");
            bool ret = board.PlacePiece(piece, 0, 0);
            Assert.IsTrue(!ret);

        }
        */

        [TestMethod]
        public void PlacePieceYInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("Y");
            bool ret = board.PlacePiece(piece, 5, 3);
            Assert.IsTrue(ret);
        }

        /* impossible to place N out of bounds on empty board
        [TestMethod]
        public void PlacePieceNOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("N");
            bool ret = board.PlacePiece(piece, 0,0);
            Assert.IsTrue(!ret);
        }*/

        [TestMethod]
        public void PlacePieceNInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("N");
            bool ret = board.PlacePiece(piece, 6, 1);
            Assert.IsTrue(ret);
        }

        /*impossible to place P out of bounds on empty board
        [TestMethod]
        public void PlacePiecePOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("P");
            bool ret = board.PlacePiece(piece, 0, 0);
            Assert.IsTrue(!ret);
        }*/

        [TestMethod]
        public void PlacePiecePInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("P");
            bool ret = board.PlacePiece(piece, 4, 3);
            Assert.IsTrue(ret);
        }

      
       /* L will fit in any spot on empty board 
        [TestMethod]
        public void PlacePieceLOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("L");
            bool ret = board.PlacePiece(piece, 0, 0);
            Assert.IsTrue(!ret);
        }
        */
        

        [TestMethod]
        public void PlacePieceLInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("L");
            bool ret = board.PlacePiece(piece, 2, 4);
            Assert.IsTrue(ret);
        }

        /* Z will fit on any spot of an empty board
        [TestMethod]
        public void PlacePieceZOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("Z");
            bool ret = board.PlacePiece(piece, 0, 0);
            Assert.IsTrue(!ret);
        }*/

        [TestMethod]
        public void PlacePieceZInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("Z");
            bool ret = board.PlacePiece(piece, 1, 5);
            Assert.IsTrue(ret);
        }

        /* F will fit in any space on an empty board
        [TestMethod]
        public void PlacePieceFOutOfBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("F");
            bool ret = board.PlacePiece(piece, 0, 0);
            Assert.IsTrue(!ret);
        }*/

        [TestMethod]
        public void PlacePieceFInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("F");
            bool ret = board.PlacePiece(piece, 8, 5);
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void SolveBoard()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            board.solveBoard();
            string[][] myBoard = board.GetBoard();
        }

        [TestMethod]
        public void BoardIsPlayableEmpty()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            bool ret = board.IsBoardPlayable();
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void BoardIsPlayableSinglePiece()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlacePiece(piece, 1, 1);
            Assert.IsTrue(ret);
            ret = board.IsBoardPlayable();
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void BoardIsNotPlayableTwoPiece()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlacePiece(piece, 1, 1);
            Assert.IsTrue(ret);
            piece = board.ChoosePiece("L");
            ret = board.PlacePiece(piece, 0, 2);
            Assert.IsTrue(ret);
            ret = board.IsBoardPlayable();
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void BoardIsPlayableTwoPiece()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlacePiece(piece, 1, 1);
            Assert.IsTrue(ret);
            piece = board.ChoosePiece("L");
            ret = board.PlacePiece(piece, 9, 5);
            Assert.IsTrue(ret);
            ret = board.IsBoardPlayable();
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void BoardIsPlayableThreePiece()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlacePiece(piece, 1, 1);
            Assert.IsTrue(ret);
            piece = board.ChoosePiece("L");
            ret = board.PlacePiece(piece, 9, 5);
            Assert.IsTrue(ret);
            piece = board.ChoosePiece("I");
            ret = board.PlacePiece(piece, 0, 3);
            Assert.IsTrue(ret);
            ret = board.IsBoardPlayable();
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void BoardIsNOTPlayableThreePiece()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlacePiece(piece, 1, 1);
            Assert.IsTrue(ret);
            piece = board.ChoosePiece("U");
            ret = board.PlacePiece(piece, 3, 0);
            Assert.IsTrue(ret);
            piece = board.ChoosePiece("L");
            ret = board.PlacePiece(piece, 0, 5);
            Assert.IsTrue(ret);
            ret = board.IsBoardPlayable();
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void BoardIsNotPlayableSingleSpace()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlacePiece(piece, 0, 1);
            Assert.IsTrue(ret);
            ret = board.IsBoardPlayable();
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
