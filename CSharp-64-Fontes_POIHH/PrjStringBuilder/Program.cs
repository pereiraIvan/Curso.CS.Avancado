using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void Exemplo6()
        {
            var sb = new StringBuilder("Teste1", 20);
            sb.AppendLine("Teste2");
            Console.WriteLine(sb);
            Console.ReadLine();
        }

        private static void Exemplo5()
        {
            var sb = new StringBuilder();
            sb.AppendLine("abcdefghijklmnopqrstuvxywz".ToUpper());
            sb.Remove(4, 10);
            Console.WriteLine(sb);
            Console.ReadLine();
        }

        private static void Exemplo4()
        {
            var sb = new StringBuilder();
            sb.AppendLine("abcdefghijklmnopqrstuvxywz".ToUpper());
            Console.WriteLine(sb[2]);
            Console.ReadLine();
        }

        private static void Exemplo3()
        {
            var sb = new StringBuilder();
            sb.Append("Qualquer tolo pode escrever código que um computador possa entender. Bons programadores escrevem código que humanos podem entender. Martin Fowler");
            sb.Replace("código", "code");
            Console.WriteLine(sb);
            Console.ReadLine();
        }

        
        private static void Exemplo2()
        {
            var sb = new StringBuilder();
            sb.Append("Primeira linha");
            sb.AppendLine();
            sb.Append("Segunda linha");
            var str = sb.ToString();
            Console.WriteLine(str);
            Console.ReadLine();
        }

        private static void Exemplo1()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
                sb.Append(i).Append(" ");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
