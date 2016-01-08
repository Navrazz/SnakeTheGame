using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeTheGame
{
    public partial class FormGameOver : Form
    {
        int score;
        String playerName;
        List<HighScore> topScoreList = new List<HighScore>();

        public FormGameOver()
        {
            InitializeComponent();
            LoadTopScoreList();
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public String PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            labelShowScore.Text = Score.ToString();
            textBoxName.Text = PlayerName;
        }

        /// <summary>
        /// Zapisuje gracza na listę wyników oraz zamyka okno
        /// </summary>
        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            PlayerName = textBoxName.Text;
            WriteTopScoreList();
            Close();
        }

        /// <summary>
        /// Wczytuje listę wyników z pliku do topScoreList
        /// </summary>
        private void LoadTopScoreList()
        {
            using (Stream stream = File.Open(@"TopScoreTable.bin", FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                topScoreList = (List<HighScore>)binaryFormatter.Deserialize(stream);
            }
        }

        /// <summary>
        /// Sortuje listę wyników topScoreList oraz zapisuje do pliku
        /// </summary>
        private void WriteTopScoreList()
        {
            topScoreList.Add(new HighScore() { Score = Score, PlayerName = PlayerName });
            topScoreList = topScoreList.OrderByDescending(s => s.Score).ToList(); //sortowanie po najwyższych wynikach
            using (Stream stream = File.Open(@"TopScoreTable.bin", FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, topScoreList);
            }
        }
    }
}
