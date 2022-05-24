using System.Text; 

namespace InterfaceSegregation.CleanApproach
{
    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        // compose this out of several modules
        private IPrinter printer;
        private IScanner scanner;

        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            if (printer == null)
            {
                throw new ArgumentNullException(paramName: nameof(printer));
            }
            if (scanner == null)
            {
                throw new ArgumentNullException(paramName: nameof(scanner));
            }
            this.printer = printer;
            this.scanner = scanner;
        }

        public void Print(Document document)
        {
            printer.Print(document);
        }

        public void Scan(Document document)
        {
            scanner.Scan(document);
        }
    }
}

