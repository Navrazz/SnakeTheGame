using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeTheGame
{
    public partial class FormSettings : Form
    {
        String playerName;
        int difficulty;

        public FormSettings()
        {
            InitializeComponent();
            setComboBoxDifficulty();
        }

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public int Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBoxName.Text = PlayerName;
        }
        /// <summary>
        /// Ustawia poziom trudności wg wybranego z comboBoxDifficulty oraz zamyka okno
        /// </summary>
        private void buttonSaveAndClose_Click(object sender, EventArgs e)
        {   
            if (comboBoxDifficulty.SelectedIndex == 0)
            {
                Difficulty = 10; //poziom łatwy
            }

            if (comboBoxDifficulty.SelectedIndex == 1)
            {
                Difficulty = 20; //poziom normalny
            }

            if (comboBoxDifficulty.SelectedIndex == 2)
            {
                Difficulty = 30; //poziom trudny
            }

            if (comboBoxDifficulty.SelectedIndex == 3)
            {
                Difficulty = 40; //poziom przerażający
            }
            
            PlayerName = textBoxName.Text;
            Close();
        }

        /// <summary>
        /// Ustawia wartości dla ComboBoxDifficulty
        /// </summary>
        private void setComboBoxDifficulty()
        {
            comboBoxDifficulty.Items.Add("Łatwy");
            comboBoxDifficulty.Items.Add("Normalny");
            comboBoxDifficulty.Items.Add("Trudny");
            comboBoxDifficulty.Items.Add("Przerażający");
            comboBoxDifficulty.SelectedItem = "Łatwy" ;
        }
    }
}
