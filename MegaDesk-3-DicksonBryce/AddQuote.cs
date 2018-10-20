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
using Newtonsoft.Json;

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
            eraseLabelText();
            List<Desk.Material> MaterialList = Enum.GetValues(typeof(Desk.Material)).Cast<Desk.Material>().ToList();
            comboBoxMaterial.DataSource = MaterialList;

            UserClosing = false;
        }

        /*********************Alex's Additions*********************/
        // Get rid of the text inside the error labels
        public void eraseLabelText()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Label && c.Name.Contains("Error")/* && (c.Name != "lblFirstNameError" && c.Name != "lblLastNameError")*/)
                {
                    Label lbl = (Label)c;
                    lbl.Text = string.Empty;
                }
            }
        }

        /********************
        * 1. KeyUp          * 
        ********************/
        // Check to see if the value just intered is an integer
        private void CheckIfChar(object sender, KeyEventArgs e)
        {
            int minValue = 0;
            int maxValue = 0;
            TextBox tb = (TextBox)sender;
            Label errorLabel = findCorrectLabel(tb.Name.Replace("box", ""));

            switch (tb.Name)
            {
                case "boxName":
                    checkIfEmpty(tb, errorLabel);
                    break;
                case "boxWidth":
                    minValue = 24;
                    maxValue = 96;
                    deleteNonInts(tb, errorLabel, minValue, maxValue);
                    break;
                case "boxDepth":
                    minValue = 12;
                    maxValue = 48;
                    deleteNonInts(tb, errorLabel, minValue, maxValue);
                    break;
                default:
                    break;
            }
        }

        // If the textbox is empty display an error message
        public void checkIfEmpty(TextBox tb, Label errorLabel)
        {
            if (tb.Text.Length < 1)
            {
                errorLabel.Text = "This field is required.";
            }
            else
            {
                errorLabel.Text = string.Empty;
            }
        }

        // Delete character values that are not valid integers from the textbox
        public void deleteNonInts(TextBox tb, Label errorLabel, int minValue, int maxValue)
        {
            // Requirement 2
            try
            {
                Convert.ToInt32(tb.Text);
                if (errorLabel.Text != string.Empty)
                {
                    errorLabel.Text = string.Empty;
                }

                // Display error messages if they attempt to enter values less than the minimum or greater than the maximum
                if (Convert.ToInt32(tb.Text) < minValue)
                {
                    errorLabel.Text = "Value cannot be less than " + minValue.ToString();
                }
                else if (Convert.ToInt32(tb.Text) > maxValue)
                {
                    errorLabel.Text = "Value cannot be greater than " + maxValue.ToString();
                }
            }
            catch
            {
                errorLabel.Text = "This field is required.";
                if (tb.Text.Length >= 1)
                {
                    tb.Text = tb.Text.Remove(tb.Text.Length - 1, 1);
                }
                else
                {
                    tb.Text = string.Empty;
                }
            }
        }

        // Get the correct error label for the corresponding textbox
        private Label findCorrectLabel(string senderName)
        {
            Label errorLabel = new Label();
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    if (c.Name == "lbl" + senderName + "Error")
                    {
                        errorLabel = (Label)c;
                    }
                }
            }
            return errorLabel;
        }
        /************************************************************************/



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
                if (WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
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
            else if (int.TryParse(boxWidth.Text, out WidthInput) == false && boxWidth.Text.Length != 0)
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
            if (ValidateRequirements())
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
                    DeskQuote NewQuote = new DeskQuote(CustomerName, DateTime.Now, DeskWidth, DeskDepth, Drawers, Material, RushDays);
                    QuoteTotal = NewQuote.CalcQuote();

                    string json = JsonConvert.SerializeObject(NewQuote);
                    string jsonFile = @"quotes.json";
                    var DeskFileWrite = CustomerName + "," + DateTime.Now + "," + DeskWidth + "," + DeskDepth + "," + Drawers + "," + Material + "," + RushDays + "," + QuoteTotal;

                    if (!File.Exists(jsonFile))
                    {
                        using (StreamWriter sw = File.CreateText(jsonFile)) { }
                    }
                    using (StreamWriter swa = File.AppendText(jsonFile)) { swa.WriteLine(DeskFileWrite); }

                    MessageBox.Show("Quote Submitted");
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not calculate quote. Please fill out all fields", "Error");
                }
            }
            else
            {
                MessageBox.Show("Could not calculate quote. Please fill out all fields", "Error");
            }
        }


        public bool ValidateRequirements()
        {
            bool boxNameValid = false;
            bool boxWidthValid = false;
            bool boxDepthValid = false;
            bool drawersValid = false;
            bool rushOrderDaysValid = false;

            // Check if boxName is valid
            if (boxName.Text != string.Empty)
            {
                boxNameValid = true;
            }

            // Check if boxWidth is valid
            bool widthIsNumeric = int.TryParse(boxWidth.Text, out int n);
            if (boxWidth.Text != string.Empty && Convert.ToInt32(boxWidth.Text) > 24 && Convert.ToInt32(boxWidth.Text) < 96 && widthIsNumeric == true)
            {
                boxWidthValid = true;
            }

            // Check if boxDepth is valid
            bool depthIsNumeric = int.TryParse(boxDepth.Text, out int m);
            if (boxDepth.Text != string.Empty && Convert.ToInt32(boxDepth.Text) > 12 && Convert.ToInt32(boxDepth.Text) < 48 && widthIsNumeric == true)
            {
                boxDepthValid = true;
            }

            // Check if comboBoxDrawers is valid
            string drawerCount;
            try
            {
                drawerCount = comboBoxDrawers.SelectedItem.ToString();
            }
            catch
            {
                drawerCount = "";
            }
            
            if (drawerCount != null && drawerCount != string.Empty)
            {
                drawersValid = true;
            }

            foreach (Control c in pnlRushOrderDays.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.Checked == true)
                    {
                        rushOrderDaysValid = true;
                    }
                }
            }

<<<<<<< HEAD
                MessageBox.Show("Quote Submitted");
                confirmQuotePanel.Visible = false;

=======
            if (boxNameValid == true && boxWidthValid == true && boxDepthValid == true && drawersValid == true && rushOrderDaysValid == true)
            {
                return true;
>>>>>>> collab-Alex
            }
            else
            {
                return false;
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

        private void rushPriceTest_Click(object sender, EventArgs e)
        {
            if (!File.Exists(DeskQuote.RUSHPRICES))
            {
                MessageBox.Show("Can't find Rush Prices");
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
                DeskQuote.GrabPrices(1500, RushDays);
            }


        }
    }
}
