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
    public partial class SelectMonster : Form
    {

        SelectAttack parent;

        public SelectMonster(SelectAttack parentIn = null)
        {
            parent = parentIn;
            InitializeComponent();
            this.FormClosing += parent.g1.anyForm_FormClosing;
        }

        private void SelectMonster_Load(object sender, EventArgs e)
        {
            
            updateForm();
            
        }
        public SelectAttack getParent() { return parent; }
        private void updateForm()
        {
            
            lblPlayerName.Text = parent.g1.getActivePlayer().getPlayerName(); //Gets current players name
            lblPlayerName.ForeColor = parent.g1.getActivePlayer().getColour();
            Button[] buttonArray = new Button[parent.g1.getActivePlayer().getMonsterParty().Length]; // creates button array the size of the current players party
            //Label[] labelArray = new Label[parent.g1.getActivePlayer().getMonsterParty().Length];

            for (int i = 0; i < buttonArray.Length; i++)
            {
                //Finds controls that are called 'cmdMon' + the ID of the current iteration
                //Returns the first match as a button object and puts it in the element of the buttonArray
                buttonArray[i] = this.Controls.Find("cmdMon" + i, true).FirstOrDefault() as Button;
                
                //Sets the .Text property of the buttons to the name of the Monster
                buttonArray[i].Text = parent.g1.getActivePlayer().getMonsterParty()[i].getName();
                
                Color textColour;
                if (parent.g1.getActivePlayer().getMonsterParty()[i].isDead()) textColour = Color.Red;
                else textColour = Color.Green;
                thisButton_Paint(buttonArray[i], "Health: " + Convert.ToString(parent.g1.getActivePlayer().getMonsterParty()[i].getCurrentHealth()) + " HP", textColour);
                
                if (parent.g1.getActivePlayer().getMonsterParty()[i].getCurrentHealth() <= 0)
                    buttonArray[i].Enabled = false;
                //If the monster's health is <= 0, the monster is unable to fight and therefore not selectable.
            }
        }
        
        private void cmdMon0_Click(object sender, EventArgs e)
        {
            parent.g1.getActivePlayer().setActiveMonster(parent.g1.getActivePlayer().getMonsterParty()[0]);
            this.Hide();
        }

        private void cmdMon1_Click(object sender, EventArgs e)
        {
            parent.g1.getActivePlayer().setActiveMonster(parent.g1.getActivePlayer().getMonsterParty()[1]);
            this.Hide();
        }

        private void cmdMon2_Click(object sender, EventArgs e)
        {
            parent.g1.getActivePlayer().setActiveMonster(parent.g1.getActivePlayer().getMonsterParty()[2]);
            this.Hide();
        }

        private void cmdMon3_Click(object sender, EventArgs e)
        {
            parent.g1.getActivePlayer().setActiveMonster(parent.g1.getActivePlayer().getMonsterParty()[3]);
            this.Hide();
        }

        private void cmdMon4_Click(object sender, EventArgs e)
        {
            parent.g1.getActivePlayer().setActiveMonster(parent.g1.getActivePlayer().getMonsterParty()[4]);
            this.Hide();
        }

        private void cmdMon5_Click(object sender, EventArgs e)
        {
            parent.g1.getActivePlayer().setActiveMonster(parent.g1.getActivePlayer().getMonsterParty()[5]);
            this.Hide();
        }


        private void thisButton_Paint(Button buttonIn, string textIn, Color colourIn)
        {
            buttonIn.Paint += (sender, e) => TextRenderer.DrawText(e.Graphics, textIn, this.Font, new Point(80, 45), colourIn);
            //Lambda expression works nicely unless you need to redraw without closing the form, so this form only :(
        }
    }
}
