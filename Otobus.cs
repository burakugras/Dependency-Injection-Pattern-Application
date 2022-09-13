using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class Otobus : ITasit
    {
        public void Fren()
        {
            Console.WriteLine("Otobüs Fren yaptı.");
        }

        public void Gazla()
        {
            Console.WriteLine("Otobüs gazladı.");
        }

        public void SagSinyal()
        {
            Console.WriteLine("Otobüs sağa sinyal yaptı.");
        }

        public void SolaSinyal()
        {
            Console.WriteLine("Otobüs sola sinyal yaptı.");
        }
    }
}
