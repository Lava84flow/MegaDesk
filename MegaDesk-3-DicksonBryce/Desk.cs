using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_DicksonBryce
{
    class Desk
    {
        #region Member Vars

        //Desk Description
        public int Width;
        public int Depth;
        public int Drawers;
        public int Material;
        public int Area;

        #endregion

        //Desk Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

    }
}
