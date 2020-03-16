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
                throw InvalidOperationException("There are not enough students to calculate the grade.");
            }

            char letterGrade;

            if (averageGrade >= 90)
            {
                letterGrade = 'A';
            }
            else if (averageGrade >= 80)
            {
                letterGrade = 'B';
            }
            else if (averageGrade >= 70)
            {
                letterGrade = 'C';
            }
            else if (averageGrade >= 60)
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
