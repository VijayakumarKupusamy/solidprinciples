using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    /// <summary>
    /// Journal-Hold information about journals and its operations
    /// </summary>
    public class Journal
    {
        private readonly IList<String> entries= new List<String>();

        private static int count=0;

        /// <summary>
        /// AddEntry-Add new journal
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public int AddEntry(String text)
        {
            entries.Add($"{count++}: {text}");
            return count;
        }

        /// <summary>
        /// RemoveEntry-Remove a specified index journal 
        /// </summary>
        /// <param name="index"></param>
        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        // breaks single responsibility principle,So we will move this functionalities to next class
        public void Save(string filename, bool overwrite = false)
        {
            File.WriteAllText(filename, ToString());
        }
    }
}
