using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class Square : Rectangle
    {
        //public new int Height
        //{
        //    set { base.Height =base.Width= value; }
        //}
        //public new int Width { 
        //    set { base.Width = base.Height = value; }
        //}

        public override int Height
        {
            set { base.Height = base.Width = value; }
        }
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }
    }
}
