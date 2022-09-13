using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class Motor : ITasit
    {
        public void Fren()
        {
            Console.WriteLine("Motor Fren yaptı.");
        }

        public void Gazla()
        {
            Console.WriteLine("Motor gazladı.");
        }

        public void SagSinyal()
        {
            Console.WriteLine("Motor sağa sinyal yaptı.");
        }

        public void SolaSinyal()
        {
            Console.WriteLine("Motor sola sinyal yaptı.");
        }
    }
}
