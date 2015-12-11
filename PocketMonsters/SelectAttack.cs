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
    public partial class SelectAttack : Form
    {
        public Game g1 = new Game();

        public SelectAttack()
        {
            InitializeComponent();
            this.FormClosing += g1.anyForm_FormClosing;
        }

        private void SelectAttack_Load(object sender, EventArgs e)
        {
            while (g1.getActivePlayer().getActiveMonster() == null)
            {
                this.Hide();
                SelectMonster selectMonsterForm = new SelectMonster(this);
                selectMonsterForm.ShowDialog();
                g1.endTurn();
            }

            if (g1.getActivePlayer().getActiveMonster() != null)
            {
                updateForm();
                this.Show();
            }
        }
        private void updateForm()
        {
            Monster activeMon = g1.getActivePlayer().getActiveMonster();
            Monster oppMon = g1.getOpposingPlayer().getActiveMonster();

            lblPlayerName.Text = g1.getActivePlayer().getPlayerName();
            lblPlayerName.ForeColor = g1.getActivePlayer().getColour();
            lblActiveMon.Text = activeMon.getName();
            lblActiveMonHealth.Text = "Health: " + Convert.ToString(activeMon.getCurrentHealth())
                + "/" + Convert.ToString(activeMon.getMaxHealth()) + " HP";

            lblOpponentName.Text = g1.getOpposingPlayer().getPlayerName();
            lblOpponentName.ForeColor = g1.getOpposingPlayer().getColour();
            lblOppActiveMon.Text = oppMon.getName();
            lblOppMonHealth.Text = "Health: " + Convert.ToString(oppMon.getCurrentHealth())
                + "/" + Convert.ToString(oppMon.getMaxHealth()) + " HP";

            Button[] buttonArray = new Button[activeMon.getMovelist().Length];
            Label[] labelArray = new Label[activeMon.getMovelist().Length];

            for (int i = 0; i < buttonArray.Length; i++)
            {
                Move currentMove = activeMon.getMovelist()[i];

                buttonArray[i] = this.Controls.Find("cmdAttack" + i, true).FirstOrDefault() as Button;
                buttonArray[i].Text = currentMove.getName();

                labelArray[i] = this.Controls.Find("lblMovePower" + i, true).FirstOrDefault() as Label;
                labelArray[i].ForeColor = Color.Purple;
                labelArray[i].Text = "Power: " + Convert.ToString(currentMove.getPower());

                
            }
            
        }
        //protected override void OnVisibleChanged(EventArgs e)
        //{
        //    base.OnVisibleChanged(e);
        //    this.Visible = false;
        //}

        private void checkIfDefeated()
        {
            if (g1.getActivePlayer().getActiveMonster().isDead())
            {
                this.Hide();
                if (g1.getActivePlayer().isDefeated())
                {
                    this.Hide();
                    g1.setWinner(g1.getOpposingPlayer());
                    Winner winnerForm = new Winner(this);
                    winnerForm.Show();
                }
                else
                {
                    SelectMonster selectMonsterForm = new SelectMonster(this);
                    selectMonsterForm.ShowDialog();
                    g1.endTurn();
                    updateForm();
                    this.Show();
                }
            }
        }
        private void endAttack()
        {
            g1.endTurn();
            updateForm();
            checkIfDefeated();
        }
        private void cmdAttack0_Click(object sender, EventArgs e)
        {
            g1.getOpposingPlayer().getActiveMonster().takeDamage(g1.getActivePlayer().getActiveMonster().getMovelist()[0].getPower());
            endAttack();            
        }

        private void cmdAttack1_Click(object sender, EventArgs e)
        {
            g1.getOpposingPlayer().getActiveMonster().takeDamage(g1.getActivePlayer().getActiveMonster().getMovelist()[1].getPower());
            endAttack();
        }

        private void cmdAttack2_Click(object sender, EventArgs e)
        {
            g1.getOpposingPlayer().getActiveMonster().takeDamage(g1.getActivePlayer().getActiveMonster().getMovelist()[2].getPower());
            endAttack();
        }

        private void cmdAttack3_Click(object sender, EventArgs e)
        {
            g1.getOpposingPlayer().getActiveMonster().takeDamage(g1.getActivePlayer().getActiveMonster().getMovelist()[3].getPower());
            endAttack();
        }
    }
}