using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary.Figures
{
    /// <summary>
    /// Class for rook
    /// </summary>
    public class Rook : ChessFigure
    {
        /// <summary>
        /// Constructor with parametrs
        /// </summary>
        /// <param name="Color">Figure color</param>
        public Rook(Color Color)
            : base("Rook", Color)
        {
            this.Color = Color;
        }

        /// <summary>
        /// Method for the logic of walking king
        /// </summary>
        /// <param name="j">where the shape comes from vertically</param>
        /// <param name="i">where the shape comes from horizontally</param>
        /// <param name="y">where the shape goes vertically</param>
        /// <param name="x">where the shape goes horizontally</param>
        /// <param name="board">Chess board</param>
        /// <param name="chessFiguresBlack">List of black knocked down figures</param>
        /// <param name="chessFiguresWhite">List of white knocked down figures</param>
        /// <returns>Chess figure</returns>
        public override ChessFigure FigureLogic(int j, int i, int y, int x, ChessFigure[,] board, List<ChessFigure> chessFiguresBlack, List<ChessFigure> chessFiguresWhite)
        {
            ChessFigure[,] newBoard = board;
            bool k = false;
            ChessFigure res = null;

            if (i != x && j == y && (newBoard[i, j].Color == Color.black || newBoard[i, j].Color == Color.white))
            {
                if (newBoard[x, y] == null)
                {
                    if (i == x - 1 || i == x + 1)
                    {
                        k = true;
                    }
                    if (i < x)
                    {
                        for (int x1 = i + 1; x1 < x; x1++)
                        {
                            if (newBoard[x1, y] == null)
                                k = true;
                        }
                    }
                    if (i > x)
                    {
                        for (int x1 = x + 1; x1 < i; x1++)
                        {
                            if (newBoard[x1, y] == null)
                                k = true;
                        }
                    }
                    if (k == true)
                    {
                        Logger.Write("The rook walked (from [" + j.ToString() + ", " + i.ToString() + "] to [" + y.ToString() + ", " + x.ToString() + "])!");
                        ChessFigure figure = newBoard[i, j];
                        ChessFigure str = null;
                        res = figure;
                        newBoard[i, j] = str;
                    }
                    else
                    {
                        Logger.Write("A rook can't walk like that(from [" + j.ToString() + ", " + i.ToString() + "] to [" + y.ToString() + ", " + x.ToString() + "])!");
                        res = newBoard[x, y];
                    }
                }
                else
                {
                    if (i == x - 1 || i == x + 1)
                    {
                        k = true;
                    }

                    if (i < x)
                    {
                        for (int x1 = i + 1; x1 < x; x1++)
                        {
                            if (newBoard[x1, y] == null)
                                k = true;
                        }
                    }
                    if (i > x)
                    {
                        for (int x1 = x + 1; x1 < i; x1++)
                        {
                            if (newBoard[x1, y] == null)
                                k = true;
                        }
                    }

                    if (k == true && ((newBoard[i, j].Color == Color.black && newBoard[x, y].Color == Color.white) || (newBoard[i, j].Color == Color.white && newBoard[x, y].Color == Color.black)))
                    {
                        if (newBoard[i, j].Color == Color.black)
                        {
                            ChessFigure chessFigure = (ChessFigure)newBoard[x, y].Clone();
                            chessFiguresWhite.Add(chessFigure);
                            Logger.Write("You knocked down: " + chessFigure + " with coordinates [" + y.ToString() + ", " + x.ToString() + "].");

                        }
                        if (newBoard[i, j].Color == Color.white)
                        {
                            ChessFigure chessFigure = (ChessFigure)newBoard[x, y].Clone();
                            chessFiguresBlack.Add(chessFigure);
                            Logger.Write("You knocked down: " + chessFigure + " with coordinates [" + y.ToString() + ", " + x.ToString() + "].");


                        }
                        ChessFigure figure = newBoard[i, j];
                        ChessFigure str = null;
                        res = figure;
                        newBoard[i, j] = str;
                    }
                    else
                    {
                        Logger.Write("A rook can't walk like that(from [" + j.ToString() + ", " + i.ToString() + "] to [" + y.ToString() + ", " + x.ToString() + "])!");
                        res = newBoard[x, y];
                    }
                }
            }
            else if (i == x && j != y && (newBoard[i, j].Color == Color.black || newBoard[i, j].Color == Color.white))
            {
                if (j == y - 1 || j == y + 1)
                {
                    k = true;
                }
                if (newBoard[x, y] == null)
                {
                    if (y > j)
                    {
                        for (int y1 = j + 1; y1 < y; y1++)
                        {
                            if (newBoard[x, y1] == null)
                                k = true;
                        }
                    }
                    if (y < j)
                    {
                        for (int y1 = y + 1; y1 < j; y1++)
                        {
                            if (newBoard[x, y1] == null)
                                k = true;
                        }
                    }
                    if (k == true)
                    {
                        Logger.Write("The rook walked (from [" + j.ToString() + ", " + i.ToString() + "] to [" + y.ToString() + ", " + x.ToString() + "])!");
                        ChessFigure figure = newBoard[i, j];
                        ChessFigure str = null;
                        res = figure;
                        newBoard[i, j] = str;
                    }
                    else
                    {
                        Logger.Write("A rook can't walk like that(from [" + j.ToString() + ", " + i.ToString() + "] to [" + y.ToString() + ", " + x.ToString() + "])!");
                        res = newBoard[x, y];
                    }
                }
                else
                {
                    if (j == y - 1 || j == y + 1)
                    {
                        k = true;
                    }
                    if (y > j)
                    {
                        for (int y1 = j + 1; y1 < y - 1; y1++)
                        {
                            if (newBoard[x, y1] == null)
                                k = true;
                        }
                    }
                    if (y < j)
                    {
                        for (int y1 = y + 1; y1 < j; y1++)
                        {
                            if (newBoard[x, y1] == null)
                                k = true;
                        }
                    }

                    if (k == true && ((newBoard[i, j].Color == Color.black && newBoard[x, y].Color == Color.white) || (newBoard[i, j].Color == Color.white && newBoard[x, y].Color == Color.black)))
                    {
                        if (newBoard[i, j].Color == Color.black)
                        {
                            ChessFigure chessFigure = (ChessFigure)newBoard[x, y].Clone();
                            chessFiguresWhite.Add(chessFigure);
                            Logger.Write("You knocked down: " + chessFigure + " with coordinates [" + y.ToString() + ", " + x.ToString() + "].");

                        }
                        if (newBoard[i, j].Color == Color.white)
                        {
                            ChessFigure chessFigure = (ChessFigure)newBoard[x, y].Clone();
                            chessFiguresBlack.Add(chessFigure);
                            Logger.Write("You knocked down: " + chessFigure + " with coordinates [" + y.ToString() + ", " + x.ToString() + "].");


                        }
                        ChessFigure figure = newBoard[i, j];
                        ChessFigure str = null;
                        res = figure;
                        newBoard[i, j] = str;
                    }
                    else
                    {
                        Logger.Write("A rook can't walk like that(from [" + j.ToString() + ", " + i.ToString() + "] to [" + y.ToString() + ", " + x.ToString() + "])!");
                        res = newBoard[x, y];
                    }
                }

            }
            else
            {
                Logger.Write("A rook can't walk like that(from [" + j.ToString() + ", " + i.ToString() + "] to [" + y.ToString() + ", " + x.ToString() + "])!");
                res = newBoard[x, y];
            }
            return res;
        }

        /// <summary>
        /// Override method ToString()
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// Method overriding GetHashCode()
        /// </summary>
        /// <returns>Hash-code</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Method overriding Equals()
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>True or false</returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
