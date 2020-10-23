using System;

namespace Aula_3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 10;       
            int num=0;          
            char letra='F';
            float valor = 5.3f;
            string nome = "Leonardo";
            var aux = nome;//tipo definido em tempo de compilação
            int num1=2, num2=10, res = num1 * num2;
            Console.WriteLine("Nome:"+aux+" "+letra+".\n...");
            Console.WriteLine("A Multiplicação de " + num1 + " por " + num2 + " é igual a " + res);
        }
    }
}
