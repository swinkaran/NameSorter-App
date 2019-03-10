using NameSorter.ConsoleUI.Model;
using Swinkaran.NameSorter.ConsoleUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NameSorter.ConsoleUI.Output
{
    public abstract class Writer
    {
        public readonly IList<Model.Person> People;
        public Writer(IList<Model.Person> _people)
        {
            People = _people;
        }
        public abstract void display();
    }

    public class ScreenWriter : Writer
    {
        public ScreenWriter(IList<Person> _people) : base(_people) { }

        /// <summary>
        /// Dislay the sorted list on console
        /// </summary>
        public override void display()
        {
            Console.WriteLine("Sorted list displayed on screen");
            foreach (Person p in base.People)
            {
                Helper.WriteToConsole(p.GivenName + " " + p.LastName);
            }
        }
    }

    public class FileWriter : Writer
    {
        public FileWriter(IList<Person> _people) : base(_people)
        {
        }

        /// <summary>
        /// Save the output to the file
        /// </summary>
        public override void display()
        {
            ///declare an array of strings, each array element(cincatination of given names and lastname) being a file line
            string[] fileLines = base.People.Select(s => s.GivenName + " " + s.LastName).ToArray();
            File.WriteAllLines("sorted-names-list.txt", fileLines);

            Console.WriteLine("Sorted list saved to the local folder");
        }
    }
}
