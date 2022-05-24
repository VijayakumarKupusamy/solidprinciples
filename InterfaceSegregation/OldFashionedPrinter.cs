using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class OldFashionedPrinter : IMachine
    {
        public void Fax(Document document)
        {
            throw new NotImplementedException();
        }

        public void Print(Document document)
        {
            //PrintDocument
        }

        public void Scan(Document document)
        {
            throw new NotImplementedException();
        }
    }
}
