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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ask why this might be being stupid and giving me a stack overflow, a loop or still running program after closing window
            /*
            ////var ReturnMainMenu = (MainMenu)Tag;
            ////ReturnMainMenu.Show();
            ////this.Close();

            ////MainMenu returnMainMenu = new MainMenu();
            ////returnMainMenu.Tag = this;
            ////returnMainMenu.Show(this);
            ////Hide();
            */
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MainMenu returnMainMenu = new MainMenu();
            returnMainMenu.Tag = this;
            returnMainMenu.Show(this);
            Hide();
        }

    }
}
