using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessLibrary.Figures;

namespace ChessLibrary
{
    /// <summary>
    /// Class for a chess game between two players
    /// </summary>
    public class Chessboard
    {
        /// <summary>
        /// List of black knocked down figures
        /// </summary>
        List<ChessFigure> chessFiguresBlack = new List<ChessFigure>();

        /// <summary>
        /// List of white knocked down figures
        /// </summary>
        List<ChessFigure> chessFiguresWhite = new List<ChessFigure>();

        /// <summary>
        /// Player
        /// </summary>
        public Color player = Color.white;

        /// <summary>
        /// Game state
        /// </summary>
        public bool game = true;

        /// <summary>
        /// Inner class for cells
        /// </summary>
        class Cell
        {
            /// <summary>
            /// Method for return cell
            /// </summary>
            /// <param name="i">cell number vertically</param>
            /// <param name="j">cell number horizontally</param>
            /// <returns>Cell</returns>
            public string AllCells(int i, int j)
            {
                string[] gorizont = new string[] { "A", "B", "C", "D", "E", "F", "G", "H" };
                string[] vertical = new string[] { "1", "2", "3", "4", "5", "6", "7", "8" };
                string cell = gorizont[j] + vertical[i].ToString();

                return cell;
            }
        }

        /// <summary>
        /// Object of inner class
        /// </summary>
        Cell cell = new Cell();

        /// <summary>
        /// Method for create start board
        /// </summary>
        /// <returns>Start board</returns>
        public ChessFigure[,] StartBoard()
        {
            ChessFigure[,] Board = new ChessFigure[8, 8];
            Logger.Write("Start play");

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    switch (cell.AllCells(i, j))
                    {
                        case "A1":
                            Board[i, j] = new Rook(Color.black);
                            break;
                        case "H1":
                            Board[i, j] = new Rook(Color.black);
                            break;
                        case "B1":
                            Board[i, j] = new Knight(Color.black);
                            break;
                        case "G1":
                            Board[i, j] = new Knight(Color.black);
                            break;
                        case "F1":
                            Board[i, j] = new Bishop(Color.black);
                            break;
                        case "C1":
                            Board[i, j] = new Bishop(Color.black);
                            break;
                        case "E1":
                            Board[i, j] = new Queen(Color.black);
                            break;
                        case "D1":
                            Board[i, j] = new King(Color.black);
                            break;
                        case "A2":
                            Board[i, j] = new Pawn(Color.black);
                            break;
                        case "H2":
                            Board[i, j] = new Pawn(Color.black);
                            break;
                        case "B2":
                            Board[i, j] = new Pawn(Color.black);
                            break;
                        case "G2":
                            Board[i, j] = new Pawn(Color.black);
                            break;
                        case "F2":
                            Board[i, j] = new Pawn(Color.black);
                            break;
                        case "C2":
                            Board[i, j] = new Pawn(Color.black);
                            break;
                        case "E2":
                            Board[i, j] = new Pawn(Color.black);
                            break;
                        case "D2":
                            Board[i, j] = new Pawn(Color.black);
                            break;
                        case "A8":
                            Board[i, j] = new Rook(Color.white);
                            break;
                        case "H8":
                            Board[i, j] = new Rook(Color.white);
                            break;
                        case "B8":
                            Board[i, j] = new Knight(Color.white);
                            break;
                        case "G8":
                            Board[i, j] = new Knight(Color.white);
                            break;
                        case "F8":
                            Board[i, j] = new Bishop(Color.white);
                            break;
                        case "C8":
                            Board[i, j] = new Bishop(Color.white);
                            break;
                        case "E8":
                            Board[i, j] = new Queen(Color.white);
                            break;
                        case "D8":
                            Board[i, j] = new King(Color.white);
                            break;
                        case "A7":
                            Board[i, j] = new Pawn(Color.white);
                            break;
                        case "H7":
                            Board[i, j] = new Pawn(Color.white);
                            break;
                        case "B7":
                            Board[i, j] = new Pawn(Color.white);
                            break;
                        case "G7":
                            Board[i, j] = new Pawn(Color.white);
                            break;
                        case "F7":
                            Board[i, j] = new Pawn(Color.white);
                            break;
                        case "C7":
                            Board[i, j] = new Pawn(Color.white);
                            break;
                        case "E7":
                            Board[i, j] = new Pawn(Color.white);
                            break;
                        case "D7":
                            Board[i, j] = new Pawn(Color.white);
                            break;

                        default:
                            Board[i, j] = null;
                            break;
                    }
                }
            }
            return Board;
        }

        /// <summary>
        /// Method for playing
        /// </summary>
        /// <param name="j">where the shape comes from vertically</param>
        /// <param name="i">where the shape comes from horizontally</param>
        /// <param name="y">where the shape goes vertically</param>
        /// <param name="x">where the shape goes horizontally</param>
        /// <param name="board">Chess board</param>
        /// <returns>New chess board</returns>
        public ChessFigure[,] GamePlay(int j, int i, int y, int x, ChessFigure[,] board)
        {
            ChessFigure[,] newBoard = board;

            if (newBoard[i, j] == null)
            {
                Logger.Write("You can't walk! No shape selected. Cell with parameters [" + j.ToString() + ", " + i.ToString() + "] is empty.");
                return newBoard;
            }

            if (newBoard[i, j].Color != player)
            {
                Logger.Write("You can't walk! The shape is the wrong color! " + player.ToString() + " player must walk");
                return newBoard;
            }

            if (newBoard[i, j].Name == "Pawn")
                newBoard[x, y] = newBoard[i, j].FigureLogic(j, i, y, x, newBoard, chessFiguresBlack, chessFiguresWhite);

            else if (newBoard[i, j].Name == "Knight")
                newBoard[x, y] = newBoard[i, j].FigureLogic(j, i, y, x, newBoard, chessFiguresBlack, chessFiguresWhite);

            else if (newBoard[i, j].Name == "Bishop")
                newBoard[x, y] = newBoard[i, j].FigureLogic(j, i, y, x, newBoard, chessFiguresBlack, chessFiguresWhite);

            else if (newBoard[i, j].Name == "Rook")
                newBoard[x, y] = newBoard[i, j].FigureLogic(j, i, y, x, newBoard, chessFiguresBlack, chessFiguresWhite);

            else if (newBoard[i, j].Name == "Queen")
                newBoard[x, y] = newBoard[i, j].FigureLogic(j, i, y, x, newBoard, chessFiguresBlack, chessFiguresWhite);
            else if (newBoard[i, j].Name == "King")
                newBoard[x, y] = newBoard[i, j].FigureLogic(j, i, y, x, newBoard, chessFiguresBlack, chessFiguresWhite);
            else
            {
                ChessFigure figure = newBoard[i, j];
                ChessFigure str = newBoard[x, y];
                newBoard[x, y] = figure;
                newBoard[i, j] = str;
            }

            if (newBoard[i, j] == null && game == true)
                player = player == Color.white ? Color.black : Color.white;
            foreach (var v in chessFiguresBlack)
            {
                if (v.Name == "King")
                {
                    Logger.Write("Game over, white win!");
                    game = false;

                }
            }

            foreach (var v in chessFiguresWhite)
            {
                if (v.Name == "King")
                {
                    Logger.Write("Game over, black win!");
                    game = false;
                }
            }

            return newBoard;
        }

        /// <summary>
        /// Override method ToString()
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return player.ToString();
        }

        /// <summary>
        /// Method overriding GetHashCode()
        /// </summary>
        /// <returns>Hash-code</returns>
        public override int GetHashCode()
        {
            return chessFiguresBlack.Count + chessFiguresWhite.Count;
        }

        /// <summary>
        /// Method overriding Equals()
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>True or false</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Chessboard chessboard = (Chessboard)obj;
            if ( player != chessboard.player || game != chessboard.game || chessFiguresBlack.Count != chessboard.chessFiguresBlack.Count || chessFiguresWhite.Count != chessboard.chessFiguresWhite.Count)
                return false;
            return true;
        }
    }
}

