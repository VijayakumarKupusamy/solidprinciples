using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    internal class Persistence
    {
        public void SaveToFile(Journal journal,String fileName,Boolean overWrite = false)
        {
            if (overWrite || !File.Exists(fileName))
                File.WriteAllText(fileName, journal.ToString());
        }
    }
}
