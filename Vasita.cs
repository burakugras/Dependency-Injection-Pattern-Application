using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    class Vasita
    {
        ITasit _tasit;
        public Vasita(ITasit tasit)
        {
            _tasit = tasit;
        }
        public void Kullan()
        {
            _tasit.Gazla();
            _tasit.Fren();
            _tasit.SagSinyal();
            _tasit.SolaSinyal();
        }
    }
}
