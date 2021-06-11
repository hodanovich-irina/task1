using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ChessLibrary
{
    /// <summary>
    /// Class for logging moves
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// The path of the file to save the logging of moves
        /// </summary>
        private static string path = @"../../LoggerWrite.txt";
        /// <summary>
        /// Method for recording moves
        /// </summary>
        /// <param name="message"></param>
        public static void Write(string message)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(DateTime.Now.ToString() + " " + message);
            }
        }
    }
}
