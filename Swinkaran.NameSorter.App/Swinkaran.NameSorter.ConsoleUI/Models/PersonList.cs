using NameSorter.ConsoleUI.Input;
using System;
using System.Collections.Generic;

namespace NameSorter.ConsoleUI.Model
{
    public class PersonList
    {
        private readonly IList<Person> People;
        private readonly Reader Reader;
        
        public PersonList(Reader Reader)
        {
            this.Reader = Reader;
            People = new List<Person>();
        }

        public IList<Person> ReadAllPeople()
        {
            string[] Names = Reader.ReadNames();

            foreach (string name in Names)
            {
                string[] NameSplits = name.Trim().Split(' ', StringSplitOptions.None);
                
                string[] GivenNames = new string[(NameSplits.Length - 1) <= 3 ? (NameSplits.Length - 1) : 3];
                string LastName = NameSplits[NameSplits.Length - 1];

                Array.Copy(NameSplits, GivenNames, NameSplits.Length - 1);

                People.Add(new Person(GivenNames, LastName));
            }

            return People;
        }
    }
}
