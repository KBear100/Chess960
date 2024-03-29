﻿using System;
using System.Collections.Generic;

namespace Chess.ChessUtil.ChessPieces
{
    /// <summary>
    /// Represents a queen chess piece.
    /// </summary>
    public class Queen : ChessPiece
    {
        public Queen(ChessPlayer player, ChessPosition position) : base(player, position)
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
                int rowDiff = Math.Abs(i - row);
                if (col - rowDiff >= ChessPosition.MinColumn)
                {
                    moves.Add(new ChessPosition(col - rowDiff, i));
                }
                if (col + rowDiff <= ChessPosition.MaxColumn)
                {
                    moves.Add(new ChessPosition(col + rowDiff, i));
                }
            }

            return moves;
        }
    }
}