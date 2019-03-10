using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
        /// 
        /// </summary>
        /// <returns></returns>
        public override string[] ReadNames()
        {
            string[] names = File.ReadAllLines(fileName);
            return names;
        }
    }
    
    public abstract class Reader
    {
        public abstract string[] ReadNames();
    }
}


