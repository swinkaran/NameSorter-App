using System;
using System.Collections.Generic;
using NameSorter.ConsoleUI.Input;
using NameSorter.ConsoleUI.Model;
using NameSorter.ConsoleUI.Output;

namespace Swinkaran.NameSorter.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // To check the length of  
            // Command line arguments   
            if (args.Length > 0)
            {
                Run(args[0]);
            }
            else
            {
                Helper.WriteToConsole("File not specified");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        private static void Run(string arg)
        {
            #region Reading
            // Read the file
            // Read a text file line by line.  
            Reader reader = new FileReader(arg);
            PersonList personList = new PersonList(reader);

            IList<Person> persons = personList.ReadAllPeople();
            //foreach (string name in Names)
            //{
            //    personsList.Add(new Person(name);
            //}
            #endregion

            #region Sorting
            Features.Sorting.IPersonSorter<Person> Sorter = new Features.Sorting.PersonSorter(persons);
            IList<Person> sortedList = Sorter.SortByName();
            #endregion

            #region Output
            //Output
            Writer WriteToScreen = new ScreenWriter(sortedList);
            Writer WriteToFile = new FileWriter(sortedList);

            WriteToScreen.display();
            WriteToFile.display();
            #endregion
        }
    }
}
