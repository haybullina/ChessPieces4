using System;

namespace ChessPieces_3
{
    class King : Piece
    {
        public King()
        {
            name = "Kw";
            chessBoard[7, 3] = name;
            posXfirst = 4;
            posYfirst = 8;
        }
        
        protected override bool IsRightMove(string move)
        {
            int posX2 = board[move[0].ToString()] + 1;
            int posY2 = board[move[1].ToString()] + 1;

            return Math.Abs(posXfirst-posX2) == 1 && posYfirst == posY2 
                   || Math.Abs(posXfirst-posX2) == 1 && Math.Abs(posYfirst-posY2) == 1
                   || Math.Abs(posYfirst-posY2) == 1 && posXfirst == posX2 ;
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