using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class Araba : ITasit
    {
        public void Fren()
        {
            Console.WriteLine("Araba Fren yaptı.");
        }

        public void Gazla()
        {
            Console.WriteLine("Araba gazladı.");
        }

        public void SagSinyal()
        {
            Console.WriteLine("Araba sağa sinyal yaptı.");
        }

        public void SolaSinyal()
        {
            Console.WriteLine("Araba sola sinyal yaptı.");
        }
    }
}
