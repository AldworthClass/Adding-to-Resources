using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adding_to_Resources
{
    public partial class FormAddingResources : Form
    {
        Random generator = new Random();
        public FormAddingResources()
        {
            InitializeComponent();
        }

        private void imgMario_Click(object sender, EventArgs e)
        {
            int randNum;
            randNum = generator.Next(5);    // generates a random number from 0-4
            if (randNum == 0) // There is a 1 in 5 chance the number is a 0
            {
                imgMario.Image = Properties.Resources.Mario_Rage;
            }
            else
                imgMario.Image = Properties.Resources.MarioAwake;
        }

        private void imgSleep_Click(object sender, EventArgs e)
        {
            imgMario.Image = Properties.Resources.MarioSleep;
        }

        private void imgMario_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void imgMario_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
