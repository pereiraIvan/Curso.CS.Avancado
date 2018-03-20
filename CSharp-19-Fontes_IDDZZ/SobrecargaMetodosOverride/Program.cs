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

namespace SobrecargaMetodosOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Musica mp3 = new Musica() { Nome = "Dream Theater - Illumination Theory" };
            DocumentoWord doc = new DocumentoWord() { Nome = ".net Magazine - Artigo POO" };
            Imagem img = new Imagem() { Nome = "Golden Gate Bridge" };
            Windows windows = new Windows();
            windows.Add(mp3);
            windows.Add(doc);
            windows.Add(img);
            windows.Abrir(mp3);
            windows.Abrir(doc);
            windows.Abrir(img);
            Console.ReadLine();
        }
    }
}
