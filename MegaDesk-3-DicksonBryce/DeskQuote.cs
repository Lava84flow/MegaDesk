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
        private int material;
        private int materialCost;
        public int QuoteTotal;

        #endregion

        #region Constraints

        private const int PRICE_BASE = 200;
        private const int SIZE_THRESHOLD = 1000; // Square Inches
        private const int PRICE_DRAWER = 50;
        private const int PRICE_PER_AREA = 1; // cost per square inch over SIZE_THRESHOLD
            
        #endregion

        //private int calcMaterial(material)
        //{
        //    var material = material;

        //    switch (material)
        //    {
        //        case Desk.Material.Oak:
        //            materialCost = 200;
        //            break;
        //        case Desk.Material.Laminate:
        //            materialCost = 100;
        //            break;
        //        case Desk.Material.Pine:
        //            materialCost = 50;
        //            break;
        //        case Desk.Material.Rosewood:
        //            materialCost = 300;
        //            break;
        //        case Desk.Material.Veneer:
        //            materialCost = 125;
        //            break;
        //    }
        //    return materialCost;
        //}

        public int calcQuote(int width, int depth, int drawers, Desk.Material material, int rushCost)
        {

        }
    }
}
