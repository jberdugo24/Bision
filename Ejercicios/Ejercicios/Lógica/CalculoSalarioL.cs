using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Lógica
{
    class CalculoSalarioL
    {
        public int calculoPago(int h)
        {
            int salario = 0;
            int extras = 0;
            if ((h > 0) && (h <=35 ))
            {
                salario = h * 15000;
                return salario;
            }
            else if (h > 35)
            {
                extras = h - 35;
                salario = (15000 * 35) + (extras * 19000);
                return salario;
            }
            else
            {
                return salario;
            }
        }
    }
}
