using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataObject
{
    public struct Student
    {
        public string Name;
        public DateTime DateOfBirth;
        public double GPA;

        public string GetAcademicRank()
        {
            if (GPA >= 8) return "Giỏi";
            else if (GPA >= 6.5) return "Khá";
            else if (GPA >= 5) return "Trung bình";
            else return "Yếu";
        }

        public override string ToString()
        {
            return $"{Name,-20} {DateOfBirth:dd/MM/yyyy}  {GPA,4:F2}  ({GetAcademicRank()})";
        }
    }
}
