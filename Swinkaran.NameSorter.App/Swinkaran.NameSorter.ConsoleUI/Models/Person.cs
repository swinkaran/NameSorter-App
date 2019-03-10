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
        public string GivenName { get; private set; }

        public Person() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_givenName"></param>
        /// <param name="_lastName"></param>
        public Person(string[] _givenNames, string _lastName)
        {
            //set last name
            LastName = _lastName;
            //set given names
            GivenName = string.Join(" ", _givenNames);
        }
    }
}
