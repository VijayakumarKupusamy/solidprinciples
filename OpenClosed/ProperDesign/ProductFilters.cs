using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.ProperDesign
{
    /// <summary>
    /// Proper Filter
    /// </summary>
    internal class ProductFilter:IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products,ISpecification<Product> specification)
        {
            foreach (Product product in products)
            {
                if(specification.IsSatisfied(product))
                    yield return product;
            }
        }
    }
}
