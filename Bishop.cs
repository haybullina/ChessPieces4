using System;

namespace ChessPieces_3
{
    class Bishop : Piece
    {
        public Bishop()
        {
            name = "Bw";
            chessBoard[7, 2] = name;
            chessBoard[7, 5] = name;
            posXfirst = 1;
            posYfirst = 8;
            posXsecond = 6;
            posYsecond = 8;
        }
        
        protected override bool IsRightMove(string move)
        {
            int posX2 = board[move[0].ToString()] + 1;
            int posY2 = board[move[1].ToString()] + 1;
            
            return Math.Abs(posXfirst-posX2) == Math.Abs(posYfirst-posY2) 
                   || Math.Abs(posXsecond-posX2) == Math.Abs(posYsecond-posY2);
        }
        
        public override void Move(string move)
        {
            if (IsRightMove(move))
            {
                int posX2 = board[move[0].ToString()] + 1;
                int posY2 = board[move[1].ToString()] + 1;
                if(Math.Abs(posXfirst-posX2) == Math.Abs(posYfirst-posY2))
                {
                    chessBoard[posYfirst-1, posXfirst-1] = "  ";
                    posXfirst = Convert.ToInt32(board[move[0].ToString()]) + 1;
                    posYfirst = Convert.ToInt32(board[move[1].ToString()]) + 1;
                    chessBoard[posYfirst-1, posXfirst-1] = name;
                }
                else if(Math.Abs(posXsecond-posX2) == Math.Abs(posYsecond-posY2))
                {
                    chessBoard[posYsecond-1, posXsecond-1] = "  ";
                    posXsecond = Convert.ToInt32(board[move[0].ToString()]) + 1;
                    posYsecond = Convert.ToInt32(board[move[1].ToString()]) + 1;
                    chessBoard[posYsecond-1, posXsecond-1] = name;
                }
            }
        }
    }
}