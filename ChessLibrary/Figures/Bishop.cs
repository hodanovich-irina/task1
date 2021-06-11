using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary.Figures
{
    /// <summary>
    /// Class for bishop
    /// </summary>
    public class Bishop : ChessFigure
    {
        /// <summary>
        /// Constructor with parametr
        /// </summary>
        /// <param name="Color">Figure color</param>
        public Bishop(Color Color)
            : base("Bishop", Color)
        {
            this.Color = Color;
        }

        /// <summary>
        /// Method for the logic of walking bishop
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
            ChessFigure res = null;
            int h = 1;
            if (Math.Abs(x - i) == Math.Abs(y - j) && (newBoard[i, j].Color == Color.black || newBoard[i, j].Color == Color.white))
            {
                if (newBoard[x, y] == null)
                {
                    if ((i == x - 1 && j == y - 1) || (i == x + 1 && j == y + 1) || (i == x - 1 && j == y + 1) || (i == x + 1 && j == y - 1))
                    {
                        h = 0;
                    }
                    if (x - 1 > i && y - 1 > j)
                    {
                        for (int x1 = i + 1, y1 = j + 1; x1 < x && y1 < y; x1++, y1++)
                        {
                            if (newBoard[x1, y1] == null)
                                h = 0;
                        }
                    }
                    if (x - 1 < i && y - 1 < j)
                    {
                        for (int x1 = i - 1, y1 = j - 1; x1 > x && y1 > y; x1--, y1--)
                        {
                            if (newBoard[x1, y1] == null)
                                h = 0;
                        }
                    }
                    if (x - 1 > i && y - 1 < j)
                    {
                        for (int x1 = i + 1, y1 = j - 1; x1 < x && y1 > y; x1++, y1--)
                        {
                            if (newBoard[x1, y1] == null)
                                h = 0;
                        }
                    }
                    if (x - 1 < i && y - 1 > j)
                    {
                        for (int x1 = i - 1, y1 = j + 1; x1 > x && y1 < y; x1--, y1++)
                        {
                            if (newBoard[x1, y1] == null)
                                h = 0;
                        }
                    }
                    if (h == 0)
                    {
                        Logger.Write("The bishop walked(from [" + j.ToString() + ", " + i.ToString() + "] to [" + y.ToString() + ", " + x.ToString() + "])!");
                        ChessFigure figure = newBoard[i, j];
                        ChessFigure str = null;
                        res = figure;
                        newBoard[i, j] = str;
                    }
                    else
                    {
                        Logger.Write("A bishop can't walk like that(from [" + j.ToString() + ", " + i.ToString() + "] to [" + y.ToString() + ", " + x.ToString() + "])!");
                        res = null;
                    }
                }
                else
                {
                    if (x - 1 > i && y - 1 > j)
                    {
                        for (int x1 = i + 1, y1 = j + 1; x1 < x && y1 < y; x1++, y1++)
                        {
                            if (newBoard[x1, y1] == null)
                                h = 0;
                        }
                    }
                    if (x - 1 < i && y - 1 < j)
                    {
                        for (int x1 = i - 1, y1 = j - 1; x1 > x && y1 > y; x1--, y1--)
                        {
                            if (newBoard[x1, y1] == null)
                                h = 0;
                        }
                    }

                    if (x - 1 > i && y - 1 < j)
                    {
                        for (int x1 = i + 1, y1 = j - 1; x1 < x && y1 > y; x1++, y1--)
                        {
                            if (newBoard[x1, y1] == null)
                                h = 0;
                        }
                    }
                    if (x - 1 < i && y - 1 > j)
                    {
                        for (int x1 = i - 1, y1 = j + 1; x1 > x && y1 < y; x1--, y1++)
                        {
                            if (newBoard[x1, y1] == null)
                                h = 0;
                        }
                    }
                    if ((i == x - 1 && j == y - 1) || (i == x + 1 && j == y + 1) || (i == x - 1 && j == y + 1) || (i == x + 1 && j == y - 1))
                    {
                        h = 0;
                    }
                    if (h == 0 && ((newBoard[i, j].Color == Color.black && (newBoard[x, y].Color == Color.white)) || (newBoard[i, j].Color == Color.white && (newBoard[x, y].Color == Color.black))))
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
                        Logger.Write("A bishop can't walk like that(from [" + j.ToString() + ", " + i.ToString() + "] to [" + y.ToString() + ", " + x.ToString() + "])!");
                        res = newBoard[x, y];
                    }
                }
            }
            else
            {
                Logger.Write("A bishop can't walk like that(from [" + j.ToString() + ", " + i.ToString() + "] to [" + y.ToString() + ", " + x.ToString() + "])!");
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
