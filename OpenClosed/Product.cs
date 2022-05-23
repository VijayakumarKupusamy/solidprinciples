using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{

    internal class Product
    {
        public String Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }

        public Product(string name, Color color, Size size)
        {
            this.Name = name?? throw new ArgumentNullException(nameof(name));
            this.Color = color;
            this.Size = size;
        }
    }
}
