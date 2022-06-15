using System;

namespace ChessPieces_3
{
    class Queen : Piece
    {
        public Queen()
        {
            name = "Qw";
            chessBoard[7, 4] = name;
            posXfirst = 5;
            posYfirst = 8;
        }
        
        protected override bool IsRightMove(string move)
        {
            int posX2 = board[move[0].ToString()] + 1;
            int posY2 = board[move[1].ToString()] + 1;

            return (Math.Abs(posXfirst - posX2) == Math.Abs(posYfirst - posY2) || posYfirst == posY2 || posXfirst == posX2)
                   && chessBoard[posY2 - 1, posX2 - 1] == "  ";
        }

        public override void Move(string move)
        {
            if (IsRightMove(move))
            {
                chessBoard[posYfirst-1, posXfirst-1] = "  ";
                posXfirst = Convert.ToInt32(board[move[0].ToString()]) + 1;
                posYfirst = Convert.ToInt32(board[move[1].ToString()]) + 1;
                chessBoard[posYfirst-1, posXfirst-1] = name;
            }
        }
    }
}