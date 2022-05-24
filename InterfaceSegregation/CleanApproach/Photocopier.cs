using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.CleanApproach
{
    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
        }

        public void Scan(Document d)
        { 
        }
    }
}
