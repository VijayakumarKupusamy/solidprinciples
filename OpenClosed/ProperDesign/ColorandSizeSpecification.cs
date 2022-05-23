using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.ProperDesign
{
    internal class ColorandSizeSpecification:ISpecification<Product>
    {
        private readonly Color _color;
        private readonly Size _size;
        public ColorandSizeSpecification(Color color,Size size)
        {
            this._color = color;
            this._size = size;
        }

        public Boolean IsSatisfied(Product product)
        {
            return product.Size == _size 
                && product.Color == _color;
        }
    }
}
