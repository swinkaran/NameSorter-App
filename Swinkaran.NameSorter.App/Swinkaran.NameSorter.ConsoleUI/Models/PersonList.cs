using System;
using System.Collections.Generic;
using System.Text;
using NameSorter.ConsoleUI.Output;
using NameSorter.ConsoleUI.Input;

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
                int NamePartsCount = NameSplits.Length;

                string[] GivenNames = new string[(NamePartsCount - 1) <= 3 ? (NamePartsCount - 1) : 3];
                string LastName = NameSplits[NameSplits.Length - 1];

                Array.Copy(NameSplits, GivenNames, NamePartsCount - 1);

                People.Add(new Person(GivenNames, LastName));
            }

            return People;
        }
    }
}
