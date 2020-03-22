using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
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

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                
            }
            else
                base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");

            }
            else
                base.CalculateStudentStatistics(name);
        }

        private Exception InvalidOperationException(string v)
        {
            throw new NotImplementedException();
        }

    }
}
