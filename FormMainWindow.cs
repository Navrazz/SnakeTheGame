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
    public partial class FormMainWindow : Form
    {
         //Ustawienia
        const int tileWidth = 15;  //podział pola gry na kratki o bokach 15x15
        const int tileHeight = 15;
        int direction = 1; // Góra = 1, Dół = 2, Prawo = 3, Lewo = 4;
        bool gameover = false;
        
        int score = 0;
        String playerName = "Gracz";
        int difficulty = 10;

        SnakeBody food;
        List<SnakeBody> snake = new List<SnakeBody>(); // lista przechowująca węża 
        List<HighScore> topScoreList = new List<HighScore>(); // lista top score

        public FormMainWindow()
        {
            InitializeComponent();
            LoadTopScoreList();
            timerGame.Tick += Movement; //sprawdzanie co tick czy wykonany został ruch
            timerGame.Start();
            GameStart();
        }

        private void pictureBoxGameBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics; //rysowanie w pictureBoxGameBoard
            for (int i = 0; i < snake.Count; i++)
            {
                Brush brush = Brushes.Black;
                //ustawianie innego koloru dla głowy węża
                if (i == 0) 
                {
                    brush = Brushes.Orange;
                }
                graphics.FillRectangle(brush, new Rectangle(snake[i].X * tileWidth, snake[i].Y * tileHeight, tileWidth, tileHeight));
            }
            graphics.FillEllipse(Brushes.Red, new Rectangle(food.X * tileWidth, food.Y * tileHeight, tileWidth, tileHeight));
        }

        /// <summary>
        /// Start Gry
        /// </summary>
        private void GameStart()
        {
            timerGame.Interval = 1000 / difficulty;
            SettingsClear();
            labelPressEnter.Visible = false;
            SnakeBody head = new SnakeBody(); //tworzenie pierwszej części węża - głowy, którą poruszamy się na początku
            head.X = 10; // X oraz Y definiują startową pozycję głowy węża
            head.Y = 10;
            snake.Add(head);
            FoodPlace();
        }

        /// <summary>
        /// Generuje nowe jedzenie
        /// </summary>
        private void FoodPlace()
        {
            food = new SnakeBody();
            Random generator = new Random();
            int maxHeight = pictureBoxGameBoard.Size.Height / tileHeight; // dostosowanie generowania jedzenia dla węża do podziału pola gry na kratki
            int maxWidth = pictureBoxGameBoard.Size.Width / tileWidth;
            food.X = generator.Next(0, maxHeight);
            food.Y = generator.Next(0, maxWidth);
        }

        /// <summary>
        /// Czyszczenie wyniku i listy z wężem przed startem gry
        /// </summary>
        private void SettingsClear()
        {
            gameover = false;
            score = 0;
            labelScoreShow.Text = "0";
            direction = 0;
            snake.Clear();
        }
        /// <summary>
        /// Wczytywanie wyników z pliku do tablicy z najlepszymi wynikami (potrzebne do wyświetlenia najlepszego wyniku)
        /// </summary>
        private void LoadTopScoreList()
        {
            using (Stream stream = File.Open(@"TopScoreTable.bin", FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                topScoreList = (List<HighScore>)bformatter.Deserialize(stream);
            }
        }
  
        #region Logika
        /// <summary>
        /// Ruch węża
        /// </summary>
        private void Movement(object sender, EventArgs e)
        {
            LoadTopScoreList();
            labelTopScoreShow.Text = topScoreList[0].PlayerName + " - " + topScoreList[0].Score.ToString();
            if (!gameover)
            {
                //reakcja na przyciski
                if (Input.Pressed(Keys.Up) || Input.Pressed(Keys.W))
                {
                    if (snake.Count < 2 || snake[0].Y == snake[1].Y)
                        direction = 1;  //góra
                }

                else if (Input.Pressed(Keys.Down) || Input.Pressed(Keys.S))
                {
                    if (snake.Count < 2 || snake[0].Y == snake[1].Y)
                        direction = 2; //dół
                }

                else if (Input.Pressed(Keys.Right) || Input.Pressed(Keys.D))
                {
                    if (snake.Count < 2 || snake[0].X == snake[1].X)
                        direction = 3; //prawo
                }

                else if (Input.Pressed(Keys.Left) || Input.Pressed(Keys.A))
                {
                    if (snake.Count < 2 || snake[0].X == snake[1].X)
                        direction = 4; //lewo
                }

                else if (Input.Pressed(Keys.Escape)) // resetowanie gry po wciśnięciu ESC
                {
                    GameStart();
                }
                UpdateSnake();
            }
            else
            {
                // GAME OVER
                labelPressEnter.Visible = true;
                if (Input.Pressed(Keys.Enter))
                {
                    timerGame.Stop();
                    FormGameOver gameOver = new FormGameOver();
                    gameOver.Score = score;
                    gameOver.PlayerName = playerName;
                    gameOver.Show();
                    timerGame.Start();
                    GameStart();
                }
            }
            pictureBoxGameBoard.Invalidate();
        }

        /// <summary>
        /// Aktualizacja kierunku ruchu oraz sprawdzanie kolizji
        /// </summary>
        private void UpdateSnake()
        {
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                // poruszanie się głowy węża (cała logika kolizji zawarta jest w głowie)
                if (i == 0)
                {
                    switch (direction)
                    {
                        case 1:
                            snake[i].Y--;
                            break;
                        case 2:
                            snake[i].Y++;
                            break;
                        case 3:
                            snake[i].X++;
                            break;
                        case 4:
                            snake[i].X--;
                            break;
                    }

                    // kolizja z obramówką pola gry
                    int maxXPosition = pictureBoxGameBoard.Size.Height / tileHeight;
                    int maxYPosition = pictureBoxGameBoard.Size.Width / tileWidth;
                    if (snake[i].X < 0 || snake[i].X >= maxXPosition || snake[i].Y < 0 || snake[i].Y >= maxYPosition)
                    {
                        gameover = true;
                    }

                    // kolizja z ciałem
                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].X == snake[j].X && snake[i].Y == snake[j].Y)
                        {
                            gameover = true;
                        }
                    }

                    //kolizja z jedzeniem
                    if (snake[i].X == food.X && snake[i].Y == food.Y)
                    {
                        SnakeBody part = new SnakeBody();
                        part.X = snake[snake.Count - 1].X;
                        part.Y = snake[snake.Count - 1].Y;
                        snake.Add(part);
                        FoodPlace();
                        score += difficulty;
                        labelScoreShow.Text = score.ToString();
                    }
                }
                // poruszanie się reszty ciała (ciało porusza się za głową, sterowaną przez gracza)
                else
                {
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
            }
        }
        #endregion

        #region Obsługa przycisków menu

        private void toolStripMenuItemNewGame_Click(object sender, EventArgs e)
        {
            FormSettings settingsWindow = new FormSettings();
            settingsWindow.PlayerName = playerName;
            settingsWindow.ShowDialog();
            playerName = settingsWindow.PlayerName;
            difficulty = settingsWindow.Difficulty;
            GameStart();
        }

        private void toolStripMenuItemRestart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Restart gry");
            GameStart();
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItemControls_Click(object sender, EventArgs e)
        {
            FormControls controls = new FormControls();
            controls.Show();
        }

        private void toolStripMenuItemTopTen_Click(object sender, EventArgs e)
        {
            FormTopScores topScores = new FormTopScores();
            topScores.Show();
        }
        #endregion

        /// <summary>
        /// Przycisk wciśnięty
        /// </summary>
        private void FormMainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        /// <summary>
        /// Przycisk niewsiśnięty
        /// </summary>
        private void FormMainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
    }
}

