using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.ProperDesign
{
    internal class ColorSpecification:ISpecification<Product>
    {
        private readonly Color _color;
        public ColorSpecification(Color color)
        {
            this._color = color;
        }

        public Boolean IsSatisfied(Product product)
        {
            return product.Color==this._color;
        }
    }
}
