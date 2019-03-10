using System;
using System.IO;

namespace NameSorter.ConsoleUI.Input
{
    public class FileReader : Reader
    {
        private readonly string fileName;

        public FileReader(string _fileName)
        {
            fileName = _fileName;
        }
        
        /// <summary>
        /// Read all the lines from the file
        /// </summary>
        /// <returns></returns>
        public override string[] ReadNames()
        {
            try
            {
                string[] names = File.ReadAllLines(fileName);
                return names;
            }
            catch (Exception e)
            {
                throw new FileNotFoundException();
            }
        }
    }
    
    public abstract class Reader
    {
        public abstract string[] ReadNames();
    }
}


