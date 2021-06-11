using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessLibrary;
using ChessLibrary.Figures;
using System.Collections.Generic;

namespace ChessLibraryTestProject
{
    /// <summary>
    /// Class for testing ChessLibrary
    /// </summary>
    [TestClass]
    public class UnitTestChessLibrary
    {
        /// <summary>
        /// Testing Pawn method ToString()
        /// </summary>
        [TestMethod]
        public void TestMethodPawnToString()
        {
            Pawn pawn = new Pawn(Color.white);
            var actual = pawn.ToString();
            var except = "Pawn(white)";
            Assert.AreEqual(except, actual);

        }

        /// <summary>
        /// Testing Bishop method ToString()
        /// </summary>
        [TestMethod]
        public void TestMethodBishopToString()
        {
            Bishop bishop = new Bishop(Color.black);
            var actual = bishop.ToString();
            var except = "Bishop(black)";
            Assert.AreEqual(except, actual);
        }

        /// <summary>
        /// Testing King method ToString()
        /// </summary>
        [TestMethod]
        public void TestMethodKingToString()
        {
            King king = new King(Color.white);
            var actual = king.ToString();
            var except = "King(white)";
            Assert.AreEqual(except, actual);

        }

        /// <summary>
        /// Testing Knight method ToString()
        /// </summary>
        [TestMethod]
        public void TestMethodKnightToString()
        {
            Knight knight = new Knight(Color.black);
            var actual = knight.ToString();
            var except = "Knight(black)";
            Assert.AreEqual(except, actual);
        }

        /// <summary>
        /// Testing Queen method ToString()
        /// </summary>
        [TestMethod]
        public void TestMethodQueenToString()
        {
            Queen queen = new Queen(Color.white);
            var actual = queen.ToString();
            var except = "Queen(white)";
            Assert.AreEqual(except, actual);

        }

        /// <summary>
        /// Testing Rook method ToString()
        /// </summary>
        [TestMethod]
        public void TestMethodRookToString()
        {
            Rook rook = new Rook(Color.black);
            var actual = rook.ToString();
            var except = "Rook(black)";
            Assert.AreEqual(except, actual);
        }

        /// <summary>
        /// Test for Equals() Pawn
        /// </summary>
        [TestMethod]
        public void TestEqualsPawn()
        {
            Pawn pawn = new Pawn(Color.black);
            Pawn pawn1 = new Pawn(Color.white);
            var actual = pawn.Equals(pawn1);
            Assert.IsFalse(actual);

        }

        /// <summary>
        /// Test for Equals() Queen
        /// </summary>
        [TestMethod]
        public void TestEqualsQueen()
        {
            Queen queen = new Queen(Color.white);
            Queen queen1 = new Queen(Color.white);
            var actual = queen.Equals(queen1);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Test for Equals() Rook
        /// </summary>
        [TestMethod]
        public void TestEqualsRook()
        {
            Rook rook = new Rook(Color.black);
            Rook rook1 = new Rook(Color.white);
            var actual = rook.Equals(rook1);
            Assert.IsFalse(actual);

        }

        /// <summary>
        /// Test for Equals() Knight
        /// </summary>
        [TestMethod]
        public void TestEqualsKnight()
        {
            Knight knight = new Knight(Color.white);
            Knight knight1 = new Knight(Color.white);
            var actual = knight.Equals(knight1);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Test for Equals King
        /// </summary>
        [TestMethod]
        public void TestEqualsKing()
        {
            King king = new King(Color.black);
            King king1 = new King(Color.white);
            var actual = king.Equals(king1);
            Assert.IsFalse(actual);

        }

        /// <summary>
        /// Test for Equals() Bishop
        /// </summary>
        [TestMethod]
        public void TestEqualsBishop()
        {
            Bishop bishop = new Bishop(Color.white);
            Bishop bishop1 = new Bishop(Color.white);
            var actual = bishop.Equals(bishop1);
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Test for GetHashCode() Bishop
        /// </summary>
        [TestMethod]
        public void TestToGetHashCodeBishop()
        {
            Bishop bishop = new Bishop(Color.white);
            var actual = bishop.GetHashCode();
            Assert.AreEqual(6, actual);
        }

        /// <summary>
        /// Test for GetHashCode() Rook
        /// </summary>
        [TestMethod]
        public void TestToGetHashCodeRook()
        {
            Rook rook = new Rook(Color.white);
            var actual = rook.GetHashCode();
            Assert.AreEqual(4, actual);
        }

        /// <summary>
        /// Test for GetHashCode() Queen
        /// </summary>
        [TestMethod]
        public void TestToGetHashCodeQueen()
        {
            Queen queen = new Queen(Color.white);
            var actual = queen.GetHashCode();
            Assert.AreEqual(5, actual);
        }

        /// <summary>
        /// Test for GetHashCode() Knight
        /// </summary>
        [TestMethod]
        public void TestToGetHashCodeKnight()
        {
            Knight knight = new Knight(Color.white);
            var actual = knight.GetHashCode();
            Assert.AreEqual(6, actual);
        }

        /// <summary>
        /// Test for GetHashCode() King
        /// </summary>
        [TestMethod]
        public void TestToGetHashCodeKing()
        {
            King king = new King(Color.white);
            var actual = king.GetHashCode();
            Assert.AreEqual(4, actual);
        }

        /// <summary>
        /// Test for GetHashCode() Pawn
        /// </summary>
        [TestMethod]
        public void TestToGetHashCodePawn()
        {
            Pawn pawn = new Pawn(Color.white);
            var actual = pawn.GetHashCode();
            Assert.AreEqual(4, actual);
        }

        /// <summary>
        /// Testing the player's color at the beginning of the game
        /// </summary>
        [TestMethod]
        public void TestMethodStartPlayerColor()
        {
            Chessboard chessboard = new Chessboard();
            Color player = chessboard.player;
            var actual = player;
            var except = Color.white;
            Assert.AreEqual(except, actual);

        }

        /// <summary>
        /// Testing player color change
        /// </summary>
        [TestMethod]
        public void TestMethodNextPlayerColor()
        {
            Chessboard chessboard = new Chessboard();
            ChessFigure[,] Board = chessboard.StartBoard();
            chessboard.GamePlay(0, 6, 0, 4, Board);
            Color player = chessboard.player;
            var actual = player;
            var except = Color.black;

            Assert.AreEqual(except, actual);
        }
        /// <summary>
        /// Testing a player's color on a wrong move
        /// </summary>
        [TestMethod]
        public void TestMethodPlayerColor()
        {
            Chessboard chessboard = new Chessboard();
            ChessFigure[,] Board = chessboard.StartBoard();
            chessboard.GamePlay(0, 1, 0, 2, Board);
            Color player = chessboard.player;
            var actual = player;
            var except = Color.white;

            Assert.AreEqual(except, actual);
        }

        /// <summary>
        /// Testing a Pawn move
        /// </summary>
        [TestMethod]
        public void TestMethodPawnLogic()
        {
            List<ChessFigure> chessFiguresWhite = new List<ChessFigure>();
            List<ChessFigure> chessFiguresBlack = new List<ChessFigure>();
            Chessboard chessboard = new Chessboard();
            ChessFigure[,] Board = chessboard.StartBoard();
            Pawn pawn = new Pawn(Color.black);
            var actual = pawn.FigureLogic(0, 1, 0, 2, Board, chessFiguresWhite, chessFiguresBlack);
            Assert.AreEqual(pawn, actual);
        }

        /// <summary>
        /// Testing a Knight move
        /// </summary>
        [TestMethod]
        public void TestMethodKnightLogic()
        {
            List<ChessFigure> chessFiguresWhite = new List<ChessFigure>();
            List<ChessFigure> chessFiguresBlack = new List<ChessFigure>();
            Chessboard chessboard = new Chessboard();
            ChessFigure[,] Board = chessboard.StartBoard();
            Knight knight = new Knight(Color.black);
            var actual = knight.FigureLogic(1, 0, 0, 2, Board, chessFiguresWhite, chessFiguresBlack);
            Assert.AreEqual(knight, actual);
        }
        /// <summary>
        /// Testing when a Pawn can't move
        /// </summary>
        [TestMethod]
        public void TestMethodPawnLogic2()
        {
            List<ChessFigure> chessFiguresWhite = new List<ChessFigure>();
            List<ChessFigure> chessFiguresBlack = new List<ChessFigure>();
            Chessboard chessboard = new Chessboard();
            ChessFigure[,] Board = chessboard.StartBoard();
            Pawn pawn = new Pawn(Color.black);
            var actual = pawn.FigureLogic(0, 1, 1, 2, Board, chessFiguresWhite, chessFiguresBlack);
            Assert.AreEqual(null, actual);
        }
        /// <summary>
        /// Testing a Bishop move
        /// </summary>
        [TestMethod]
        public void TestMethodBishopLogic()
        {
            List<ChessFigure> chessFiguresWhite = new List<ChessFigure>();
            List<ChessFigure> chessFiguresBlack = new List<ChessFigure>();
            Chessboard chessboard = new Chessboard();
            ChessFigure[,] Board = chessboard.StartBoard();
            Board = chessboard.GamePlay(0, 6, 0, 5, Board);
            Board = chessboard.GamePlay(2, 1, 2, 3, Board);
            Board = chessboard.GamePlay(0, 5, 0, 4, Board);
            Board = chessboard.GamePlay(3, 1, 3, 3, Board);
            Board = chessboard.GamePlay(0, 4, 0, 3, Board);
            Bishop bishop = new Bishop(Color.black);
            var actual = bishop.FigureLogic(2, 0, 3, 1, Board, chessFiguresWhite, chessFiguresBlack);
            Assert.AreEqual(bishop, actual);
        }

        /// <summary>
        /// Testing a King move
        /// </summary>
        [TestMethod]
        public void TestMethodKingLogic()
        {
            List<ChessFigure> chessFiguresWhite = new List<ChessFigure>();
            List<ChessFigure> chessFiguresBlack = new List<ChessFigure>();
            Chessboard chessboard = new Chessboard();
            ChessFigure[,] Board = chessboard.StartBoard();
            Board = chessboard.GamePlay(0, 6, 0, 4, Board);
            Board = chessboard.GamePlay(3, 1, 3, 3, Board);
            Board = chessboard.GamePlay(0, 4, 0, 3, Board);
            King king = new King(Color.black);
            var actual = king.FigureLogic(3, 0, 3, 1, Board, chessFiguresWhite, chessFiguresBlack);
            Assert.AreEqual(king, actual);
        }

        /// <summary>
        /// Testing a Queen move
        /// </summary>
        [TestMethod]
        public void TestMethodQueenLogic()
        {
            List<ChessFigure> chessFiguresWhite = new List<ChessFigure>();
            List<ChessFigure> chessFiguresBlack = new List<ChessFigure>();
            Chessboard chessboard = new Chessboard();
            ChessFigure[,] Board = chessboard.StartBoard();
            Queen queen = new Queen(Color.black);
            Board = chessboard.GamePlay(0, 6, 0, 4, Board);
            Board = chessboard.GamePlay(4, 1, 4, 3, Board);
            Board = chessboard.GamePlay(0, 4, 0, 3, Board);
            var actual = queen.FigureLogic(4, 0, 4, 2, Board, chessFiguresWhite, chessFiguresBlack);
            Assert.AreEqual(queen, actual);
        }

        /// <summary>
        /// Testing a Rook move
        /// </summary>
        [TestMethod]
        public void TestMethodRookLogic()
        {
            List<ChessFigure> chessFiguresWhite = new List<ChessFigure>();
            List<ChessFigure> chessFiguresBlack = new List<ChessFigure>();
            Chessboard chessboard = new Chessboard();
            ChessFigure[,] Board = chessboard.StartBoard();
            Rook rook = new Rook(Color.black);
            Board = chessboard.GamePlay(0, 6, 0, 4, Board);
            Board = chessboard.GamePlay(0, 1, 0, 3, Board);
            Board = chessboard.GamePlay(0, 4, 0, 3, Board);
            var actual = rook.FigureLogic(0, 0, 0, 2, Board, chessFiguresWhite, chessFiguresBlack);
            Assert.AreEqual(rook, actual);
        }

        /// <summary>
        /// Testing play state
        /// </summary>
        [TestMethod]
        public void TestMethodStatePlay()
        {
            Chessboard chessboard = new Chessboard();
            ChessFigure[,] Board = chessboard.StartBoard();
            Board = chessboard.GamePlay(3, 6, 3, 4, Board);
            Board = chessboard.GamePlay(0, 1, 0, 3, Board);
            var actual = chessboard.game;
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        /// Testing win  
        /// </summary>
        [TestMethod]
        public void TestMethodWin()
        {
            Chessboard chessboard = new Chessboard();
            ChessFigure[,] Board = chessboard.StartBoard();
            Board = chessboard.GamePlay(3, 6, 3, 4, Board);
            Board = chessboard.GamePlay(0, 1, 0, 3, Board);
            Board = chessboard.GamePlay(5, 6, 5, 5, Board);
            Board = chessboard.GamePlay(0, 0, 0, 2, Board);
            Board = chessboard.GamePlay(5, 5, 5, 4, Board);
            Board = chessboard.GamePlay(0, 2, 1, 2, Board);
            Board = chessboard.GamePlay(5, 4, 5, 3, Board);
            Board = chessboard.GamePlay(1, 2, 1, 5, Board);
            Board = chessboard.GamePlay(5, 3, 5, 2, Board);
            Board = chessboard.GamePlay(1, 5, 3, 5, Board);
            Board = chessboard.GamePlay(6, 6, 6, 4, Board);
            chessboard.GamePlay(3, 5, 3, 7, Board);

            var actual = chessboard.game;
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Testing IClonable
        /// </summary>
        [TestMethod]
        public void TestMethodClone()
        {
            Pawn pawn = new Pawn(Color.black);
            Assert.AreEqual(pawn, pawn.Clone());
        }
    }
}
