using System;

namespace ChessCore 
{
    class Knight : Piece
    {
        public Knight()
        {
            name = "Nw";
            chessBoard[7, 1] = name;
            chessBoard[7, 6] = name;
            posXfirst = 2;
            posYfirst = 8;
            posXsecond = 7;
            posYsecond = 8;
        }
        
        protected override bool IsRightMove(string move)
        {
            int posX2 = board[move[0].ToString()] + 1;
            int posY2 = board[move[1].ToString()] + 1;

            return (Math.Abs(posXfirst - posX2) == 2 && Math.Abs(posYfirst - posY2) == 1
                   || Math.Abs(posXfirst - posX2) == 1 && Math.Abs(posYfirst - posY2) == 2
                   || Math.Abs(posXsecond - posX2) == 2 && Math.Abs(posYsecond - posY2) == 1
                   || Math.Abs(posXsecond - posX2) == 1 && Math.Abs(posYsecond - posY2) == 2)
                   && chessBoard[posY2 - 1, posX2 - 1] == "  ";
        }
        
        public override void Move(string move)
        {
            if (IsRightMove(move))
            {
                int posX2 = board[move[0].ToString()] + 1;
                int posY2 = board[move[1].ToString()] + 1;
                if(Math.Abs(posXfirst-posX2) == 2 && Math.Abs(posYfirst-posY2) == 1 
                   || Math.Abs(posXfirst-posX2) == 1 && Math.Abs(posYfirst-posY2) == 2)
                {
                    chessBoard[posYfirst-1, posXfirst-1] = "  ";
                    posXfirst = Convert.ToInt32(board[move[0].ToString()]) + 1;
                    posYfirst = Convert.ToInt32(board[move[1].ToString()]) + 1;
                    chessBoard[posYfirst-1, posXfirst-1] = name;
                }
                else if(Math.Abs(posXsecond-posX2) == 2 && Math.Abs(posYsecond-posY2) == 1 
                        || Math.Abs(posXsecond-posX2) == 1 && Math.Abs(posYsecond-posY2) == 2)
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