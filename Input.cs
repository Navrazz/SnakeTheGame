using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace SnakeTheGame
{
    /// <summary>
    /// Klasa pozwalająca stwierdzić czy, i jaki przycisk został wciśnięty
    /// </summary>
    class Input
    {
        private static Hashtable KeyList = new Hashtable();

        public static void ChangeState(Keys key, bool state)
        {
            KeyList[key] = state;
        }

        public static bool Pressed(Keys key)
        {
            if (KeyList[key] == null)
            {
                return false;
            }
            return (bool)KeyList[key];
        }
    }
}
