using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myFirstAzureWebApp.Models;

namespace myFirstAzureWebApp.Controllers
{
    
    public class HomeController : Controller
    {
      

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TwoJS()
        {
           PentominoeGameBoard board = new PentominoeGameBoard();
            Session["Board"] = board;
            ViewBag.Message = "Your TwoJs Play Page";
            string[][] b = board.GetBoard();

            ViewBag.Board = Json(b);

           return View(Json(b));
        }

        public ActionResult TestAngular()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TwoJs(string PuzzlePiece, int xLocation = 0, int yLocation = 0, int unitNumber = 0, TransformOrientations orientation = TransformOrientations.DEFAULT)
        {
            PentominoeGameBoard board =(PentominoeGameBoard) Session["Board"];

            if (PuzzlePiece != "")
            {
                PentominoePuzzlePiece piece = board.ChoosePiece(PuzzlePiece);
                bool ret = board.PlayPiece(piece, xLocation, yLocation);
            }
            else
                board.solveBoardPieceByPiece();

            return View(Json(board.GetBoard()));
        }

        public ActionResult GetBoard()
        {
            ViewBag.Message = "Your TwoJs Play Page";

            PentominoeGameBoard board = (PentominoeGameBoard)Session["Board"];
            return Json(board.GetBoard(), JsonRequestBehavior.AllowGet);
        }
    }
}