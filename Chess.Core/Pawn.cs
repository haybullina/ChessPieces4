using System;

namespace ChessPieces_3
{
    class Pawn : Piece
    {
        public Pawn()
        {
            name = "Rw";
            for (int i = 0; i < 8; ++i)
            {
                chessBoard[6, i] = name;
            }
        }
        
        protected override bool IsRightMove(string move)
        {
            int posX2 = board[move[0].ToString()] + 1;
            int posY2 = board[move[1].ToString()] + 1;
            
            return posYfirst == 2 && posY2-posYfirst == posYfirst && posXfirst == posX2 && posYfirst != 1 && 
                posY2 != 1 || posY2-posYfirst == 1 && posXfirst == posX2 && posYfirst != 1 && posY2 != 1;
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