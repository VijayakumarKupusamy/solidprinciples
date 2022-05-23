using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.ProperDesign
{
    /// <summary>
    /// Specifications such as Matched,Satisfied,Equals,Not Equals ets
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface ISpecification<T>
        where T : class
    {
        public Boolean IsSatisfied(T t);
    }
}
