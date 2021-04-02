using System;

namespace Cristian_Brandan
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso;
            float altura;

            Console.WriteLine("Ingrese su peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su altura: ");
            altura = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Bajo peso");
            }
            else
            {
                if (imc < 24.9)
                {
                    Console.WriteLine("Saludable");
                }
                else
                {
                    if (imc < 29.9)
                    {
                        Console.WriteLine("Sobre Peso");
                    }
                    else
                    {
                        Console.WriteLine("Obesidad");
                    }
                }
            }
        }
    }
}