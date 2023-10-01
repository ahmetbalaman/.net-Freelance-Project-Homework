using System;
namespace Lecture_3_Homework.Common
{
    internal class EntityBase<TKey>
    {
        public TKey Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }

    }
}

