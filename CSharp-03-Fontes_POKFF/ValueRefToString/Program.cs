﻿/*
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
using System.Text;

namespace ValueRef
{
    public class Cliente: Object // Reference type
    {
        public int Codigo;
        public string Nome;
        public string Telefone;
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Codigo: " + Codigo);
            sb.AppendLine("Nome: " + Nome);
            sb.AppendLine("Telefone: " + Telefone);
            return sb.ToString();
        }
    }


    class Program
    {
        public static void MostrarValueTypes()
        {
            int x = 10;
            string s = "Guinther";
            bool b = false;
            Console.WriteLine(x);
            Console.WriteLine(s);
            Console.WriteLine(b);
        }

        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            c1.Codigo = 123;
            c1.Nome = "Guinther";
            c1.Telefone = "999999999";
            Cliente c2 = new Cliente(); // aponta para o mesma posição de memória c1
            c2.Nome = "Rudolfo";
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            if (c1.Equals(c2))
                Console.WriteLine("c1 e c2 são os mesmos objetos");
            else
                Console.WriteLine("c1 e c2 são objetos diferentes");
            //Console.WriteLine(c.Codigo);
            //Console.WriteLine(c.Nome);
            //Console.WriteLine(c.Telefone);   
            Console.ReadLine();
        }
    }
}
