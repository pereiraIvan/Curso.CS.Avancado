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

namespace InterfacesIDisposable
{
    public class Conexao: IDisposable
    {
        // resource
        private string Handle;

        public Conexao()
        {
            this.Handle = "Recurso alocado";
            Console.WriteLine("Recurso alocado");
        }

        public void Conectar()
        {
            Console.WriteLine("Conectado");
        }

        public void Fechar()
        {
            Console.WriteLine("Desconectado");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void LiberarRecursos()
        {
            Handle = "";
            Console.WriteLine("Recurso liberado com sucesso");
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // liberar recursos managed
            }
            // liberar recursos unmanaged
            LiberarRecursos();
        }
    }
}
