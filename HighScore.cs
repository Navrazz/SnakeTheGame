using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTheGame
{
    /// <summary>
    /// Klasa której obiekty to gracze zapisywani na liście najlepszych
    /// </summary>
    [Serializable]
    class HighScore
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }
    }
}
