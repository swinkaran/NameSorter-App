using NameSorter.ConsoleUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Swinkaran.NameSorter.Features.Sorting
{
    public class PersonSorter : IPersonSorter<Person>
    {
        public readonly IList<Person> PersonsList;

        public PersonSorter(IList<Person> _people)
        {
            PersonsList = _people;
        }

        /// <summary>
        /// Default sorting
        /// </summary>
        /// <returns></returns>
        public IList<Person> Sort()
        {
            //By default 
            return PersonsList;
        }

        /// <summary>
        /// Sorting the Person list by Given names and lastname
        /// </summary>
        /// <returns></returns>
        public IList<Person> SortByName()
        {
            IList<Person> SortedPersonsList = PersonsList.OrderBy(p=> p.LastName)
                .ThenBy(p => p.GivenName)
                .ToList();
            return SortedPersonsList;
        }
    }

    public interface ISorter<T>
    {
        IList<T> Sort();
    }

    public interface IPersonSorter<T> : ISorter<T>
    {
        IList<T> SortByName();
    }
}
