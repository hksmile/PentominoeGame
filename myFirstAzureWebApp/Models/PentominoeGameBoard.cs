using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;


namespace myFirstAzureWebApp.Models
{

    public enum LocationNames { ABOVE_LEFT, ABOVE_CENTER, ABOVE_RIGHT, LEFT, RIGHT, BELOW_LEFT, BELOW_CENTER, BELOW_RIGHT };

    public interface IPentominoePuzzlePiece
    {
         PentominoePuzzleUnit[] getUnits();
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
            if (type == "X")
            {
                return new PieceX();
            }
            if (type == "I")
            {
                return new PieceI();
            }
            if (type =="T")
            {
                return new PieceT();
            }
            return null;
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

        public PentominoePuzzleUnit[] getUnits()
        {
            //could use orientation to adjust and return adjancent on the fly
            //or... I could put orientation to adjancent in a hash... this might be better... then naming orientations wouldn't really matter and client could just loop through transformations.
            return units;
        }
        public List<PentominoePuzzleUnit[]> getPieceTransformations(int aroundPlacementUnit)
        {
            List<PentominoePuzzleUnit[]> adjacentUnits = new List<PentominoePuzzleUnit[]>();
            return adjacentUnits;
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

        public PentominoePuzzleUnit[] getUnits()
        {
            //could use orientation to adjust and return adjancent on the fly
            //or... I could put orientation to adjancent in a hash... this might be better... then naming orientations wouldn't really matter and client could just loop through transformations.
            return units;
        }
        public List<PentominoePuzzleUnit[]> getPieceTransformations(int aroundPlacementUnit)
        {
            List<PentominoePuzzleUnit[]> adjacentUnits = new List<PentominoePuzzleUnit[]>();
            return adjacentUnits;
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
            units[0] = new PentominoePuzzleUnit(0,-1,-1,-1,-1, -1, 1, 2, 3);
            units[1] = new PentominoePuzzleUnit(1,-1, 0, -1, -1, 2, -1, 4, -1);
            units[2] = new PentominoePuzzleUnit(2,0,-1,-1,1,3,4, -1, -1);
            units[3] = new PentominoePuzzleUnit(3,-1, -1, 0, 2, -1, -1, -1, 4);
            units[4] = new PentominoePuzzleUnit(4,1, 2, 3, -1, -1, -1, -1, -1);
            
            
        }

        public PentominoePuzzleUnit[] getUnits()
        {
            //could use orientation to adjust and return adjancent on the fly
            //or... I could put orientation to adjancent in a hash... this might be better... then naming orientations wouldn't really matter and client could just loop through transformations.
            return units;
        }
        public List<PentominoePuzzleUnit[]> getPieceTransformations(int aroundPlacementUnit)
        {
            List<PentominoePuzzleUnit[]> adjacentUnits = new List<PentominoePuzzleUnit[]>();
            return adjacentUnits;
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
    }

    public class PentominoeGameBoardLocation
    {
        private bool covered = false;
        public bool Covered { get { return covered; } set { covered = value; } }

        private IPentominoePuzzlePiece coveredPiece;
        public IPentominoePuzzlePiece CoveredPiece { get { return coveredPiece; } set { coveredPiece = value; } }

        private int coveredUnit;
        public int CoveredUnit { get { return coveredUnit; } set { coveredUnit = value; } }

    }
    public class PentominoeGameBoard
    {
        PentominoeGameBoardLocation[,] gameBoard;
        Dictionary<string, IPentominoePuzzlePiece> unUsedPieces;
        int boardHeight = 6;
        int boardWidth = 10;

        public PentominoeGameBoard()
        {
            gameBoard = new PentominoeGameBoardLocation[boardWidth, boardHeight];
            for (int i = 0; i< gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j< gameBoard.GetLength(1); j++)
                {
                    gameBoard[i, j] = new PentominoeGameBoardLocation();
                }
            }

            InitializePuzzlePieces();
        }

        public IPentominoePuzzlePiece ChoosePiece(string pieceName)
        {
            if (unUsedPieces == null) return null;
            if (pieceName != null) return unUsedPieces[pieceName];

            return null;
           

        }



         

        public bool PlacePiece(IPentominoePuzzlePiece piece, int xIndex, int yIndex)
        {
            return DoesUnitPieceCoverLocation(piece, 0, xIndex, yIndex, null);     
        }


        //TODO.. needs to ignore units already placed. need additional param
        private bool DoesUnitPieceCoverLocation(IPentominoePuzzlePiece piece, int unitNumber, int xIndex, int yIndex, HashSet<int> unitsPlaced)
        {
            PentominoeGameBoardLocation location;

            if (unitsPlaced != null && unitsPlaced.Count == 5) return true;

            //ensure x,y locaiton on the game board and not covered.
            if (xIndex < 0 || yIndex < 0 || xIndex >= boardWidth || yIndex >= boardHeight)
            {
                Trace.WriteLine(piece.pieceName() + " unit " + unitNumber + "DOES NOT fit at location " + xIndex + " , " + yIndex + "OUT OF BOUNDS");
                return false;
            }
            location = gameBoard[xIndex, yIndex];
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
            

            bool ret = true;

            PentominoePuzzleUnit unitSquare = piece.getUnits()[unitNumber];
            foreach (AdjacentLocation loc in unitSquare.adjacentLocations)
            {
                if (loc.Covered && !unitsPlaced.Contains(loc.UnitNumber)) //not every adjacent location is covered
                {
                    ret = DoesUnitPieceCoverLocation(piece, loc.UnitNumber, xIndex + loc.Xoffset, yIndex + loc.Yoffset, unitsPlaced);
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
    }

    
}