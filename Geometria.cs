using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    internal class Geometria
    {
        public double CalcularArea(double lado)
        {
            return lado * lado;
        }
        public double CalcularArea(double Base, double altura)
        {
            return Base * altura;
        }
        public double CalcularArea(double raio, bool iscirculo)
        {
            return Math.PI * raio * raio;
        }

    }
}
