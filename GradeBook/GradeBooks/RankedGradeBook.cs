using System;
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
            //public char letterGrade = " ";

            if (Students.Count < 5)
            {
                throw InvalidOperationException("There are not enough students.");
            }

            //switch (averageGrade)
            //{
            //    case 1(averageGrade > 90):
            //        return GetLetterGrade = "A";
            //    default:
            //        break;
            //}
            return base.GetLetterGrade(averageGrade);
            //return averageGrade = "F";

        }

        private Exception InvalidOperationException(string v)
        {
            throw new NotImplementedException();
        }
    }
}
