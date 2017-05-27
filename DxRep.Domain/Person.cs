using System;
using System.Collections.Generic;
using SqlSugar;

namespace DxRep.Domain
{
    [SugarTable("Person")]
    public class Person
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "Id")]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        [SugarColumn(IsIgnore = true)]
        public IEnumerable<Phone> Phones { get; private set; }
    }

    public class Phone
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}