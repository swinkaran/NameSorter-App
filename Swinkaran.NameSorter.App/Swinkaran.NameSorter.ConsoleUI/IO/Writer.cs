using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NameSorter.ConsoleUI.Model;
using System.IO;
using Swinkaran.NameSorter.ConsoleUI;

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
        //public readonly IList<Model.Person> AllPeople;

        public ScreenWriter(IList<Person> _people) : base(_people)
        {
            //AllPeople = base.People;
        }

        /// <summary>
        /// 
        /// </summary>
        public override void display()
        {
            Console.WriteLine("Sorted list displayed on screen");
            foreach (Person p in base.People)
            {
                Helper.WriteToConsole(string.Join(" ", p.GivenNames) + " " + p.LastName);
            }
        }
    }

    public class FileWriter : Writer
    {
        public FileWriter(IList<Person> _people) : base(_people)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public override void display()
        {
            ///declare an array of strings, each array element(cincatination of given names and lastname) being a file line
            string[] fileLines = base.People.Select(s => string.Join(" ", s.GivenNames) + " " + s.LastName).ToArray();

            File.WriteAllLines("filename.txt", fileLines);

            Console.WriteLine("Sorted list saved to the local folder");
        }

    }

}
