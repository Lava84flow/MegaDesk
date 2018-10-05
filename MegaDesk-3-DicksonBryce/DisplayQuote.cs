using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_DicksonBryce
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        // ask how to display to a list view for returning many orders/quotes

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //Use as basis for backing to search or main menu
            //MainMenu returnMainMenu = new MainMenu();
            //returnMainMenu.Tag = this;
            //returnMainMenu.Show(this);
            //Hide();
        }
    }
}
