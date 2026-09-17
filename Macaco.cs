using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    internal class Macaco : Animal
    {
        public override void emitirSom()
        {
            Console.WriteLine($"O Macaco faz !UGH UGH UGH HAA HAA!");
        }
    }
}
