using System;
using System.IO;
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
        //private int material;
        //private int materialCost;
        public int QuoteTotal;
        public int RushDays;
        

        #endregion

        #region Constraints

        private const int PRICE_BASE = 200;
        private const int SIZE_THRESHOLD = 1000; // Square Inches
        private const int PRICE_PER_DRAWER = 50;
        private const int PRICE_PER_AREA = 1; // cost per square inch over SIZE_THRESHOLD
        private const int RUSH_THRESHOLD = 2000;

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

        public DeskQuote(string customterName, DateTime quoteDate, int width, int depth, int drawers, Desk.Material material, int rushDays)
        {
            CustomerName = customterName;
            QuoteDate = quoteDate;
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.Drawers = drawers;
            Desk.DeskMaterial = material;
            RushDays = rushDays;

            //calcarea and store
            Desk.Area = Desk.Width * Desk.Depth;

        }

        public int CalcQuote()
        {
            QuoteTotal = PRICE_BASE + AreaCost() + DrawerCost() + (int)Desk.DeskMaterial + RushCost();
            return QuoteTotal;
        }

        private int AreaCost()
        {
            // check if Area is bigger than SIZE_THRESHOLD
            if (Desk.Area > SIZE_THRESHOLD)
            {
                return (Desk.Area - SIZE_THRESHOLD) * PRICE_PER_AREA;
            }
            else
            {
                return 0;
            }
        }

        private int DrawerCost()
        {
            int DrawerCost = Desk.Drawers * PRICE_PER_DRAWER;
            return DrawerCost;
        }

        // grab Rush Prices out of a file and then make multi dimensional array
        #region RushCost Array

        public const string RUSHPRICES = @"../../rushOrderPrices.txt";

        public static void GrabPrices(int Area, int Days)
        {
            //    int[,] rushPrice = arr;

            //    string[] lines = File.ReadAllLines(RUSHPRICES);

            //    string[][] arr = new string[lines.Length][];

            //    for (int days = 0; days < lines.Length; days++)
            //    {
            //        // Split by the space character and remove blank entries
            //        arr[days] = lines[days].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    }
            //    return rushPrice[ , ];
        }

        #endregion

        private int RushCost()
        {
            //int rushDays;
            int rushCost = 0;

            switch (RushDays)
            {
                case 3 :
                    // here's a bug nobody caught... the < and > were backwards... fixed them though
                    if (Desk.Area < SIZE_THRESHOLD)
                    {
                         rushCost = 60;
                    }
                    if (Desk.Area > SIZE_THRESHOLD && Desk.Area < RUSH_THRESHOLD)
                    {
                         rushCost = 70;
                    }
                    if (Desk.Area > RUSH_THRESHOLD)
                    {
                         rushCost = 80;
                    }
                    break;
                case 5 :
                    if (Desk.Area < SIZE_THRESHOLD)
                    {
                         rushCost = 40;
                    }
                    if (Desk.Area > SIZE_THRESHOLD && Desk.Area < RUSH_THRESHOLD)
                    {
                         rushCost = 50;
                    }
                    if (Desk.Area > RUSH_THRESHOLD)
                    {
                         rushCost = 60;
                    }
                    break;
                case 7 :
                    if (Desk.Area < SIZE_THRESHOLD)
                    {
                         rushCost = 30;
                    }
                    if (Desk.Area > SIZE_THRESHOLD && Desk.Area < RUSH_THRESHOLD)
                    {
                         rushCost = 35;
                    }
                    if (Desk.Area > RUSH_THRESHOLD)
                    {
                        rushCost = 40;
                    }
                    break;
            }
            return rushCost;
        }

        public static implicit operator int(DeskQuote v)
        {
            throw new NotImplementedException();
        }
    }
}
