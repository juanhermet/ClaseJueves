using System;

namespace ProyectoEnLaNube
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, talla, IMC;

            do
            {
                Console.WriteLine("ingrese su peso:");
                string valor = Console.ReadLine();
                if (valor == "")
                {
                    peso = 0;
                }
                else
                {
                    peso = double.Parse(valor);
                }
            } while (peso <= 0);

            do
            {
                Console.WriteLine("ingrese su peso:");
                string valor = Console.ReadLine();
                if (valor == "")
                {
                    talla = 0;
                }
                else
                {
                    talla = double.Parse(valor);
                }
            } while (talla <= 0);

            IMC = peso / talla * talla;

            switch (IMC)
            {
                case < 18.5:
                    Console.WriteLine("Paciente con bajo peso.");
                    break;
                case < 24.5:
                    Console.WriteLine("Paciente con peso normal.");
                    break;
                case < 29.5:
                    Console.WriteLine("Paciente con sobrepeso.");
                    break;
                default:
                    Console.WriteLine("Paciente obeso.");
                    break;
            }
        }
    }
}
