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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuoteForm = new ViewAllQuotes();
            viewAllQuoteForm.Tag = this;
            viewAllQuoteForm.Show(this);
            Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Tag = this;
            searchQuotes.Show(this);
            Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // ask why this will not close the program after coming back here from a different form than the the starting one.
            this.Close();
        }
    }
}
