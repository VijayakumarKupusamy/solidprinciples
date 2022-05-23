using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Rigid design of Product Filter:Product Filter and its specifications are coupled for any changes we have to open
/// this file and make changes.
/// </summary>
namespace OpenClosed
{
    /// <summary>
    /// Product Filter without OpenClosed
    /// </summary>
    internal class ProductFilter
    {
        /// <summary>
        /// Products by its Color
        /// </summary>
        /// <param name="products"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color) 
        { 
            foreach (var product in products)
            {
                if(product.Color == color)
                    yield return product;
            }
        }

        /// <summary>
        /// Products by its Size
        /// </summary>
        /// <param name="products"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products,Size size)
        {
            foreach(var product in products)
            {
                if(size == product.Size)
                    yield return product;
            }
        }

        /// <summary>
        /// Products by its color and size
        /// </summary>
        /// <param name="products"></param>
        /// <param name="size"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products,Size size,Color color)
        {
            foreach(Product product in products)
            {
                if (size == product.Size &&
                    color==product.Color)
                    yield return product;
            }
        }
        //Products and its specfications like grade,Range etc..will goes on
    }
}
