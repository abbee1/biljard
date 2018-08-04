using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biljard.Models
{
    public class Biljard
    {
        public Guid Id { get; set; }

        public string Winner { get; set; }

        public int LosserBallsLeft { get; set; }

        public string WinnerColor { get; set; }

        public DateTime Date { get; set; }

        public string TimeOFDay { get; set; }

        public string WhoStarted { get; set; }

        public string WhoPuttedFirtBall { get; set; }

        public string WonBecauseEight { get; set; }

        public string WonBecauseEightAndWhite { get; set; }
    }
}