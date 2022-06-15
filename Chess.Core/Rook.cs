using System;

namespace ChessPieces_3
{
    class Rook : Piece
    {
        public Rook()
        {
            name = "Rw";
            chessBoard[7, 0] = name;
            chessBoard[7, 7] = name;
            posXfirst = 0;
            posYfirst = 8;
            posXsecond = 8;
            posYsecond = 8;
        }
        
        protected override bool IsRightMove(string move)
        {
            int posX2 = board[move[0].ToString()] + 1;
            int posY2 = board[move[1].ToString()] + 1;

            return (posYfirst == posY2 || posXfirst == posX2
                                      || posYsecond == posY2 || posXsecond == posX2)
                   && chessBoard[posY2 - 1, posX2 - 1] == "  ";
        }
        
        public override void Move(string move)
        {
            if (IsRightMove(move))
            {
                int posX2 = board[move[0].ToString()] + 1;
                int posY2 = board[move[1].ToString()] + 1;
                if(posYfirst == posY2 || posXfirst == posX2)
                {
                    chessBoard[posYfirst-1, posXfirst-1] = "  ";
                    posXfirst = Convert.ToInt32(board[move[0].ToString()]) + 1;
                    posYfirst = Convert.ToInt32(board[move[1].ToString()]) + 1;
                    chessBoard[posYfirst-1, posXfirst-1] = name;
                }
                else if(posYsecond == posY2 || posXsecond == posX2)
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