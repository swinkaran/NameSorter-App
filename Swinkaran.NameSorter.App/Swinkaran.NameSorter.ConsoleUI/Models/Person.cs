using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NameSorter.ConsoleUI.Model
{
    public class Person
    {
        [Required]
        public string LastName { get; private set; }
        
        [Required]
        public string[] GivenNames { get; private set; }

        public Person() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_givenName"></param>
        /// <param name="_lastName"></param>
        public Person(string[] _givenNames, string _lastName)
        {
            //set given names
            LastName = _lastName;
            GivenNames = _givenNames;
            //set given names
            //string[] NameSplits = _givenName.Trim().Split(' ', StringSplitOptions.None);

            //Array.Copy(NameSplits, GivenNames, NameSplits.Length <= 3 ? NameSplits.Length : 3);
        }
    }
}
