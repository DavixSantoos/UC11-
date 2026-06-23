using System.ComponentModel;
using System.Reflection;

namespace UtilitarioApp
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Multiplicar(int a, int b)
        {

            return a * b;
        }

        public int Dividir(double a, double b)
        {
            if (b == 0) return (int)a;

            var resultado = a / b;
            return (int)Math.Ceiling(resultado);
        }
        public int SubtrairPostivoOuZero(int a, int b)
        {
            if (b > a) return 0;
            //return b > a ? 0 : a - b;
            return a - b;
        }
        public double PotenciaDeUmNumero(int @base, int expoente)
        {
            if (expoente == 0) return 1;
            if (expoente == 1) return @base;

            double resultado = @base;
            for (int i = 1; i < expoente; i++)
            {
                resultado *= @base;
            }
            return resultado;
        }


    }
        
    }


