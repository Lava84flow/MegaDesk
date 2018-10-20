using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_DicksonBryce
{
    public partial class AddQuote : Form
    {
        #region Declarations

        string CustomerName = String.Empty;
        int DeskWidth = 0;
        int DeskDepth = 0;
        int Drawers = 0;
        Desk.Material Material;
        int RushDays = 0;
        int QuoteTotal;
               
        #endregion

        public AddQuote()
        {
            InitializeComponent();

            List<Desk.Material> MaterialList = Enum.GetValues(typeof(Desk.Material)).Cast<Desk.Material>().ToList();
            comboBoxMaterial.DataSource = MaterialList;

            UserClosing = false;
        }

        private void boxName_Validating(object sender, CancelEventArgs e)
        {
            //work on more condintions for this like excluding numbers and ignoring if window is closing
            if (boxName.Text == String.Empty)
            {
                MessageBox.Show("Please enter a Name");
                boxName.Text = String.Empty;
                boxName.BackColor = Color.DarkOrange;
                //boxName.Focus();
            }
            else
            {
                boxName.BackColor = System.Drawing.SystemColors.Window;
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
                else
                {
                    boxDepth.BackColor = System.Drawing.SystemColors.Window;
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

        private void buttonBack_Click(object sender, EventArgs e)
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
                        //what should happen if the user hit the button?
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
            try
            {
                CustomerName = boxName.Text;
                DeskWidth = int.Parse(boxWidth.Text);
                DeskDepth = int.Parse(boxDepth.Text);
                Drawers = int.Parse(comboBoxDrawers.SelectedItem.ToString());
                Material = (Desk.Material)comboBoxMaterial.SelectedValue;

                // Get rush order days base on radio box selections
                if (radioRushNone.Checked)
                {
                    RushDays = 0;
                }
                if (radioRush3.Checked)
                {
                    RushDays = 3;
                }
                if (radioRush5.Checked)
                {
                    RushDays = 5;
                }
                if (radioRush7.Checked)
                {
                    RushDays = 7;
                }

                // create new deskOrder and calcQuote
                DeskQuote NewQuote = new DeskQuote( CustomerName, DateTime.Now, DeskWidth, DeskDepth, Drawers, Material, RushDays );
                QuoteTotal = NewQuote.CalcQuote();

                //build string to quote save to file
                var DeskFileWrite = CustomerName + "," + DateTime.Now + "," + DeskWidth+ "," + DeskDepth + "," + Drawers + "," + Material + "," + RushDays + "," + QuoteTotal;
                string cFile = @"quotes.txt";
                if (!File.Exists(cFile))
                {
                    using (StreamWriter sw = File.CreateText("quotes.txt.")) { }
                }
                using (StreamWriter swa = File.AppendText("quotes.txt.")) { swa.WriteLine(DeskFileWrite); }

                MessageBox.Show("Quote Submitted");
                confirmQuotePanel.Visible = false;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            nameLabel.Text = boxName.Text;
            dateLabel.Text = DateTime.Now.ToShortDateString();
            widthLabel.Text = boxWidth.Text + " inches";
            depthLabel.Text = boxDepth.Text + " inches";
            drawerLabel.Text = comboBoxDrawers.SelectedItem.ToString();
            materialLabel.Text = comboBoxMaterial.SelectedItem.ToString();
            rushLabel.Text = RushDays.ToString() + " days";
            if (radioRushNone.Checked)
            {
                RushDays = 0;
            }
            if (radioRush3.Checked)
            {
                RushDays = 3;
            }
            if (radioRush5.Checked)
            {
                RushDays = 5;
            }
            if (radioRush7.Checked)
            {
                RushDays = 7;
            }
            confirmQuotePanel.Visible = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            confirmQuotePanel.Visible = false;
        }
    }
}
