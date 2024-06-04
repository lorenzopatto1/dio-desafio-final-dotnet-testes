using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> historico;

        public Calculadora()
        { }
        public int Somar(int num1, int num2)
        {
            int res = num1 + num2;
            return res;
        }
        public int Subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            return res;
        }
        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            return res;
        }
        public int Dividir(int num1, int num2)
        {
            int res = num1 / num2;
            return res;
        }
        public List<string> Historico()
        {
            return new List<string>();
        }
    }
}
