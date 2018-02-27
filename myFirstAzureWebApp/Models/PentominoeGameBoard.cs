using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;


namespace myFirstAzureWebApp.Models
{

    public enum LocationNames { ABOVE_LEFT, ABOVE_CENTER, ABOVE_RIGHT, LEFT, RIGHT, BELOW_LEFT, BELOW_CENTER, BELOW_RIGHT };
    public enum TransformOrientations { DEFAULT , ROTATE_90_COUNTER_CLOCKWISE, ROTATE_90_CLOCKWISE, MIRROR_LEFT, MIRROR_DOWN, ROTATE_180, ROTATE_90_COUNTER_MIRROR_DOWN, ROTATE_90_CLOCK_MIRROR_DOWN};
    
    public abstract class PentominoePuzzlePiece
    {
        protected PentominoePuzzleUnit[] units = new PentominoePuzzleUnit[5];

        public abstract string pieceName();
        public abstract int Length();
        public abstract int Width();

        public PentominoePuzzleUnit[] getUnits(TransformOrientations orientation)
        {

            if (orientation == TransformOrientations.DEFAULT)
                return units;

            PentominoePuzzleUnit[] transformedUnits = new PentominoePuzzleUnit[5];

            for (int i = 0; i < units.Length; i++)
            {
                transformedUnits[i] = new PentominoePuzzleUnit(units[i], orientation);
            }

            return transformedUnits;
        }

    }

   
    public abstract class PuzzlePieceFactory
    {
        public abstract PentominoePuzzlePiece CreatePuzzlePiece(string type);
    }

    public class PentominoePuzzlePieceFactory : PuzzlePieceFactory
    {
        public override PentominoePuzzlePiece CreatePuzzlePiece(string type)
        {
            
            if (type == "I")
            {
                return new PieceI();
            }
            if (type == "V")
            {
                return new PieceV();
            }
            if (type == "L")
            {
                return new PieceL();
            }
            if (type == "N")
            {
                return new PieceN();
            }
            if (type == "P")
            {
                return new PieceP();
            }
            if (type =="T")
            {
                return new PieceT();
            }
            if (type == "U")
            {
                return new PieceU();
            }
            if (type == "W")
            {
                return new PieceW();
            }
            if (type == "X")
            {
                return new PieceX();
            }
            if (type == "Y")
            {
                return new PieceY();
            }
            if (type == "Z")
            {
                return new PieceZ();
            }
            if (type == "F")
            {
                return new PieceF();
            }

            return null;
        }
    }

    public class PieceF : PentominoePuzzlePiece
    {
        public PieceF()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, 1, 3, -1, 2);
            units[1] = new PentominoePuzzleUnit(1, -1, -1, -1, 0, -1, -1, -1, 3);
            units[2] = new PentominoePuzzleUnit(2, -1, 0, -1, -1, 3, -1, 4, -1);
            units[3] = new PentominoePuzzleUnit(3, 0, 1, -1, 2, -1, 4, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, 3, -1, 2, -1, -1, -1, -1, -1);
        }

        public override string pieceName()
        {
            return "F";
        }
        public override int Length()
        {
            return 3;
        }
        public override int Width()
        {
            return 3;
        }

    }
    public class PieceV : PentominoePuzzlePiece
    {
        
        public PieceV()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, -1, 1, -1, -1);
            units[1] = new PentominoePuzzleUnit(1, 0, -1, -1, -1, -1, 2, 3, -1);
            units[2] = new PentominoePuzzleUnit(2, 1, -1, -1, -1, 3, -1, -1, -1);
            units[3] = new PentominoePuzzleUnit(3, -1, -1, 1, 2, 4, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, -1, -1, 3, -1, -1, -1, -1);
        }

        public override string pieceName()
        {
            return "V";
        }

        public override int Length()
        {
            return 3;
        }
        public override int Width()
        {
            return 3;
        }
    }
    public class PieceN : PentominoePuzzlePiece
    {
        
        public PieceN()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, 1, -1, 2, -1);
            units[1] = new PentominoePuzzleUnit(1, -1, -1, -1, 0, -1, 2, 3, -1);
            units[2] = new PentominoePuzzleUnit(2, 1, -1, 0, -1, 3, -1, -1, -1);
            units[3] = new PentominoePuzzleUnit(3, -1, -1, 1, 2, 4, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, -1, -1, 3, -1, -1, -1, -1);
        }

        public override string pieceName()
        {
            return "N";
        }
        
        public override int Length()
        {
            return 4;
        }
        public override int Width()
        {
            return 2;
        }
        
    }
    public class PieceP : PentominoePuzzlePiece
    {
        public PieceP()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, 1, 2, 3, -1);
            units[1] = new PentominoePuzzleUnit(1, -1, -1, -1, 0, -1, 3, -1, 2);
            units[2] = new PentominoePuzzleUnit(2, 0, 1, -1, -1, 3, 4, -1, -1);
            units[3] = new PentominoePuzzleUnit(3, 1, -1, 0, 2, -1, -1, -1, 4);
            units[4] = new PentominoePuzzleUnit(4, 2, 3, -1, -1, -1, -1, -1, -1);
        }

        public override string pieceName()
        {
            return "P";
        }
        
        public override int Length()
        {
            return 3;
        }
        public override int Width()
        {
            return 2;
        }
        
    }
    public class PieceT : PentominoePuzzlePiece
    {
        
        public PieceT()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, -1, 1, -1, -1);
            units[1] = new PentominoePuzzleUnit(1, 0, -1, -1, -1, -1, 3, -1, -1);
            units[2] = new PentominoePuzzleUnit(2, -1, 1, -1, -1, 3, -1, -1, -1);
            units[3] = new PentominoePuzzleUnit(3, 1, -1, -1, 2, 4, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, -1, 1, 3, -1, -1, -1, -1);
        }

        public override string pieceName()
        {
            return "T";
        }

        public override int Length()
        {
            return 3;
        }
        public override int Width()
        {
            return 3;
        }

    }
    public class PieceI: PentominoePuzzlePiece
    {
        
        public PieceI()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, -1, 1, -1, -1);
            units[1] = new PentominoePuzzleUnit(1, 0, -1, -1, -1, -1, 2, -1, -1);
            units[2] = new PentominoePuzzleUnit(2, 1, -1, -1, -1, -1, 3, -1, -1);
            units[3] = new PentominoePuzzleUnit(3, 2, -1, -1, -1, -1, 4, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, 3, -1, -1, -1, -1, -1, -1, -1);
        }

        public override string pieceName()
        {
            return "I";
        }

        public override int Length()
        {
            return 5;
        }
        public override int Width()
        {
            return 1;
        }

    }
    public class PieceU : PentominoePuzzlePiece
    {
     
        public PieceU()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, -1, 1, -1, 2);
            units[1] = new PentominoePuzzleUnit(1, 0, -1, -1, 2, -1, -1, -1, -1);
            units[2] = new PentominoePuzzleUnit(2, -1, 0, 4, 3, 1, -1, -1, -1);
            units[3] = new PentominoePuzzleUnit(3, 4, -1, -1, -1, 2, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, -1, -1, -1, -1, 3, 2, -1);
        }

        public override string pieceName()
        {
            return "U";
        }

        public override int Length()
        {
            return 2;
        }
        public override int Width()
        {
            return 3;
        }

        
    }
    public class PieceL : PentominoePuzzlePiece
    {
        
        public PieceL()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, -1, 1, -1, -1);
            units[1] = new PentominoePuzzleUnit(1, 0, -1, -1, -1, -1, 2, -1, -1);
            units[2] = new PentominoePuzzleUnit(2, 1, -1, -1, -1, -1, 3, 4, -1);
            units[3] = new PentominoePuzzleUnit(3, 2, -1, -1, -1, 4, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, -1, 2, 3, -1, -1, -1, -1);
        }

        public override string pieceName()
        {
            return "L";
        }

        public override int Length()
        {
            return 4;
        }
        public override int Width()
        {
            return 2;
        }

    }
    public class PieceW : PentominoePuzzlePiece
    {
        
        public PieceW()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, -1, 1, 2, -1);
            units[1] = new PentominoePuzzleUnit(1, 0, -1, -1, -1, 2, -1, 3, -1);
            units[2] = new PentominoePuzzleUnit(2, -1, -1, 0, 1, -1, 3, 4, -1);
            units[3] = new PentominoePuzzleUnit(3, 2, -1, 1, -1, 4, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, -1, 2, 3, -1, -1, -1, -1);
        }

        public override string pieceName()
        {
            return "W";
        }

        public override int Length()
        {
            return 3;
        }
        public override int Width()
        {
            return 3;
        }
        
    }
    public class PieceX : PentominoePuzzlePiece
    {
        public PieceX()
        {
            units[0] = new PentominoePuzzleUnit(0,-1,-1,-1,-1, -1, 2, 3, 1);
            units[1] = new PentominoePuzzleUnit(1,-1, 0, -1, -1, 2, -1, 4, -1);
            units[2] = new PentominoePuzzleUnit(2,0,-1,-1,1,3,4, -1, -1);
            units[3] = new PentominoePuzzleUnit(3,-1, -1, 0, 2, -1, -1, -1, 4);
            units[4] = new PentominoePuzzleUnit(4,2, 3, 1, -1, -1, -1, -1, -1);            
        }

        public override string pieceName()
        {
            return "X";
        }

        public override int Length()
        {
            return 3;
        }
        public override int Width()
        {
            return 3;
        }
        
    }
    public class PieceY : PentominoePuzzlePiece
    {
        
        public PieceY()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, -1, 2, 3, 1);
            units[1] = new PentominoePuzzleUnit(1, -1, 0, -1, -1, 2, -1, -1, -1);
            units[2] = new PentominoePuzzleUnit(2, 0, -1, -1, 1, 3, -1, -1, -1);
            units[3] = new PentominoePuzzleUnit(3, -1, -1, 0, 2, 4, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, -1, -1, 3, -1, -1, -1, -1);
        }
        public override string pieceName()
        {
            return "Y";
        }

        public override int Length()
        {
            return 4;
        }
        public override int Width()
        {
            return 2;
        }
        
    }
    public class PieceZ : PentominoePuzzlePiece
    {
        
        public PieceZ()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, 1, 2, -1, -1);
            units[1] = new PentominoePuzzleUnit(1, -1, -1, -1, 0, -1, -1, -1, 2);
            units[2] = new PentominoePuzzleUnit(2, 0, 1, -1, -1, -1, 3, -1, 4);
            units[3] = new PentominoePuzzleUnit(3, 2, -1, -1, 4, -1, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, 2, -1, -1, 3, -1, -1, -1);
        }
        public override string pieceName()
        {
            return "Z";
        }

        public override int Length()
        {
            return 3;
        }
        public override int Width()
        {
            return 3;
        }
    }

    public class PentominoePuzzleUnit
    { 

        public List<AdjacentLocation> adjacentLocations = new List<AdjacentLocation>();
        public int index;

        public PentominoePuzzleUnit(int unitIndex, int unitAboveCenter, int unitAboveRight, int unitAboveLeft,  
                            int unitLeft, int unitRight,
                            int unitBelowCenter, int unitBelowRight, int unitBelowLeft)
        {
            index = unitIndex;

            if (unitAboveCenter != -1)
                adjacentLocations.Add(new AdjacentLocation(LocationNames.ABOVE_CENTER, true, unitAboveCenter));
            if (unitAboveRight != -1)
                adjacentLocations.Add(new AdjacentLocation(LocationNames.ABOVE_RIGHT, true, unitAboveRight));
            if (unitAboveLeft != -1)
                adjacentLocations.Add(new AdjacentLocation(LocationNames.ABOVE_LEFT, true, unitAboveLeft));
            
            if (unitLeft != -1)
                adjacentLocations.Add(new AdjacentLocation(LocationNames.LEFT, true, unitLeft));
            if (unitRight != -1)
                adjacentLocations.Add(new AdjacentLocation(LocationNames.RIGHT, true, unitRight));

            if (unitBelowCenter != -1)
                adjacentLocations.Add(new AdjacentLocation(LocationNames.BELOW_CENTER, true, unitBelowCenter));
            if (unitBelowLeft != -1)
                adjacentLocations.Add(new AdjacentLocation(LocationNames.BELOW_LEFT, true, unitBelowLeft));
            if (unitBelowRight != -1)
                adjacentLocations.Add(new AdjacentLocation(LocationNames.BELOW_RIGHT, true, unitBelowRight));

        }

        public PentominoePuzzleUnit (PentominoePuzzleUnit copyUnit, TransformOrientations orientation)
        {
            index = copyUnit.index;
            foreach (AdjacentLocation loc in copyUnit.adjacentLocations)
            {
                adjacentLocations.Add(new AdjacentLocation(loc, orientation));
            }
        }

    }

    public class AdjacentLocation
    {

        private int xOffSet = 0;
        public int Xoffset { get { return xOffSet; } }

        private int yOffSet = 0;
        public int Yoffset { get { return yOffSet; } }

        private bool covered = false;
        public bool Covered { get { return covered; } }

        private int unitNumber;
        public int UnitNumber { get { return unitNumber; } }

        public AdjacentLocation(LocationNames location, bool locCovered, int number)
        {
            switch (location)
            {
                case LocationNames.ABOVE_CENTER:
                case LocationNames.ABOVE_LEFT:
                case LocationNames.ABOVE_RIGHT:
                    yOffSet = 1;
                    break;
                case LocationNames.BELOW_CENTER:
                case LocationNames.BELOW_LEFT:
                case LocationNames.BELOW_RIGHT:
                    yOffSet = -1;
                    break;
            }
            switch (location)
            {
                case LocationNames.ABOVE_LEFT:
                case LocationNames.LEFT:
                case LocationNames.BELOW_LEFT:
                    xOffSet = -1;
                    break;
                case LocationNames.ABOVE_RIGHT:
                case LocationNames.RIGHT:
                case LocationNames.BELOW_RIGHT:
                    xOffSet = 1;
                    break;
            }
           
            covered = locCovered;
            unitNumber = number;
        }

        public AdjacentLocation(AdjacentLocation copyLocation, TransformOrientations orientation)
        {
            xOffSet = copyLocation.xOffSet;
            yOffSet = copyLocation.yOffSet;
            covered = copyLocation.covered;
            unitNumber = copyLocation.unitNumber;

            switch (orientation)
            {
                case TransformOrientations.ROTATE_90_COUNTER_CLOCKWISE:
                    transformCounterClockwise90();
                    break;
                case TransformOrientations.ROTATE_90_CLOCKWISE:
                    transformClockwise90();
                    break;
                case TransformOrientations.MIRROR_LEFT:
                    transformMirrorLeft();
                    break;
                case TransformOrientations.MIRROR_DOWN:
                    transformMirrorDown();
                    break;
                case TransformOrientations.ROTATE_180:
                    transformMirrorDown();
                    transformMirrorLeft();
                    break;
                case TransformOrientations.ROTATE_90_COUNTER_MIRROR_DOWN:
                    transformCounterClockwise90();
                    transformMirrorDown();
                    break;
                case TransformOrientations.ROTATE_90_CLOCK_MIRROR_DOWN:
                    transformClockwise90();
                    transformMirrorDown();
                    break;
            }

        }

        private void transformCounterClockwise90()
        {
            int newXOffset = yOffSet;
            int newYOffset = -xOffSet;

            xOffSet = newXOffset;
            yOffSet = newYOffset;

        }

        private void transformClockwise90()
        {
            int newXOffset = -yOffSet;
            int newYOffset = xOffSet;

            xOffSet = newXOffset;
            yOffSet = newYOffset;
        }

        private void transformMirrorLeft()
        {
            int newXOffset = -xOffSet;
            int newYOffset = yOffSet;

            xOffSet = newXOffset;
            yOffSet = newYOffset;
        }

        private void transformMirrorDown()
        {
            int newXOffset = xOffSet;
            int newYOffset = -yOffSet;

            xOffSet = newXOffset;
            yOffSet = newYOffset;
        }
    }

    public class PentominoeGameBoardLocation
    {
        private bool covered = false;
        public bool Covered { get { return (coveredPiece != null) || (coveredUnit >=0); }}

        private PentominoePuzzlePiece coveredPiece;
        public PentominoePuzzlePiece CoveredPiece { get { return coveredPiece; }}

        private int coveredUnit = -1;
        public int CoveredUnit { get { return coveredUnit; }}

        private int xIndex;
        public int Xindex { get { return xIndex; } }

        private int yIndex;
        public int Yindex { get { return yIndex; } }

        public PentominoeGameBoardLocation(int x, int y)
        {
            xIndex = x;
            yIndex = y;
        }

        public PentominoeGameBoardLocation(PentominoeGameBoardLocation loc)
        {
            xIndex = loc.xIndex;
            yIndex = loc.yIndex;
            covered = loc.covered;
            coveredPiece = loc.coveredPiece;
            coveredUnit = loc.coveredUnit;
        }
    
        public void CoverLocation(PentominoePuzzlePiece piece, int unitNumber)
        {
            coveredPiece = piece;
            coveredUnit = unitNumber;
        }
    }

    public class PentominoeLocationComparer : IEqualityComparer<PentominoeGameBoardLocation>
    {
        public bool Equals(PentominoeGameBoardLocation loc1, PentominoeGameBoardLocation loc2)
        {
            return (loc1.Xindex == loc2.Xindex) && (loc1.Yindex == loc2.Yindex);
        }
        public int GetHashCode(PentominoeGameBoardLocation obj)
        {
            string hash = obj.Xindex.ToString() + obj.Yindex.ToString();
            return hash.GetHashCode();
        }
    }
    public class PentominoeGameBoard
    {
        private PentominoeGameBoardLocation[,] gameBoard;
        private Dictionary<string, PentominoePuzzlePiece> unUsedPieces;
        private Stack<HashSet<PentominoeGameBoardLocation>> playStack;

        private int boardHeight = 6;
        private int boardWidth = 10;

        public PentominoeGameBoard()
        {
            ResetBoard();   
        }

        private void InitializePuzzlePieces()
        {
            unUsedPieces = new Dictionary<string, PentominoePuzzlePiece>();
            PentominoePuzzlePieceFactory puzzlePieceFactory = new PentominoePuzzlePieceFactory();

            PentominoePuzzlePiece piece = puzzlePieceFactory.CreatePuzzlePiece("X");
            unUsedPieces.Add(piece.pieceName(), piece);

            piece = puzzlePieceFactory.CreatePuzzlePiece("I");
            unUsedPieces.Add(piece.pieceName(), piece);

            piece = puzzlePieceFactory.CreatePuzzlePiece("T");
            unUsedPieces.Add(piece.pieceName(), piece);

            piece = puzzlePieceFactory.CreatePuzzlePiece("U");
            unUsedPieces.Add(piece.pieceName(), piece);

            piece = puzzlePieceFactory.CreatePuzzlePiece("V");
            unUsedPieces.Add(piece.pieceName(), piece);

            piece = puzzlePieceFactory.CreatePuzzlePiece("N");
            unUsedPieces.Add(piece.pieceName(), piece);

            piece = puzzlePieceFactory.CreatePuzzlePiece("W");
            unUsedPieces.Add(piece.pieceName(), piece);

            piece = puzzlePieceFactory.CreatePuzzlePiece("Y");
            unUsedPieces.Add(piece.pieceName(), piece);


            piece = puzzlePieceFactory.CreatePuzzlePiece("P");
            unUsedPieces.Add(piece.pieceName(), piece);


            piece = puzzlePieceFactory.CreatePuzzlePiece("L");
            unUsedPieces.Add(piece.pieceName(), piece);


            piece = puzzlePieceFactory.CreatePuzzlePiece("Z");
            unUsedPieces.Add(piece.pieceName(), piece);


            piece = puzzlePieceFactory.CreatePuzzlePiece("F");
            unUsedPieces.Add(piece.pieceName(), piece);

        }

        public bool ResetBoard()
        {
            gameBoard = new PentominoeGameBoardLocation[boardHeight, boardWidth];

            for (int i = 0; i < boardHeight; i++)
            {
                for (int j = 0; j < boardWidth; j++)
                {
                    PentominoeGameBoardLocation loc = new PentominoeGameBoardLocation(j, i);
                    gameBoard[i, j] = loc;
                }
            }
            playStack = new Stack<HashSet<PentominoeGameBoardLocation>>();

            InitializePuzzlePieces();

            return true;

        }
        public bool CommitPlay(HashSet<PentominoeGameBoardLocation> locations, string pieceName, bool checkSolvable)
        {
            bool ret = true;

            playStack.Push(locations);

            unUsedPieces.Remove(pieceName);
            foreach (PentominoeGameBoardLocation loc in locations)
            {
                gameBoard[loc.Yindex, loc.Xindex] = loc;
            }

            Trace.WriteLine("Pushed Piece " + pieceName + " unit " + locations.First().CoveredUnit + " into " + locations.First().Xindex + "," + locations.First().Yindex);

            if (checkSolvable && !IsBoardPlayable())
            {
                UndoLastPlay();
                ret = false;
            }

            return ret;

        }
        public bool UndoLastPlay()
        {
            if (playStack == null || playStack.Count == 0) return false;
            HashSet<PentominoeGameBoardLocation> lastPlay = playStack.Pop();
            PentominoePuzzlePiece piece = lastPlay.First().CoveredPiece;

            Trace.WriteLine("Removed piece " + piece.pieceName());

            unUsedPieces.Add(piece.pieceName(), piece);

            foreach (PentominoeGameBoardLocation loc in lastPlay)
            {
                //why is this updating my loc value also?
                PentominoeGameBoardLocation boardLocation = gameBoard[loc.Yindex, loc.Xindex];
                boardLocation.CoverLocation(null, -1);
            }

            return true;
        }

        private List<PentominoeGameBoardLocation> getAllBoardLocations(bool includeCovered = true)
        {
            List<PentominoeGameBoardLocation> allLocations = new List<PentominoeGameBoardLocation>();
            for (int i = 0; i < boardHeight; i++)
            {
                for (int j = 0; j < boardWidth; j++)
                {
                    if (includeCovered  || (!includeCovered && !gameBoard[i,j].Covered))
                        allLocations.Add(gameBoard[i, j]);
                }
            }

            return allLocations;

        }

        private PentominoeGameBoardLocation getBoardLocation(int xIndex, int yIndex)
        {
            PentominoeGameBoardLocation loc = null;
            if (xIndex >= 0 && xIndex < boardWidth && yIndex >= 0 && yIndex < boardHeight)
            {
                loc = gameBoard[yIndex, xIndex];
            }
            return loc;
        }

        public string[][] GetBoard()
        {
            string[][] board = new string[boardHeight][];
            for (int i = 0; i < boardHeight; i++)
            {
                board[i] = new string[boardWidth];
                for (int j = 0; j < boardWidth; j++)
                {
                    PentominoeGameBoardLocation loc = gameBoard[i, j];
                    if (loc.Covered)
                        board[i][j] = loc.CoveredPiece.pieceName();

                }
            }
            return board;
        }

        public PentominoePuzzlePiece ChoosePiece(string pieceName)
        {
            if (unUsedPieces == null) return null;
            if (pieceName != null && unUsedPieces.ContainsKey(pieceName)) return unUsedPieces[pieceName];

            return null;

        }

        public bool PlayPiece(PentominoePuzzlePiece piece, int xIndex, int yIndex, int unitNumber, TransformOrientations orientation)
        {
            if (piece == null) return false;
            bool ret = false;
            PentominoeLocationComparer locationComparer = new PentominoeLocationComparer();
            HashSet<PentominoeGameBoardLocation> locationsCovered = new HashSet<PentominoeGameBoardLocation>(locationComparer);

            ret = DoesUnitPieceCoverLocation(piece, unitNumber, xIndex, yIndex, locationsCovered, null, orientation);

            if (ret)
            {
                CommitPlay(locationsCovered, piece.pieceName(), true);
                
            }

            return ret;
        }

        public bool PlayPiece(PentominoePuzzlePiece piece, int xIndex, int yIndex, bool checkSolvable = false)
        {
            if (piece == null) return false;
            PentominoeLocationComparer locationComparer = new PentominoeLocationComparer();

            HashSet<PentominoeGameBoardLocation> locationsCovered = new HashSet<PentominoeGameBoardLocation>(locationComparer);
            bool ret = false;
            string orientString = "";
           
                foreach (TransformOrientations orientation in Enum.GetValues(typeof(TransformOrientations)))
                {
                orientString = orientation.ToString();
               // Trace.WriteLine("Checking Transformation " + orientString);
                for (int i = 0; i < 5; i++)
                {
                   
                    locationsCovered.Clear();
                    //Trace.WriteLine("CHECKING " + piece.pieceName() + " unit " + i);
                    ret = DoesUnitPieceCoverLocation(piece, i, xIndex, yIndex, locationsCovered, null, orientation);

                    if (ret)
                    {
                        ret = CommitPlay(locationsCovered, piece.pieceName(), checkSolvable);
                       
                    }
                    if (ret) break;
                }
                if (ret) break;
            }

       

            return ret;
        }

        private bool DoesUnitPieceCoverLocation(PentominoePuzzlePiece piece, int unitNumber, int xIndex, int yIndex, HashSet<PentominoeGameBoardLocation> updatedLocations, HashSet<int> unitsPlaced, TransformOrientations orientation)
        {
            PentominoeGameBoardLocation location;
            if (updatedLocations == null) return false;

            if (unitsPlaced != null && unitsPlaced.Count == 5) return true;

            //ensure x,y locaiton on the game board and not covered.
            if (xIndex < 0 || yIndex < 0 || xIndex >= boardWidth || yIndex >= boardHeight)
            {
                //Trace.WriteLine(piece.pieceName() + " unit " + unitNumber + "DOES NOT fit at location " + xIndex + " , " + yIndex + "OUT OF BOUNDS");
                return false;
            }
            location = gameBoard[yIndex, xIndex];
            if (location.Covered || updatedLocations.Contains(location))
            {
                //Trace.WriteLine(piece.pieceName() + " unit " + unitNumber + "DOES NOT fit at location " + xIndex + " , " + yIndex + "ALREADY COVERED");
                return false;
            }
            if (unitsPlaced == null)
            {
                unitsPlaced = new HashSet<int>();
            }
            unitsPlaced.Add(unitNumber);

            PentominoeGameBoardLocation l = new PentominoeGameBoardLocation(xIndex, yIndex);
            l.CoverLocation(piece, unitNumber);
            updatedLocations.Add(l);

            bool ret = true;
           // Trace.WriteLine(piece.pieceName() + " unit " + unitNumber + " fits " + ret + " at location " + xIndex + " , " + yIndex);


            PentominoePuzzleUnit unitSquare = piece.getUnits(orientation)[unitNumber];
            foreach (AdjacentLocation adjLoc in unitSquare.adjacentLocations)
            {
                if (adjLoc.Covered && !unitsPlaced.Contains(adjLoc.UnitNumber)) //not every adjacent location is part of the piece and make sure we haven't placed this unit already
                {
                    ret = DoesUnitPieceCoverLocation(piece, adjLoc.UnitNumber, xIndex + adjLoc.Xoffset, yIndex + adjLoc.Yoffset, updatedLocations, unitsPlaced, orientation);
                    if (!ret) break;
                }
            }
            

            return ret;

        }
  
        public bool IsBoardSolved()
        {
            return (unUsedPieces.Count == 0) && (getAllBoardLocations(true).Count == 0);
        }

        public bool IsBoardPlayable()
        {

           // Trace.WriteLine("IS BOARD PLAYABLE");
            //each contiguous block has at least 5 units
            //count number of contiguous blocks and see that each is divisible by 5

            PentominoeLocationComparer locationComparer = new PentominoeLocationComparer();

            HashSet<PentominoeGameBoardLocation> checkedLocation = new HashSet<PentominoeGameBoardLocation>(locationComparer);

            List<PentominoeGameBoardLocation> uncoveredLocations = getAllBoardLocations(false);
            int totalUncovered = uncoveredLocations.Count;


            foreach (PentominoeGameBoardLocation loc in uncoveredLocations)
            {
                PentominoeGameBoardLocation tempLoc = new PentominoeGameBoardLocation(loc);
                if (checkedLocation.Count == totalUncovered) break;

                if (!checkedLocation.Contains(tempLoc))
                {
                    checkedLocation.Add(tempLoc);
                    
                    HashSet<PentominoeGameBoardLocation> contiguousUncoveredLocations = new HashSet<PentominoeGameBoardLocation>(locationComparer);
                    contiguousUncoveredLocations.Add(tempLoc);
                    if (!getEmptyAdjacents(tempLoc, contiguousUncoveredLocations))
                    {
                        return false;  //single uncovered location
                    }
                    else
                    {
                        if (contiguousUncoveredLocations.Count % 5 != 0)
                        {
                            return false;
                        }
                        else
                        {
                            checkedLocation.Union(contiguousUncoveredLocations);
                        }
                    }

                    bool couldAnyPieceFit = false;
                    //if you're left with continguous space that no unUsed pieces could fit into then the board is not playable.
                    foreach(PentominoePuzzlePiece piece in unUsedPieces.Values)
                    {
                        couldAnyPieceFit = couldPieceFit(piece, contiguousUncoveredLocations);
                        if (couldAnyPieceFit) break;
                    }
                    if (!couldAnyPieceFit) return false;

                }
            }

           /* foreach (IPentominoePuzzlePiece piece in unUsedPieces.Values)
            {
                if (!isPiecePlayable(piece))
                    return false;
            }*/

            return true;
        }

        private bool couldPieceFit (PentominoePuzzlePiece piece, HashSet<PentominoeGameBoardLocation> contiguousLocations)
        {
            bool ret = false;
            //determine size of continguous location
            int xMax=0, xMin=0, yMax=0, yMin = 0;
            foreach (PentominoeGameBoardLocation loc in contiguousLocations)
            {
                if (loc.Xindex > xMax) xMax = loc.Xindex;
                if (loc.Xindex < xMin) xMin = loc.Xindex;

                if (loc.Yindex > yMax) yMax = loc.Yindex;
                if (loc.Yindex < yMin) yMin = loc.Yindex;
            }

            int xLength = xMax - xMin + 1;
            int yLength = yMax - yMin + 1;

            if ((piece.Length() <= xLength && piece.Width() <= yLength) || (piece.Length() <= yLength && piece.Width() <= xLength)) ret = true;

            return ret;
        }

        private bool getEmptyAdjacents(PentominoeGameBoardLocation location, HashSet<PentominoeGameBoardLocation> emptyAdjacents)
        {
            if (emptyAdjacents == null)

            {
                PentominoeLocationComparer locationComparer = new PentominoeLocationComparer();
                emptyAdjacents = new HashSet<PentominoeGameBoardLocation>(locationComparer);
            }

            PentominoeGameBoardLocation loc = getBoardLocation(location.Xindex + 1, location.Yindex);
            if (loc != null && !loc.Covered && !emptyAdjacents.Contains(loc))
            {
                emptyAdjacents.Add(loc);
                getEmptyAdjacents(loc, emptyAdjacents);
            }

            loc = getBoardLocation(location.Xindex - 1, location.Yindex);
            if (loc != null && !loc.Covered && !emptyAdjacents.Contains(loc))
            {
                emptyAdjacents.Add(loc);
                getEmptyAdjacents(loc, emptyAdjacents);
            }

            loc = getBoardLocation(location.Xindex, location.Yindex + 1);
            if (loc != null && !loc.Covered && !emptyAdjacents.Contains(loc))
            {
                emptyAdjacents.Add(loc);
                getEmptyAdjacents(loc, emptyAdjacents);
            }

            loc = getBoardLocation(location.Xindex, location.Yindex - 1);
            if (loc != null && !loc.Covered && !emptyAdjacents.Contains(loc))
            {
                emptyAdjacents.Add(loc);
                getEmptyAdjacents(loc, emptyAdjacents);
            }

            if (emptyAdjacents.Count > 0)
                return true;
            else
                return false;
        }


        private bool isPiecePlayable(PentominoePuzzlePiece piece)
        {
            if (piece == null) return false;
            bool ret = false;

            List<PentominoeGameBoardLocation> allUncoveredLocations = getAllBoardLocations(false);
            
            foreach (PentominoeGameBoardLocation loc in allUncoveredLocations)
            {
                if (PlayPiece(piece, loc.Xindex, loc.Yindex, true))
                {
                    ret = true;
                    break;
                }

            }
            return ret;

        }
        public void solveBoardPieceByPiece()
        {
            PlacePieceByPiece(unUsedPieces.Values.ToArray<PentominoePuzzlePiece>());
        }
       private bool PlacePieceByPiece(PentominoePuzzlePiece[] pieceSet)
        {
            if (pieceSet.Length == 0) return true;
         
            bool ret = false;

         
                for (int i = 0; i< pieceSet.Length; i++)
                {
                    PentominoePuzzlePiece piece = ChoosePiece(pieceSet[i].pieceName());
                    List<PentominoeGameBoardLocation> allUncoveredLocations = getAllBoardLocations(false);
                    int index = 0;

                    while (!ret && piece != null && index < allUncoveredLocations.Count)
                    {
                        PentominoeGameBoardLocation loc = allUncoveredLocations[index];
                        ret = PlayPiece(piece, loc.Xindex, loc.Yindex, true);
                        if (ret)
                        {
                            
                            if (i + 1 <  pieceSet.Length)
                            {
                                ArraySegment<PentominoePuzzlePiece> remainingPieces = new ArraySegment<PentominoePuzzlePiece>(pieceSet, i + 1, pieceSet.Length - (i+1));
                                ret = PlacePieceByPiece(remainingPieces.ToArray<PentominoePuzzlePiece>());
                            
                            }
                           

                        }
                        index++;
                    }

                   
                }

          
            return ret;

        }

     
        public void solveBoardLocByLoc()
        {
            bool ret = false;

            while (getAllBoardLocations(false).Count > 0)
            {
                PentominoeGameBoardLocation loc = getAllBoardLocations(false).First();
                if (!loc.Covered)
                {
                    string[] pieceNames = unUsedPieces.Keys.ToArray();
                    foreach (string name in pieceNames)
                    {
                        PentominoePuzzlePiece piece = ChoosePiece(name);
                        if (piece != null)
                        {
                            ret = PlayPiece(piece, loc.Xindex, loc.Yindex, true);
                            if (ret)
                            {
                                break;
                            }
                        }
                    }

                    if (!ret)
                    {
                        UndoLastPlay();
                    }

                }

                
            }
            

        }

    }   
}