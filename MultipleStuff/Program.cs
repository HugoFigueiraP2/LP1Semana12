using System;

namespace CustomListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância de SuperList e adicionando números
            SuperList superList = new SuperList { 5.6, 2.8, 7.3, 4.1, 9.2 };

            // Usando os três métodos diferentes para obter o mínimo e o máximo
            // Método 1: Usando parâmetros out
            double min1, max1;
            superList.GetMinMax1(out min1, out max1);
            Console.WriteLine($"Método 1 -> Mínimo: {min1}, Máximo: {max1}");

            // Método 2: Usando uma classe/struct específica
            var minMax2 = superList.GetMinMax2();
            Console.WriteLine($"Método 2 -> Mínimo: {minMax2.Min}, Máximo: {minMax2.Max}");

            // Método 3: Usando tuplas de referência
            var (min3, max3) = superList.GetMinMax3();
            Console.WriteLine($"Método 3 -> Mínimo: {min3}, Máximo: {max3}");
        }
    }
}
