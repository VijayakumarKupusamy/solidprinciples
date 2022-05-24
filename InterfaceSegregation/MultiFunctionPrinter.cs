using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    /// <summary>
    /// 
    /// </summary>
    public class MultiFunctionPrinter:IMachine
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        public void Print(Document d)
        {
            //
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        public void Fax(Document d)
        {
            //
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        public void Scan(Document d)
        {
            //
        }
    }
}
