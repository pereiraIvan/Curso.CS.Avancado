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
using System.Data.SqlClient;
using System.Text;

namespace InterfacesIDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Conexao con = new Conexao())
            {
                con.Conectar();
                con.Fechar();
            }
            Console.ReadLine();
        }

        private static void TesteSqlConnection()
        {
            var obj = new SqlConnection();
            try
            {
                //...                
            }
            finally
            {
                if (obj != null)
                    obj.Dispose();
            }
            using (var obj2 = new SqlConnection())
            {

            }
        }
    }
}
