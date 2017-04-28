using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using QA.Domain.Entities;

namespace QA.Domain.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DropCreateDatabaseIfModelChanges<Context.QAContext>
    {
        public Configuration()
        {
        }

        protected override void Seed(QA.Domain.Context.QAContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var answers = new List<Answer>
            {
                new Answer{ IsCorrect = true, Text = "Q1A1" },
                new Answer{ IsCorrect = false, Text = "Q1A2" },
                new Answer{ IsCorrect = false, Text = "Q1A3" },
                new Answer{ IsCorrect = true, Text = "Q2A1" },
                new Answer{ IsCorrect = false, Text = "Q2A2" },
                new Answer{ IsCorrect = false, Text = "Q2A3" },
                new Answer{ IsCorrect = true, Text = "Q3A1" },
                new Answer{ IsCorrect = false, Text = "Q3A2" },
                new Answer{ IsCorrect = false, Text = "Q3A3" },
                new Answer{ IsCorrect = true, Text = "Q4A1" },
                new Answer{ IsCorrect = false, Text = "Q4A2" },
                new Answer{ IsCorrect = false, Text = "Q4A3" },
                new Answer{ IsCorrect = true, Text = "Q5A1" },
                new Answer{ IsCorrect = false, Text = "Q5A2" },
                new Answer{ IsCorrect = false, Text = "Q5A3" }
            };

            var questions = new List<Question>
            {
                new Question { Text = "Q1" },
                new Question { Text = "Q2" },
                new Question { Text = "Q3" },
                new Question { Text = "Q4" },
                new Question { Text = "Q5" },
            };

            questions.ForEach(s => context.Questions.Add(s));
            context.SaveChanges();
        }
    }
}
