using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDelExt;

namespace StudentDelExt
{
    static class StudentDelExt
    {
        public static string GetFulName(this Student student)
        {
            return student.LastName + " " + student.FirstName;
        }
    }
}
