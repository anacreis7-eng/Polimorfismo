using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    internal class Leao : Animal
    {
        public override void emitirSom()
        {
        Console.WriteLine($"O Leão faz !ROAR!");
        }
    }
}
