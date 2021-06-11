using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary.Figures
{
    /// <summary>
    /// Class for knight
    /// </summary>
    public class Knight : ChessFigure
    {
        /// <summary>
        /// Constructor with parametrs
        /// </summary>
        /// <param name="Color">Figure color</param>
        public Knight(Color Color)
            : base("Knight", Color)
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

            ChessFigure res = null;
            if (((newBoard[i, j].Color == Color.black) || (newBoard[i, j].Color == Color.white)) && ((Math.Abs(x - i) == 1 && Math.Abs(j - y) == 2) || (Math.Abs(x - i) == 2 && Math.Abs(j - y) == 1)) && newBoard[x, y] == null)
            {
                Logger.Write("The knight walked (from [" + j.ToString() + ", " + i.ToString() + "] to [" + y.ToString() + ", " + x.ToString() + "])!");
                ChessFigure figure = newBoard[i, j];
                ChessFigure str = null;
                res = figure;
                newBoard[i, j] = str;
            }
            else if ((newBoard[i, j].Color == Color.white && (newBoard[x, y].Color == Color.black)) || (newBoard[i, j].Color == Color.black && (newBoard[x, y].Color == Color.white)))
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
                Logger.Write("A knight can't walk like that(from [" + j.ToString() + ", " + i.ToString() + "] to [" + y.ToString() + ", " + x.ToString() + "])!");
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
