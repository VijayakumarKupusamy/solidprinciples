using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    interface IMachine
    {
        void Print(Document document);
        void Fax(Document document);
        void Scan(Document document);
    }
}
