using System;
namespace Lecture_3_Homework.Common
{
    internal class Person<TKey> : EntityBase<TKey>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

