
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CheckersGame
{

    // Конкретный снимок содержит инфраструктуру для хранения состояния
    // Создателя.

    public class ChessMomento : IMemento<ChessSnapshot>
    {
        private readonly ChessSnapshot snapshot;

        public ChessMomento(ChessSnapshot snapshot )
        {
            this.snapshot = snapshot;
        }

        // Создатель использует этот метод, когда восстанавливает своё
        // состояние.
    
        // Остальные методы используются Опекуном для отображения метаданных.
        public string Name => $"{this.snapshot.Date} " +
            $"Player:{this.snapshot.CurrentPlayer}..have {getCount(this.snapshot.CurrentPlayer)}," +
            $" opposite have : {getCount(this.snapshot.CurrentPlayer==1?2:1)} .";


        public string lol { get; set; }

        private object getCount(int currentPlayer)
        {
            var count = 0;
            for (int i = 0; i < snapshot.Map.GetLength(0); i++)
            {
                for (int j = 0; j < snapshot.Map.GetLength(1); j++)
                {
                    count += snapshot.Map[i, j] == currentPlayer ? 1 : 0;
                }
            }
            return count;
        }

        public DateTime GetDate()
        {
            return this.snapshot.Date;
        }

        public ChessSnapshot GetState()
        {
            return snapshot;
        }

        //public ChessSnapshot IMemento<ChessSnapshot>.GetState()
        //{
        //    return snapshot;
        //}
    }
     

}
