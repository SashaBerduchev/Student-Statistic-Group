using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatisticGroupe
{
    public partial class StudentStatistic
    {
        public override string ToString()
        {
            return $"{Data}, {Type}, {NameStudent}, {NameTeacher}, {Point}, {Comment} ";
        }
    }
}
