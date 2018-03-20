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
using System.Collections;
using System.Data;

namespace ArrayListApp
{
  class Program
  {
    static void Main(string[] args)
    {
      var turma = new ArrayList();
      turma.Add("Guinther");
      turma.Add("Rudolfo");
      turma.Add(new DataSet());
      foreach (var item in turma)
        Console.WriteLine(item);
      Console.WriteLine("Capacidade: " + turma.Capacity);
      Console.WriteLine("Count: " + turma.Count);
      Console.ReadLine();
    }
  }
}
