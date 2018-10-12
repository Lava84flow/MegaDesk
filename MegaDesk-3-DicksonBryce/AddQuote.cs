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
            UserClosing = false;
        }

        private void boxName_Validating(object sender, CancelEventArgs e)
        {
            //work on more condintions for this like excluding numbers and ignoring if window is closing
            if (boxName.Text == String.Empty )
            {
                MessageBox.Show("Please enter a Name");
                boxName.Text = String.Empty;
                boxName.BackColor = Color.DarkOrange;
                boxName.Focus();
            }
            else
            {
                boxWidth.BackColor = System.Drawing.SystemColors.Window;
            }
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


        //private void boxDepth_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsControl(e.KeyChar) == false && Char.IsDigit(e.KeyChar) == false)
        //    {
        //        MessageBox.Show("Please enter a number");
        //        e.Handled = true;
        //        boxDepth.BackColor = Color.DarkOrange;
        //        boxDepth.Focus();
        //    }
        //    else
        //    {
        //        boxDepth.BackColor = System.Drawing.SystemColors.Window;
        //    }
        //}

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
            else if (int.TryParse(boxDepth.Text, out DepthInput) == false && boxDepth.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                boxDepth.Text = String.Empty;
                boxDepth.BackColor = Color.DarkOrange;
                boxDepth.Focus();
            }
            else
            // ask why this works in boxWidth but not boxDepth
            {
                boxDepth.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void boxDepth_Validated(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            UserClosing = true;
            var returnMainMenu = (MainMenu)Tag;
            returnMainMenu.Show();
            Close();
        }

        public bool UserClosing { get; set; }   

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.ApplicationExitCall:
                    break;
                case CloseReason.FormOwnerClosing:
                    break;
                case CloseReason.MdiFormClosing:
                    break;
                case CloseReason.None:
                    break;
                case CloseReason.TaskManagerClosing:
                    break;
                case CloseReason.UserClosing:
                    if (UserClosing)
                    {
                        //what should happen if the user hitted the button?
                        var returnMainMenu = (MainMenu)Tag;
                        returnMainMenu.Show();
                    }
                    else
                    {
                        //what should happen if the user hitted the x in the upper right corner?
                        Application.Exit();
                    }
                    break;
                case CloseReason.WindowsShutDown:
                    break;
                default:
                    break;
            }

            // Set it back to false, just for the case e.Cancel was set to true
            // and the closing was aborted.
            UserClosing = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
