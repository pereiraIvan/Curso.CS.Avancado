/*
Sobre o autor:
Guinther Pauli
Cursos Treinamentos Consultoria
Delphi Certified Professional - 3,5,6,7,2005,2006,Delphi Web,Kylix,XE
Microsoft Certified Professional - MCP,MCAD,MCSD.NET,MCTS,MCPD (C#, ASP.NET, Arquitetura)
Colaborador Editorial Revistas .net Magazine e ClubeDelphi
MVP (Most Valuable Professional)
Emails: guintherpauli@gmail.com / guinther@gpauli.com
http://www.gpauli.com
http://www.guintherpauli.blogspot.com.br
http://www.facebook.com/guintherpauli
http://www.twitter.com/guintherpauli
http://br.linkedin.com/in/guintherpauli
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesThrow
{
    class Program
    {
        private static void Estagiario(string Tarefa)
        {
            Convert.ToDateTime(Tarefa);
        }

        private static void Programador(string Tarefa)
        {
            try
            {
                Estagiario(Tarefa);
            }
            catch
            {
                Console.WriteLine("Programador capturou exceção");
                throw new Exception("Estagiário cometeu erro");
            }
        }

        private static void Arquiteto(string Tarefa)
        {
            Programador(Tarefa);
        }

        private static void Coordenador(string Tarefa)
        {
            Arquiteto(Tarefa);
        }

        private static void Gerente(string Tarefa)
        {
            try
            {
                Coordenador(Tarefa);
            }
            catch(Exception E)
            {
                Console.WriteLine("Gerente capturou a exceção");
                Console.WriteLine(E.Message);
            }
        }

        static void Main(string[] args)
        {
            string tarefa = "99/99/9999";
            Console.WriteLine("Executando tarefa...");
            Gerente(tarefa);
            Console.ReadLine();
        }
    }
}
