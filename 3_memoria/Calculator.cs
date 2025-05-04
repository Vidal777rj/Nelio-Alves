using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_memoria
{
    public class Calculator
    {
        /*
        //Maneira incorreta e limitante para calculos com n parâmetros
        public static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Soma(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public static int Soma(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }
        */

        public static int Soma(params int[] parametros)
        {
            int soma = 0;
            for (int i = 0; i < parametros.Length; i++)
            {
                soma += parametros[i];
            }
            return soma;
        }

        public static int Subtracao(params int[] parametros)
        {
            int subtracao = 0;
            for (int i = 0; i < parametros.Length; i++)
            {
                subtracao -= parametros[i];
            }
            return subtracao;
        }

        public static void Triplicar( int origin, out int result)
        {
            result = origin * 3;
        }
    }
}