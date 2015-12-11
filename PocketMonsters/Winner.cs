using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PocketMonsters
{
    public partial class Winner : Form
    {
        SelectAttack parent;
        public Winner(SelectAttack parentIn)
        {
            parent = parentIn;
            InitializeComponent();
        }

        private void Winner_Load(object sender, EventArgs e)
        {
            lblWinnerName.Text = parent.g1.getWinner().getPlayerName();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
