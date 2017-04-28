using System;
using System.Collections.Generic;

namespace QA.Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public virtual List<Answer> Answers { get; set; }
    }
}
