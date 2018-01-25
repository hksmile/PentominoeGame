﻿using System;
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

        [HttpPost]
        public ActionResult TwoJs(string PuzzlePiece, int xLocation, int yLocation)
        {
            PentominoeGameBoard board =(PentominoeGameBoard) Session["Board"];

            IPentominoePuzzlePiece piece = board.ChoosePiece(PuzzlePiece);
            bool ret = board.PlacePiece(piece, xLocation, yLocation);
            return View(Json(board.GetBoard()));
        }

        public ActionResult GetBoard()
        {
            ViewBag.Message = "Your TwoJs Play Page";

            PentominoeGameBoard board = new PentominoeGameBoard();
            IPentominoePuzzlePiece piece = board.ChoosePiece("Z");
            bool ret = board.PlacePiece(piece, 1, 5);
            string[][] b = board.GetBoard();

            ViewBag.Board = Json(b);

            return View();
        }
    }
}