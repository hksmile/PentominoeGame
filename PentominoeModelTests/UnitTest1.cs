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
            PentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlayPiece(piece, 0, 0);
            Assert.IsTrue(!ret);
           
        }

        [TestMethod]
        public void PlacePieceXInBounds()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            PentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlayPiece(piece, 3, 3);
            Assert.IsTrue(ret);
        }
       
        [TestMethod]
        public void PlayPieceXandI()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            PentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlayPiece(piece, 3, 3, 0, TransformOrientations.DEFAULT);
            Assert.IsTrue(ret);

            piece = board.ChoosePiece("I");
            ret = board.PlayPiece(piece, 3, 3, 0, TransformOrientations.DEFAULT);
            Assert.IsFalse(ret);
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
            PentominoePuzzlePiece piece = board.ChoosePiece("I");
            bool ret = board.PlayPiece(piece, 0, 4);
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
            PentominoePuzzlePiece piece = board.ChoosePiece("T");
            bool ret = board.PlayPiece(piece, 8, 2);
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
            PentominoePuzzlePiece piece = board.ChoosePiece("U");
            bool ret = board.PlayPiece(piece, 7, 1);
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
            PentominoePuzzlePiece piece = board.ChoosePiece("V");
            bool ret = board.PlayPiece(piece, 4, 4);
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
            PentominoePuzzlePiece piece = board.ChoosePiece("W");
            bool ret = board.PlayPiece(piece, 5, 5);
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
            PentominoePuzzlePiece piece = board.ChoosePiece("Y");
            bool ret = board.PlayPiece(piece, 5, 3);
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
            PentominoePuzzlePiece piece = board.ChoosePiece("N");
            bool ret = board.PlayPiece(piece, 6, 1);
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
            PentominoePuzzlePiece piece = board.ChoosePiece("P");
            bool ret = board.PlayPiece(piece, 4, 3);
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
            PentominoePuzzlePiece piece = board.ChoosePiece("L");
            bool ret = board.PlayPiece(piece, 2, 4);
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
            PentominoePuzzlePiece piece = board.ChoosePiece("Z");
            bool ret = board.PlayPiece(piece, 1, 5);
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
            PentominoePuzzlePiece piece = board.ChoosePiece("F");
            bool ret = board.PlayPiece(piece, 8, 5);
            Assert.IsTrue(ret);
        }

      /* [TestMethod]
       
        public void SolveBoard()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            
            IPentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlayPiece(piece, 1, 1);
            Assert.IsTrue(ret);
            piece = board.ChoosePiece("U");
            ret = board.PlayPiece(piece, 0, 0);
            Assert.IsTrue(ret);
            board.solveBoardPieceByPiece();
            string[][] myBoard = board.GetBoard();
            
        }*/



            [TestMethod]
            public void ReferenceSolve()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();

            bool ret = false;

            ret = placeReferencePieceX(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceU(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceV(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceW(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceL(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceT(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceI(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceZ(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceY(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceN(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceF(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceP(board);
            Assert.IsTrue(ret);

        }

        private bool placeReferencePieceX(PentominoeGameBoard board)
        {
            PentominoePuzzlePiece piece = board.ChoosePiece("X");
            return board.PlayPiece(piece, 1, 4, 0, TransformOrientations.DEFAULT);

        }

        private bool placeReferencePieceP(PentominoeGameBoard board)
        {
            PentominoePuzzlePiece piece = board.ChoosePiece("P");
            return board.PlayPiece(piece, 9, 5, 0, TransformOrientations.MIRROR_LEFT);
        }

        private bool placeReferencePieceF(PentominoeGameBoard board)
        {
            PentominoePuzzlePiece piece = board.ChoosePiece("F");
            return board.PlayPiece(piece, 5, 4, 0, TransformOrientations.MIRROR_LEFT);
        }

        private bool placeReferencePieceN(PentominoeGameBoard board)
        {
            PentominoePuzzlePiece piece = board.ChoosePiece("N");
            return board.PlayPiece(piece, 8, 3, 0, TransformOrientations.ROTATE_90_CLOCK_MIRROR_DOWN);
        }

        private bool placeReferencePieceY(PentominoeGameBoard board)
        {
            PentominoePuzzlePiece piece = board.ChoosePiece("Y");
            return board.PlayPiece(piece, 6, 4, 0, TransformOrientations.ROTATE_90_CLOCK_MIRROR_DOWN);
        }

        private bool placeReferencePieceZ(PentominoeGameBoard board)
        {
            PentominoePuzzlePiece piece = board.ChoosePiece("Z");
            return board.PlayPiece(piece, 8, 1, 0, TransformOrientations.ROTATE_90_COUNTER_CLOCKWISE);
        }

        private bool placeReferencePieceI(PentominoeGameBoard board)
        {
            PentominoePuzzlePiece piece = board.ChoosePiece("I");
            return board.PlayPiece(piece, 3, 0, 0, TransformOrientations.ROTATE_90_CLOCKWISE);
        }

        private bool placeReferencePieceT(PentominoeGameBoard board)
        {
            PentominoePuzzlePiece piece = board.ChoosePiece("T");
            return board.PlayPiece(piece, 4, 3, 0, TransformOrientations.DEFAULT);
        }

        private bool placeReferencePieceL(PentominoeGameBoard board)
        {
            PentominoePuzzlePiece piece = board.ChoosePiece("L");
            return board.PlayPiece(piece, 6, 5, 0, TransformOrientations.ROTATE_90_COUNTER_CLOCKWISE);
        }

        private bool placeReferencePieceW(PentominoeGameBoard board)
        {
            PentominoePuzzlePiece piece = board.ChoosePiece("W");
            return board.PlayPiece(piece, 1, 1, 0, TransformOrientations.ROTATE_90_CLOCKWISE);
        }

        private bool placeReferencePieceV(PentominoeGameBoard board)
        {
            PentominoePuzzlePiece piece = board.ChoosePiece("V");
            return board.PlayPiece(piece, 0, 2, 0, TransformOrientations.DEFAULT);

            
        }

        private bool placeReferencePieceU(PentominoeGameBoard board)
        {
            PentominoePuzzlePiece piece = board.ChoosePiece("U");
            return board.PlayPiece(piece, 2, 4, 0, TransformOrientations.MIRROR_DOWN);

        }

        [TestMethod]
        public void SolveForOnePiece()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            bool ret = false;

            ret = placeReferencePieceX(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceU(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceV(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceW(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceL(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceT(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceI(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceZ(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceY(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceN(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceF(board);
            Assert.IsTrue(ret);
            
            board.solveBoardPieceByPiece();
            string[][] b = board.GetBoard();
            Assert.AreEqual("P", b[5][9]);
        }

        [TestMethod]
        public void SolveForOnePieceByLocation()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            bool ret = false;

            ret = placeReferencePieceX(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceU(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceV(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceW(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceL(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceT(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceI(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceZ(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceY(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceN(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceF(board);
            Assert.IsTrue(ret);

            board.solveBoardLocByLoc();
            string[][] b = board.GetBoard();
            Assert.AreEqual("P", b[5][9]);
        }

        [TestMethod]
        public void SolveForTwoPieces()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();            
            bool ret = false;

            ret = placeReferencePieceV(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceW(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceL(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceT(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceI(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceZ(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceY(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceN(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceF(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceP(board);
            Assert.IsTrue(ret);

            board.solveBoardPieceByPiece();


            string[][] b = board.GetBoard();
            Assert.AreEqual("U", b[5][0]);
            Assert.AreEqual("X", b[3][0]);
        }

        [TestMethod]
        public void SolveForTwoPiecesByLoc()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            bool ret = false;

            ret = placeReferencePieceV(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceW(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceL(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceT(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceI(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceZ(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceY(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceN(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceF(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceP(board);
            Assert.IsTrue(ret);

            board.solveBoardLocByLoc();


            string[][] b = board.GetBoard();
            Assert.AreEqual("U", b[5][0]);
            Assert.AreEqual("X", b[3][0]);
        }

        [TestMethod]
        public void SolveForThreePieces()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            bool ret = false;

            ret = placeReferencePieceV(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceL(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceT(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceI(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceZ(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceY(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceN(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceF(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceP(board);
            Assert.IsTrue(ret);


            board.solveBoardPieceByPiece();


            string[][] b = board.GetBoard();
            Assert.AreEqual("U", b[5][0]);
            Assert.AreEqual("X", b[3][0]);
            Assert.AreEqual("W", b[1][1]);
        }

        [TestMethod]
        public void SolveForThreePiecesByLoc()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            bool ret = false;

            ret = placeReferencePieceV(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceL(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceT(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceI(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceZ(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceY(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceN(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceF(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceP(board);
            Assert.IsTrue(ret);


            board.solveBoardLocByLoc();


            string[][] b = board.GetBoard();
            Assert.AreEqual("U", b[5][0]);
            Assert.AreEqual("X", b[3][0]);
            Assert.AreEqual("W", b[1][1]);
        }
        [TestMethod]
        public void SolveForFourPieces()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            bool ret = false;

            ret = placeReferencePieceV(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceL(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceI(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceZ(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceY(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceN(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceF(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceP(board);
            Assert.IsTrue(ret);


            board.solveBoardPieceByPiece();


            string[][] b = board.GetBoard();
            Assert.AreEqual("U", b[5][0]);
            Assert.AreEqual("X", b[3][0]);
            Assert.AreEqual("W", b[1][1]);
            Assert.AreEqual("T", b[1][5]);
        }
/*
       [TestMethod]
        public void SolveForFourPiecesByLoc()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            bool ret = false;

            ret = placeReferencePieceV(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceL(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceI(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceZ(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceY(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceN(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceF(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceP(board);
            Assert.IsTrue(ret);


            board.solveBoardLocByLoc();


            string[][] b = board.GetBoard();
            Assert.AreEqual("U", b[5][0]);
            Assert.AreEqual("X", b[3][0]);
            Assert.AreEqual("W", b[1][1]);
            Assert.AreEqual("T", b[1][5]);
        }
        */
        
            
        [TestMethod]
        public void SolveForFivePieces()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            bool ret = false;

            ret = placeReferencePieceL(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceI(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceZ(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceY(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceN(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceF(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceP(board);
            Assert.IsTrue(ret);


            board.solveBoardPieceByPiece();


            string[][] b = board.GetBoard();
            Assert.IsTrue(board.IsBoardSolved());
        }

      /* 
        [TestMethod]
        public void SolveForFivePiecesByLoc()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            bool ret = false;

            ret = placeReferencePieceL(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceI(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceZ(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceY(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceN(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceF(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceP(board);
            Assert.IsTrue(ret);


            board.solveBoardLocByLoc();


            string[][] b = board.GetBoard();
            Assert.IsTrue(board.IsBoardSolved());
        }
        [TestMethod]
        public void SolveForSixPieces()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            bool ret = false;

            ret = placeReferencePieceL(board);
            Assert.IsTrue(ret);
            
            ret = placeReferencePieceZ(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceY(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceN(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceF(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceP(board);
            Assert.IsTrue(ret);


            board.solveBoardPieceByPiece();


            string[][] b = board.GetBoard();
            Assert.IsTrue(board.IsBoardSolved());
        }

        [TestMethod]
        public void SolveForSevenPieces()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            bool ret = false;

            ret = placeReferencePieceL(board);
            Assert.IsTrue(ret);
            
            ret = placeReferencePieceY(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceN(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceF(board);
            Assert.IsTrue(ret);
            ret = placeReferencePieceP(board);
            Assert.IsTrue(ret);


            board.solveBoardPieceByPiece();


            string[][] b = board.GetBoard();
            Assert.IsTrue(board.IsBoardSolved());
        }
        */

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
            PentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlayPiece(piece, 1, 1);
            Assert.IsTrue(ret);
            ret = board.IsBoardPlayable();
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void BoardIsNotPlayableTwoPiece()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            PentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlayPiece(piece, 1, 1);
            Assert.IsTrue(ret);
            piece = board.ChoosePiece("L");
            ret = board.PlayPiece(piece, 1, 2);
            Assert.IsTrue(ret);
            ret = board.IsBoardPlayable();
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void BoardIsPlayableTwoPiece()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            PentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlayPiece(piece, 1, 1);
            Assert.IsTrue(ret);
            piece = board.ChoosePiece("L");
            ret = board.PlayPiece(piece, 9, 5);
            Assert.IsTrue(ret);
            ret = board.IsBoardPlayable();
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void BoardIsPlayableThreePiece()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            PentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlayPiece(piece, 1, 1);
            Assert.IsTrue(ret);
            piece = board.ChoosePiece("L");
            ret = board.PlayPiece(piece, 9, 5);
            Assert.IsTrue(ret);
            piece = board.ChoosePiece("I");
            ret = board.PlayPiece(piece, 3, 0);
            Assert.IsTrue(ret);
            ret = board.IsBoardPlayable();
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void BoardIsNOTPlayableThreePiece()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            PentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlayPiece(piece, 1, 1);
            Assert.IsTrue(ret);
            piece = board.ChoosePiece("U");
            ret = board.PlayPiece(piece, 3, 0);
            Assert.IsTrue(ret);
            piece = board.ChoosePiece("L");
            ret = board.PlayPiece(piece, 0, 5);
            Assert.IsTrue(ret);
            ret = board.IsBoardPlayable();
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void BoardIsNotPlayableSingleSpace()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            PentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlayPiece(piece, 0, 1);
            Assert.IsTrue(ret);
            ret = board.IsBoardPlayable();
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void UndoLastPlay()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            PentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlayPiece(piece, 0, 1);
            Assert.IsTrue(ret);
            Assert.IsNotNull(board.UndoLastPlay());

        }
        [TestMethod]
        public void TestPieceUPieceXPlacement()
        {
            PentominoeGameBoard board = new PentominoeGameBoard();
            PentominoePuzzlePiece piece = board.ChoosePiece("X");
            bool ret = board.PlayPiece(piece, 1, 1);
            Assert.IsTrue(ret);
            piece = board.ChoosePiece("U");
            ret = board.PlayPiece(piece, 0, 0);
            Assert.IsTrue(ret);

            string[][] b = board.GetBoard();
            Assert.AreEqual(b[0][0], "U");
            Assert.AreEqual(b[0][1], "U");
            Assert.AreEqual(b[0][2], "X");
            Assert.AreEqual(b[1][0], "U");
            Assert.AreEqual(b[1][1], "X");
            Assert.AreEqual(b[1][2], "X");
            Assert.AreEqual(b[1][3], "X");
            Assert.AreEqual(b[2][0], "U");
            Assert.AreEqual(b[2][1], "U");
            Assert.AreEqual(b[2][2], "X");

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
