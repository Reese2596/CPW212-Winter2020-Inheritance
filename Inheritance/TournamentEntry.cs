using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /*
     * Tournament Entry should store up to 4 games of bowling scores(0, 300).
     * All 4 Games are optional.
     * We need a scratchTotal(sum of all 4 games scores).
     */
    class TournamentEntry
    {
        #region Scores
        public TournamentEntry()
        {
            Games = new List<int>();
        }
        public List<int> Games { get; private set; }

        public void addGame(int score)
        {
            if (score < 0 || score > 300)
            {
                throw new ArgumentOutOfRangeException("Score must be between 0 and 300 inclusive");
            }

            if (Games.Count < 4)
            {
                Games.Add(score);
            }
            else
            {
                throw new ArgumentException("You have exceeded your 4 game limit.");
            }
        }
        #endregion

        #region ScratchTotal
        public int ScratchTotal
        {
            get
            {
                //int total = 0;
                //for(int i = 0; i < Games.Count; i++)
                //{
                //    total += Games[i];
                //}
                //return total;
                return Games.Sum();
            }
        }

        //-----------------------OR------------------------------------------\\

        //public int GetScratchTotal()
        //{
        //    return Games.Sum();
        //}
        #endregion

    }
}
