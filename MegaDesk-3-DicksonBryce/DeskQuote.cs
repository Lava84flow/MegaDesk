using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_DicksonBryce
{
    class DeskQuote
    {
        #region Member Vars
       
        //Quote Description
        private string CustomerName;
        private DateTime QuoteDate;
        private Desk Desk = new Desk();

        #endregion

        #region Constraints

        private const int PRICE_BASE = 200;
        private const int PRICE_DRAWER = 50;

        #endregion

        public DeskQuote(int width, int depth, int drawers, string materials, int rushDays)
        {

        }
    }
}
