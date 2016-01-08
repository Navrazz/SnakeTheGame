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
    public partial class FormControls : Form
    {
        public FormControls()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Zamyka okno
        /// </summary>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
