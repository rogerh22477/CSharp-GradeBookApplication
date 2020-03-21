using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {            

            if (Students.Count < 5)
            {
                throw InvalidOperationException("There needs to be at least 5 students to calculate the grade.");
            }

            char letterGrade;
            var studentCount = (int)Math.Round(Students.Count * 0.2);
            var gradesList = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();

            if (gradesList[studentCount - 1] <= averageGrade)
            {
                letterGrade = 'A';
            }
            else if (gradesList[(studentCount * 2) - 1] <= averageGrade)
            {
                letterGrade = 'B';
            }
            else if (gradesList[(studentCount * 3) - 1] <= averageGrade)
            {
                letterGrade = 'C';
            }
            else if (gradesList[(studentCount * 4) - 1] <= averageGrade)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }
            return letterGrade;
        }
               
        private Exception InvalidOperationException(string v)
        {
            throw new NotImplementedException();
        }

    }
}
