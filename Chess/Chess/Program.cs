using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("White Rook Start");
            var poswhite = Console.ReadLine().ToLower();
            Console.WriteLine("Black Queen Start");
            var posblack = Console.ReadLine().ToLower();
            Console.WriteLine("Is Rook Can Move ?");
            var movewhite = Console.ReadLine().ToLower();
            Console.WriteLine("Able To Move?, {0}", MoveRook(poswhite, movewhite), MoveQueen(posblack, movewhite));
            Console.ReadKey();
        }
        static void Decoding(string position,
            out int column, out int row)
        {
            column = (int)position[0] - 0x60;
            row = (int)position[1] - 0x30;

        }
        static bool MoveRook(string start, string end)
        {
            int startColumn, startRow, endColumn, endRow;
            Decoding(start, out startColumn, out startRow);
            Decoding(end, out endColumn, out endRow);
            return startColumn == endColumn || startRow == endRow || Math.Abs(startColumn - endColumn) != 0;
        }
        static bool MoveQueen(string start, string end)
        {
            int startColumn, startRow, endColumn, endRow;
            Decoding(start, out startColumn, out startRow);
            Decoding(end, out endColumn, out endRow);
            return startColumn == endColumn || startRow == endRow || Math.Abs(startColumn - endColumn) == Math.Abs(startRow - endRow);
        }
    }
}
