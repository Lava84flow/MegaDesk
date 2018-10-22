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
    public partial class SearchQuotesAssignment : Form
    {

        private const string QUOTEFILE = @"quotes.json";

        public SearchQuotesAssignment()
        {
            InitializeComponent();

            List<Desk.Material> MaterialList = Enum.GetValues(typeof(Desk.Material)).Cast<Desk.Material>().ToList();
            comboBoxMaterial.DataSource = MaterialList;

            UserClosing = false;

        }

        public bool UserClosing { get; set; }

        private void SearchQuotesAssignment_FormClosing(object sender, FormClosingEventArgs e)
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            UserClosing = true;
            var returnMainMenu = (MainMenu)Tag;
            returnMainMenu.Show();
            Close();
        }

        private void comboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // material form drop down lost, then search for and display in list view area
            listViewResults.Clear();
            try
            {
                // grab combo box selection as a string
                string MaterialSelected = comboBoxMaterial.SelectedItem.ToString();

                // find and read CSV file if they exist
                if (!File.Exists(QUOTEFILE))
                {
                    MessageBox.Show("A Quote file was not found in application Root", "Error Reading File");
                }
                else
                {
                    // add column headings to search output List View
                    // Make sure View properity is set to Details
                    listViewResults.Columns.Add( "#", 30, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Name", 170, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Date", 180, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Width", 70, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Depth", 70, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Drawers", 80, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Material", 120, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Days", 70, HorizontalAlignment.Center);
                    listViewResults.Columns.Add("Total", 170, HorizontalAlignment.Center);

                    using(StreamReader sr = new StreamReader(QUOTEFILE))
                    {
                        int quoteCount = 0;
                        while (!sr.EndOfStream)
                        {
                            //string[] fieldvalue = .Split(',');
                            var line = sr.ReadLine();
                            DeskQuote jsonLineDeskQuote = JsonConvert.DeserializeObject<DeskQuote>(line);
                            if (jsonLineDeskQuote.Desk.DeskMaterial.ToString() == MaterialSelected)
                            {
                                quoteCount++;
                                listViewResults.Items.Add(new ListViewItem(new[] 
                                {
                                    quoteCount.ToString(),
                                    jsonLineDeskQuote.CustomerName,
                                    jsonLineDeskQuote.QuoteDate.ToString(),
                                    jsonLineDeskQuote.Desk.Width.ToString(),
                                    jsonLineDeskQuote.Desk.Depth.ToString(),
                                    jsonLineDeskQuote.Desk.Drawers.ToString(),
                                    jsonLineDeskQuote.Desk.DeskMaterial.ToString(),
                                    jsonLineDeskQuote.RushDays.ToString(),
                                    jsonLineDeskQuote.QuoteTotal.ToString()
                                }
                                ));
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with poplulating Results List." + "\n\n" + ex);
            }
        }
    }
}
