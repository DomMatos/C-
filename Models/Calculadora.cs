using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calc.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y} ");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y} ");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y} ");
        }
        public void Podencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} * {y} = {pot}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} º = {Math.Round(seno, 4)}");
        }
        public void Conseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double conseno = Math.Cos(radiano);
            Console.WriteLine($"conseno de {angulo}º = {Math.Round(conseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} º = {Math.Round(tangente, 4)}");
        }

    }
}