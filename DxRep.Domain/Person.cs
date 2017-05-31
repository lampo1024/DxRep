using System;
using System.Collections.Generic;
using DxRep.Core.Attributes;

namespace DxRep.Domain
{
    public class Person
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public IEnumerable<Phone> Phones { get; private set; }
    }

    public class Phone
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}