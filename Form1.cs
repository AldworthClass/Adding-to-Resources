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
        public FormAddingResources()
        {
            InitializeComponent();
        }

        private void imgMario_Click(object sender, EventArgs e)
        {
            imgMario.Image = Properties.Resources.MarioAwake;
        }

        private void imgSleep_Click(object sender, EventArgs e)
        {
            imgMario.Image = Properties.Resources.MarioSleep;
        }
    }
}
