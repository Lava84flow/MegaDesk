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

            //var ReturnMainMenu = (MainMenu)Tag;
            //ReturnMainMenu.Show();
            //this.Close();

            //MainMenu returnMainMenu = new MainMenu();
            //returnMainMenu.Tag = this;
            //returnMainMenu.Show(this);
            //Hide();

            //var mainMenu = (MainMenu)Tag;
            //mainMenu.Show();
            //Close();

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

        private void boxWidth_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(boxWidth.Text, out int WidthInput) == true)
            {
                if(WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("Please enter a width from " + Desk.MINWIDTH + " to " + Desk.MAXWIDTH + " inches");
                    boxWidth.Text = String.Empty;
                    boxWidth.BackColor = Color.DarkOrange;
                    boxWidth.Focus();
                }
                else
                {
                    boxWidth.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            else if(int.TryParse(boxWidth.Text, out WidthInput) == false && boxWidth.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                boxWidth.Text = String.Empty;
                boxWidth.BackColor = Color.DarkOrange;
                boxWidth.Focus();
            }
            else
            {
                boxWidth.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void boxWidth_Validated(object sender, EventArgs e)
        {

        }


        private void boxDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) == false && Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please enter a number");
                e.Handled = true;
                boxDepth.BackColor = Color.DarkOrange;
                boxDepth.Focus();
            }
            else
            {
                boxDepth.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void boxDepth_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(boxDepth.Text, out int DepthInput) == true)
            {
                if (DepthInput < Desk.MINDEPTH || DepthInput > Desk.MAXDEPTH)
                {
                    MessageBox.Show("Please enter a depth from " + Desk.MINDEPTH + " to " + Desk.MAXDEPTH + " inches");
                    boxDepth.Text = String.Empty;
                    boxDepth.BackColor = Color.DarkOrange;
                    boxDepth.Focus();
                }
            }
            //no longer need with handled keypress
            //else if (int.TryParse(boxDepth.Text, out DepthInput) == false && boxDepth.Text.Length != 0)
            //{
            //    MessageBox.Show("Please enter a number");
            //    boxDepth.Text = String.Empty;
            //    boxDepth.BackColor = Color.DarkOrange;
            //    boxDepth.Focus();
            //}
            else
            {
                boxDepth.BackColor = System.Drawing.SystemColors.Window;
            }
            
        }

        private void boxDepth_Validated(object sender, EventArgs e)
        {

        }


    }
}
