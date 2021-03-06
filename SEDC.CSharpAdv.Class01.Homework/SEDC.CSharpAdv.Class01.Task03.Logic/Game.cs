using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Class01.Task03.Logic
{
    public class Game
    {
        private int GamesPlayed { get; set; }

        protected bool IsActive { get; set; }
        public Game()
        {
            GamesPlayed = 0;
            IsActive = false;
        }

        protected void IncreaseGamePlayed()
        {
            GamesPlayed += 1;
        }

        protected int GetGamesPlayed()
        {
            return GamesPlayed;
        }
    }
}
