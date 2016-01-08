using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SnakeTheGame
{
    public partial class FormTopScores : Form
    {
        public FormTopScores()
        {
            InitializeComponent();
            LoadTopScoreList();
        }

        List<HighScore> topScoreList = new List<HighScore>();
        
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Wczytuje listę wyników z pliku do topScoreList
        /// </summary>
        private void LoadTopScoreList()
        {
            using (Stream stream = File.Open(@"TopScoreTable.bin", FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                topScoreList = (List<HighScore>)bformatter.Deserialize(stream);
            }
        }

        /// <summary>
        /// Wypisuje pięciu najlepszych graczy
        /// </summary>
        private void TopScores_Load(object sender, EventArgs e)
        {
            //plik z zapisem najlepszych wyników nigdy nie będzie pusty i zawsze będzie miał co najmniej 5 wpisów (plik zawiera już domyślną listę),
            //więc nigdy nie wyjdziemy poza zakres tablicy
            labelFirstPlace.Text = topScoreList[0].PlayerName + " - " + topScoreList[0].Score;
            labelSecondPlace.Text = topScoreList[1].PlayerName + " - " + topScoreList[1].Score;
            labelThirdPlace.Text = topScoreList[2].PlayerName + " - " + topScoreList[2].Score;
            labelFourthPlace.Text = topScoreList[3].PlayerName + " - " + topScoreList[3].Score;
            labelFifthPlace.Text = topScoreList[4].PlayerName + " - " + topScoreList[4].Score;
        }
    }
}
