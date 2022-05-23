using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.ProperDesign
{
    internal class SizeSpecification:ISpecification<Product>
    {
        private readonly Size _size;
        public SizeSpecification(Size size)
        {
            this._size = size;
        }

        public Boolean IsSatisfied(Product product)
        {
            return product.Size==this._size;
        }
    }
}
