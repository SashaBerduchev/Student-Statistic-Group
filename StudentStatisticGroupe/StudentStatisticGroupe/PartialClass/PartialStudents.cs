using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatisticGroupe
{
    public partial class Student
    {
        public override string ToString()
        {
            return $"{Name}, {Sername}, {Phone}, {Groupe}, {Address}";
        }
    }
}
