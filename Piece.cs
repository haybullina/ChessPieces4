using System;
using System.Collections.Generic;

namespace ChessPieces_3
{
    class Piece
    {
        protected string name;
        protected int posXfirst;
        protected int posYfirst;
        protected int posXsecond;
        protected int posYsecond;

        protected string[,] chessBoard = new string [8, 8]
        {
            {"  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "},
            {"  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "},
            {"  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "},
            {"  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "},
            {"  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "},
            {"  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "},
            {"  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "},
            {"  ", "  ", "  ", "  ", "  ", "  ", "  ", "  "}
        };

        protected Dictionary<string, int> board = new Dictionary<string, int>()
        {
            ["8"] = 0, ["a"] = 0,
            ["7"] = 1, ["b"] = 1,
            ["6"] = 2, ["c"] = 2,
            ["5"] = 3, ["d"] = 3,
            ["4"] = 4, ["e"] = 4,
            ["3"] = 5, ["f"] = 5,
            ["2"] = 6, ["g"] = 6,
            ["1"] = 7, ["h"] = 7,
        };

        protected virtual bool IsRightMove(string move)
        {
            return true;
        }

        public virtual void Move(string move)
        {
        }

        public void PrintBoard()
        {
            int rows = 8;
            Console.WriteLine("   a   b   c   d   e   f   g   h");
            for (int row = 0; row < 8; ++row)
            {
                Console.Write($"{rows}|");
                for (int col = 0; col < 8; ++col)
                {
                    Console.Write($"{chessBoard[row, col]} |");
                }
                Console.Write($"{rows}");
                rows -= 1;
                Console.WriteLine();
            }
            Console.WriteLine("   a   b   c   d   e   f   g   h");
            Console.WriteLine();
        }
    }
}