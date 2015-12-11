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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectAttack selectAttackForm = new SelectAttack();
            selectAttackForm.ShowDialog();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
