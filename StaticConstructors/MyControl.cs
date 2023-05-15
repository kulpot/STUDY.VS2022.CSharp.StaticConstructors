using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticConstructors
{
    class MyControl : Control
    {
        public static Padding DefaultMargin { get; private set; }

        static MyControl()//static constructor
        {
            bool isWinXP = true;
            DefaultMargin = new Padding(isWinXP ? 4 : 6);
        }

        public MyControl()//instance constructor
        {
            Margin = DefaultMargin;
        }
    }
}
