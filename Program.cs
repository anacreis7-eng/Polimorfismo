namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometria geo = new Geometria();
            double areaQuadrado = geo.CalcularArea(4.7);
            double areaRetangulo = geo.CalcularArea(6, 7);
            double areaCirculo = geo.CalcularArea(5, true);

            Console.WriteLine($"Área do quadrado:{areaQuadrado} ");
            Console.WriteLine($"Área do retângulo:{areaRetangulo}");
            Console.WriteLine($"Área do circulo:{areaCirculo}");
        }
    }
}
