using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_tirgul
{
    internal class GradesFile
    {

        //  GradesFile[] gradesFile = new GradesFile[100];
        Queue1<Student>[] arr { get; set; } = new Queue1<Student>[100];

        public GradesFile(Queue1<Student>[] arr)
        {
            this.arr = arr;
        }


    }
}
