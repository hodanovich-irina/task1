using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary.Figures
{
    /// <summary>
    /// Color enum
    /// </summary>
    public enum Color
    {
        /// <summary>
        /// Color white
        /// </summary>
        white = 1,
        /// <summary>
        /// Color black
        /// </summary>
        black
    }
    /// <summary>
    /// Base abstract class for chess figure
    /// </summary>
    public abstract class ChessFigure : ICloneable
    {
        /// <summary>
        /// Constructor with parametrs
        /// </summary>
        /// <param name="name">name figure</param>
        /// <param name="color">color figure</param>
        protected ChessFigure(string name, Color color)
        {
            Name = name;
            Color = color;
        }
        /// <summary>
        /// Figure name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Figure color
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Override method ToString()
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return Name + "(" + Color.ToString() + ")";
        }

        /// <summary>
        /// Method overriding GetHashCode()
        /// </summary>
        /// <returns>Hash-code</returns>
        public override int GetHashCode()
        {
            return Name.Length;
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
            ChessFigure chessFigure = (ChessFigure)obj;
            if (Name != chessFigure.Name || Color != chessFigure.Color)
                return false;
            return true;
        }

        /// <summary>
        /// Realize interface IClonable
        /// </summary>
        /// <returns>ChessFigure object</returns>
        public object Clone()
        {
            ChessFigure chessFigure = null;
            switch (Name)
            {
                case "Pawn":
                    chessFigure = new Pawn(Color);
                    break;
                case "Bishop":
                    chessFigure = new Bishop(Color);
                    break;
                case "King":
                    chessFigure = new King(Color);
                    break;
                case "Knight":
                    chessFigure = new Knight(Color);
                    break;
                case "Queen":
                    chessFigure = new Queen(Color);
                    break;
                case "Rook":
                    chessFigure = new Rook(Color);
                    break;
            }
            return chessFigure;
        }

        /// <summary>
        /// Abstract method for the logic of walking figures
        /// </summary>
        /// <param name="j">where the shape comes from vertically</param>
        /// <param name="i">where the shape comes from horizontally</param>
        /// <param name="y">where the shape goes vertically</param>
        /// <param name="x">where the shape goes horizontally</param>
        /// <param name="board">Chess board</param>
        /// <param name="chessFiguresBlack">List of black knocked down figures</param>
        /// <param name="chessFiguresWhite">List of white knocked down figures</param>
        /// <returns>Chess figure</returns>
        public abstract ChessFigure FigureLogic(int j, int i, int y, int x, ChessFigure[,] board, List<ChessFigure> chessFiguresBlack, List<ChessFigure> chessFiguresWhite);



    }
}
