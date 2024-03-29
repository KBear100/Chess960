﻿using System.Collections.Generic;

namespace Chess.ChessUtil.ChessPieces
{
    /// <summary>
    /// Represents a rook chess piece.
    /// </summary>
    public class Rook : ChessPiece
    {
        public Rook(ChessPlayer player, ChessPosition position) : base(player, position)
        {
        }

        public override List<ChessPosition> GetMoves()
        {
            int col = Position.Column;
            int row = Position.Row;
            List<ChessPosition> moves = new List<ChessPosition>();

            for (int i = ChessPosition.MinColumn; i <= ChessPosition.MaxColumn; i++)
            {
                if (i == col)
                {
                    continue;
                }

                moves.Add(new ChessPosition(i, row));
            }

            for (int i = ChessPosition.MinRow; i <= ChessPosition.MaxRow; i++)
            {
                if (i == row)
                {
                    continue;
                }

                moves.Add(new ChessPosition(col, i));
            }

            return moves;
        }
    }
}