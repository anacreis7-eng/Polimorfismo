using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    internal class Cobra : Animal
    {
        public override void emitirSom()
        {
            Console.WriteLine($"A Cobra faz !SSSSSSSS!");
        }
    }
}
