using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;


namespace myFirstAzureWebApp.Models
{

    public enum LocationNames { ABOVE_LEFT, ABOVE_CENTER, ABOVE_RIGHT, LEFT, RIGHT, BELOW_LEFT, BELOW_CENTER, BELOW_RIGHT };
    public enum TransformOrientations { DEFAULT , ROTATE_90_COUNTER_CLOCKWISE, ROTATE_90_CLOCKWISE, MIRROR_LEFT, MIRROR_DOWN, ROTATE_180, ROTATE_90_COUNTER_MIRROR_DOWN, ROTATE_90_CLOCK_MIRROR_DOWN};

 

    public interface IPentominoePuzzlePiece
    {
         PentominoePuzzleUnit[] getUnits(TransformOrientations orientation);
         string pieceName();
    }

   
    public abstract class PuzzlePieceFactory
    {
        public abstract IPentominoePuzzlePiece CreatePuzzlePiece(string type);
    }

    public class ConcretePuzzlePieceFactory : PuzzlePieceFactory
    {
        public override IPentominoePuzzlePiece CreatePuzzlePiece(string type)
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
    public class PieceF : IPentominoePuzzlePiece
    {
        public string pieceName()
        {
            return "F";
        }
        private PentominoePuzzleUnit[] units = new PentominoePuzzleUnit[5];

        public PieceF()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, 1, 3, -1, 2);
            units[1] = new PentominoePuzzleUnit(1, -1, -1, -1, 0, -1, -1, -1, 3);
            units[2] = new PentominoePuzzleUnit(2, -1, 0, -1, -1, 3, -1, 4, -1);
            units[3] = new PentominoePuzzleUnit(3, 0, 1, -1, 2, -1, 4, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, 3, -1, 2, -1, -1, -1, -1, -1);


        }

        public PentominoePuzzleUnit[] getUnits(TransformOrientations orientation)
        {
           
           if (orientation == TransformOrientations.DEFAULT)
            return units;

            PentominoePuzzleUnit[] transformedUnits = new PentominoePuzzleUnit[5];

            for (int i=0; i < units.Length; i++)
            {
                transformedUnits[i] = new PentominoePuzzleUnit(units[i], orientation);
            }

            return transformedUnits;
        }
     

    }
    public class PieceV : IPentominoePuzzlePiece
    {
        public string pieceName()
        {
            return "V";
        }
        private PentominoePuzzleUnit[] units = new PentominoePuzzleUnit[5];

        public PieceV()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, -1, 1, -1, -1);
            units[1] = new PentominoePuzzleUnit(1, 0, -1, -1, -1, -1, 2, 3, -1);
            units[2] = new PentominoePuzzleUnit(2, 1, -1, -1, -1, 3, -1, -1, -1);
            units[3] = new PentominoePuzzleUnit(3, -1, -1, 1, 2, 4, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, -1, -1, 3, -1, -1, -1, -1);


        }

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
    public class PieceN : IPentominoePuzzlePiece
    {
        public string pieceName()
        {
            return "N";
        }
        private PentominoePuzzleUnit[] units = new PentominoePuzzleUnit[5];

        public PieceN()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, 1, -1, 2, -1);
            units[1] = new PentominoePuzzleUnit(1, -1, -1, -1, 0, -1, 2, -1, 3);
            units[2] = new PentominoePuzzleUnit(2, 1, -1, 0, -1, 3, -1, -1, -1);
            units[3] = new PentominoePuzzleUnit(3, -1, -1, 1, 2, 4, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, -1, -1, 3, -1, -1, -1, -1);


        }
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
    public class PieceP : IPentominoePuzzlePiece
    {
        public string pieceName()
        {
            return "P";
        }
        private PentominoePuzzleUnit[] units = new PentominoePuzzleUnit[5];

        public PieceP()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, 1, 2, 3, -1);
            units[1] = new PentominoePuzzleUnit(1, -1, -1, -1, 0, -1, 3, -1, 2);
            units[2] = new PentominoePuzzleUnit(2, 0, 1, -1, -1, 3, 4, -1, -1);
            units[3] = new PentominoePuzzleUnit(3, 1, -1, 0, 2, -1, -1, -1, 4);
            units[4] = new PentominoePuzzleUnit(4, 2, 3, -1, -1, -1, -1, -1, -1);


        }
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
    public class PieceT : IPentominoePuzzlePiece
    {
        public string pieceName()
        {
            return "T";
        }
        private PentominoePuzzleUnit[] units = new PentominoePuzzleUnit[5];

        public PieceT()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, -1, 1, -1, -1);
            units[1] = new PentominoePuzzleUnit(1, 0, -1, -1, -1, -1, 3, -1, -1);
            units[2] = new PentominoePuzzleUnit(2, -1, 1, -1, -1, 3, -1, -1, -1);
            units[3] = new PentominoePuzzleUnit(3, 1, -1, -1, 2, 4, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, -1, 2, 3, -1, -1, -1, -1);


        }

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
    public class PieceI: IPentominoePuzzlePiece
    {
        public string pieceName()
        {
            return "I";
        }
        private PentominoePuzzleUnit[] units = new PentominoePuzzleUnit[5];

        public PieceI()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, -1, 1, -1, -1);
            units[1] = new PentominoePuzzleUnit(1, 0, -1, -1, -1, -1, 2, -1, -1);
            units[2] = new PentominoePuzzleUnit(2, 1, -1, -1, -1, -1, 3, -1, -1);
            units[3] = new PentominoePuzzleUnit(3, 2, -1, -1, -1, -1, 4, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, 3, -1, -1, -1, -1, -1, -1, -1);


        }

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
    public class PieceU : IPentominoePuzzlePiece
    {
        public string pieceName()
        {
            return "U";
        }
        private PentominoePuzzleUnit[] units = new PentominoePuzzleUnit[5];

        public PieceU()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, -1, 1, -1, 2);
            units[1] = new PentominoePuzzleUnit(1, 0, -1, -1, -1, 2, -1, -1, -1);
            units[2] = new PentominoePuzzleUnit(2, -1, 1, 0, 1, 3, -1, -1, -1);
            units[3] = new PentominoePuzzleUnit(3, 4, -1, -1, 2, -1, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, -1, -1, -1, -1, 3, 2, -1);


        }

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
    public class PieceL : IPentominoePuzzlePiece
    {
        public string pieceName()
        {
            return "L";
        }
        private PentominoePuzzleUnit[] units = new PentominoePuzzleUnit[5];

        public PieceL()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, -1, 1, -1, -1);
            units[1] = new PentominoePuzzleUnit(1, 0, -1, -1, -1, -1, 2, -1, -1);
            units[2] = new PentominoePuzzleUnit(2, 1, -1, -1, -1, -1, 3, 4, -1);
            units[3] = new PentominoePuzzleUnit(3, 2, -1, -1, -1, 4, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, -1, 2, 3, -1, -1, -1, -1);


        }

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
    public class PieceW : IPentominoePuzzlePiece
    {
        public string pieceName()
        {
            return "W";
        }
        private PentominoePuzzleUnit[] units = new PentominoePuzzleUnit[5];

        public PieceW()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, -1, 1, 2, -1);
            units[1] = new PentominoePuzzleUnit(1, 0, -1, -1, -1, 2, -1, 3, -1);
            units[2] = new PentominoePuzzleUnit(2, 1, -1, 0, 1, -1, 3, 4, -1);
            units[3] = new PentominoePuzzleUnit(3, 2, -1, 1, -1, 4, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, -1, 2, 3, -1, -1, -1, -1);


        }
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
    public class PieceX : IPentominoePuzzlePiece
    {
        public string pieceName()
        {
            return "X";
        }
        private PentominoePuzzleUnit[] units = new PentominoePuzzleUnit[5];
         
        public PieceX()
        {
            units[0] = new PentominoePuzzleUnit(0,-1,-1,-1,-1, -1, 2, 3, 1);
            units[1] = new PentominoePuzzleUnit(1,-1, 0, -1, -1, 2, -1, 4, -1);
            units[2] = new PentominoePuzzleUnit(2,0,-1,-1,1,3,4, -1, -1);
            units[3] = new PentominoePuzzleUnit(3,-1, -1, 0, 2, -1, -1, -1, 4);
            units[4] = new PentominoePuzzleUnit(4,2, 3, 1, -1, -1, -1, -1, -1);
            
            
        }
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
    public class PieceY : IPentominoePuzzlePiece
    {
        public string pieceName()
        {
            return "Y";
        }
        private PentominoePuzzleUnit[] units = new PentominoePuzzleUnit[5];

        public PieceY()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, -1, 2, 3, 1);
            units[1] = new PentominoePuzzleUnit(1, -1, 0, -1, -1, 2, -1, -1, -1);
            units[2] = new PentominoePuzzleUnit(2, 0, -1, -1, 1, 3, -1, -1, -1);
            units[3] = new PentominoePuzzleUnit(3, -1, -1, 0, 2, 4, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, -1, -1, 3, -1, -1, -1, -1);


        }
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
    public class PieceZ : IPentominoePuzzlePiece
    {
        public string pieceName()
        {
            return "Z";
        }
        private PentominoePuzzleUnit[] units = new PentominoePuzzleUnit[5];

        public PieceZ()
        {
            units[0] = new PentominoePuzzleUnit(0, -1, -1, -1, -1, 1, 2, -1, -1);
            units[1] = new PentominoePuzzleUnit(1, -1, -1, -1, 0, -1, -1, -1, 2);
            units[2] = new PentominoePuzzleUnit(2, 0, 1, -1, -1, -1, 3, -1, 4);
            units[3] = new PentominoePuzzleUnit(3, 2, -1, -1, 4, -1, -1, -1, -1);
            units[4] = new PentominoePuzzleUnit(4, -1, -1, 2, -1, 4, -1, -1, -1);


        }

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
        public bool Covered { get { return covered; } set { covered = value; } }

        private IPentominoePuzzlePiece coveredPiece;
        public IPentominoePuzzlePiece CoveredPiece { get { return coveredPiece; } set { coveredPiece = value; } }

        private int coveredUnit;
        public int CoveredUnit { get { return coveredUnit; } set { coveredUnit = value; } }

        private int xIndex;
        public int Xindex { get { return xIndex; } }

        private int yIndex;
        public int Yindex { get { return yIndex; } }

        public PentominoeGameBoardLocation(int x, int y)
        {
            xIndex = x;
            yIndex = y;
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
       private Dictionary<string, IPentominoePuzzlePiece> unUsedPieces;
        
       private int boardHeight = 6;
       private int boardWidth = 10;

        public PentominoeGameBoard()
        {
            gameBoard = new PentominoeGameBoardLocation[boardHeight, boardWidth];
            
            for (int i = 0; i< boardHeight; i++)
            {
                for (int j = 0; j< boardWidth; j++)
                {
                    PentominoeGameBoardLocation loc = new PentominoeGameBoardLocation(j,i);
                    gameBoard[i, j] = loc;
                }
            }

            InitializePuzzlePieces();
        }

        private List<PentominoeGameBoardLocation> getAllBoardLocations()
        {
           List<PentominoeGameBoardLocation> allLocations = new List<PentominoeGameBoardLocation>();
            for (int i = 0; i < boardHeight; i++)
            {
                for (int j = 0; j < boardWidth; j++)
                {
                    allLocations.Add(gameBoard[i, j]);
                }
            }

            return allLocations;

        }

        private PentominoeGameBoardLocation getBoardLocation(int xIndex, int yIndex)
        {
            PentominoeGameBoardLocation loc = null;
            if (xIndex >=0 && xIndex < boardWidth && yIndex >=0 &&  yIndex < boardHeight)
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
                for (int j = 0; j<boardWidth; j++)
                {
                    PentominoeGameBoardLocation loc = gameBoard[i,j];
                    if (loc.Covered)
                        board[i][j] = loc.CoveredPiece.pieceName();
                   
                }
            }
            return board;
        }

        public IPentominoePuzzlePiece ChoosePiece(string pieceName)
        {
            if (unUsedPieces == null) return null;
            if (pieceName != null && unUsedPieces.ContainsKey(pieceName)) return unUsedPieces[pieceName];

            return null;
           

        }

        public bool PlacePiece(IPentominoePuzzlePiece piece, int xIndex, int yIndex, bool checkSolvable = false)
        {
            if (piece == null) return false;

            HashSet<PentominoeGameBoardLocation> locationsCovered = new HashSet<PentominoeGameBoardLocation>();
            bool ret = false;
            for (int i = 0; i < 5; i++)
            {   
               foreach (TransformOrientations orientation in Enum.GetValues(typeof(TransformOrientations)))
                {
                    locationsCovered.Clear();
                    Trace.WriteLine("CHECKING "+ piece.pieceName() + " unit " + i);
                    ret = DoesUnitPieceCoverLocation(piece, i, xIndex, yIndex, locationsCovered, null, orientation);
                    if (ret && !checkSolvable) break;
                    else if (ret && checkSolvable && IsBoardPlayable()) break;
                }
                if (ret) break;
            }

            if (ret)
            {
                unUsedPieces.Remove(piece.pieceName());
                foreach (PentominoeGameBoardLocation loc in locationsCovered)
                {
                    gameBoard[loc.Yindex, loc.Xindex] = loc;
                }
            }
            
            
            return ret;
        }

        private bool DoesUnitPieceCoverLocation(IPentominoePuzzlePiece piece, int unitNumber, int xIndex, int yIndex, HashSet<PentominoeGameBoardLocation> updatedLocations, HashSet<int>unitsPlaced, TransformOrientations orientation)
        {
            PentominoeGameBoardLocation location;
            if (updatedLocations == null) return false;

            if (unitsPlaced != null && unitsPlaced.Count == 5) return true;

            //ensure x,y locaiton on the game board and not covered.
            if (xIndex < 0 || yIndex < 0 || xIndex >= boardWidth || yIndex >= boardHeight)
            {
                Trace.WriteLine(piece.pieceName() + " unit " + unitNumber + "DOES NOT fit at location " + xIndex + " , " + yIndex + "OUT OF BOUNDS");
                return false;
            }
            location = gameBoard[yIndex, xIndex];
            if (location.Covered)
            {
                Trace.WriteLine(piece.pieceName() + " unit " + unitNumber + "DOES NOT fit at location " + xIndex + " , " + yIndex + "ALREADY COVERED");
                return false;
            }
            if (unitsPlaced == null)
            {
                unitsPlaced = new HashSet<int>();
            }
            unitsPlaced.Add(unitNumber);

            PentominoeGameBoardLocation l = new PentominoeGameBoardLocation(xIndex, yIndex);
            l.Covered = true;
            l.CoveredPiece = piece;
            l.CoveredUnit = unitNumber;
            updatedLocations.Add(l);
  
            bool ret = true;


            PentominoePuzzleUnit unitSquare = piece.getUnits(orientation)[unitNumber];
            foreach (AdjacentLocation adjLoc in unitSquare.adjacentLocations)
            {
                if (adjLoc.Covered && !unitsPlaced.Contains(adjLoc.UnitNumber)) //not every adjacent location is part of the piece and make sure we haven't placed this unit already
                {
                    ret = DoesUnitPieceCoverLocation(piece, adjLoc.UnitNumber, xIndex + adjLoc.Xoffset, yIndex + adjLoc.Yoffset, updatedLocations, unitsPlaced, orientation);
                    if (!ret) break;
                }
            }
            Trace.WriteLine(piece.pieceName() + " unit " + unitNumber + " fits " + ret + " at location " + xIndex + " , " + yIndex);

            return ret;

        } 

        public void InitializePuzzlePieces()
        {
            unUsedPieces = new Dictionary<string, IPentominoePuzzlePiece>();
            ConcretePuzzlePieceFactory puzzlePieceFactory = new ConcretePuzzlePieceFactory();

            IPentominoePuzzlePiece piece = puzzlePieceFactory.CreatePuzzlePiece("X");
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
            /*
            unUsedPieces.Add(new PentominoePuzzlePiece("F"));
            
            unUsedPieces.Add(new PentominoePuzzlePiece("L"));
            unUsedPieces.Add(new PentominoePuzzlePiece("N"));
            unUsedPieces.Add(new PentominoePuzzlePiece("P"));
            unUsedPieces.Add(new PentominoePuzzlePiece("T"));
            unUsedPieces.Add(new PentominoePuzzlePiece("U"));
            unUsedPieces.Add(new PentominoePuzzlePiece("V"));
            unUsedPieces.Add(new PentominoePuzzlePiece("W"));
            unUsedPieces.Add(new PentominoePuzzlePiece("Y"));
            unUsedPieces.Add(new PentominoePuzzlePiece("Z"));
            */

        }

        public bool IsBoardPlayable()
        {

            Trace.WriteLine("IS BOARD PLAYABLE");
            //each contiguous block has at least 5 units
            //count number of contiguous blocks and see that each is divisible by 5

            HashSet<PentominoeGameBoardLocation> uncoveredLocations = new HashSet<PentominoeGameBoardLocation>();
            HashSet<PentominoeGameBoardLocation> coveredLocations = new HashSet<PentominoeGameBoardLocation>();
    
           foreach (PentominoeGameBoardLocation loc in getAllBoardLocations())
            {
                if (!loc.Covered && !uncoveredLocations.Contains(loc))
                {
                    uncoveredLocations.Add(loc);
                    Trace.WriteLine("Location " + loc.Xindex + "," + loc.Yindex  + " is NOT covered");

                    HashSet<PentominoeGameBoardLocation> contiguousUncoveredLocations = new HashSet<PentominoeGameBoardLocation>();
                    contiguousUncoveredLocations.Add(loc);
                    if (!getEmptyAdjacents(loc, contiguousUncoveredLocations))
                    {
                        return false;  //single uncovered location
                    }
                    else
                    {
                        if (contiguousUncoveredLocations.Count%5 != 0)
                        {
                            return false;
                        }
                        else
                        {
                            uncoveredLocations.Union(contiguousUncoveredLocations);
                        }
                    }
                        
                }
                else if (loc.Covered)
                {
                    coveredLocations.Add(loc);
                    Trace.WriteLine("Location " + loc.Xindex + "," + loc.Yindex + " is covered");
                }
            }

            return true;
        }

        private bool getEmptyAdjacents (PentominoeGameBoardLocation location, HashSet<PentominoeGameBoardLocation> emptyAdjacents)
        {
            if (emptyAdjacents == null)
            {
                emptyAdjacents = new HashSet<PentominoeGameBoardLocation>();
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

        //I'll need to use stack here to keep track of plays so I can back track.
        public void solveBoard()
        {
            List<string> pieceNames = unUsedPieces.Keys.ToList();

            for (int i = 0; i < boardHeight; i++)
            {
                for (int j = 0; j<boardWidth; j++)
                {
                    bool ret = false;
                    foreach (string pieceName in pieceNames)
                    {
                        IPentominoePuzzlePiece piece = ChoosePiece(pieceName);
                        ret = PlacePiece(piece, j, i);
                        if (ret) break;

                    }
                }
            }
        }
    }

    
}