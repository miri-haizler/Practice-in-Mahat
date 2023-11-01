using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_tirgul
{
    internal class Student
    {
        public int StudentId { get; set; }
        public int Grade { get; set; }

        public Student(int StudentId, int Grade)
        {
            this.StudentId = StudentId;
            this.Grade = Grade;
        }

        static int GetCode(int StudentId)
        {
            return (StudentId / 1000) % 100;
        }

    }
}
