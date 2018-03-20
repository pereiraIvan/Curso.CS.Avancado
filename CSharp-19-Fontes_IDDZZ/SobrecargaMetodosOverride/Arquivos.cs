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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodosOverride
{
    public class Musica : Object
    {
        public string Nome;
        public int Tamanho;
        public void Abrir()
        {
            Console.WriteLine("Tocando música: " + Nome);
        }
    }
    public class DocumentoWord : Object
    {
        public string Nome;
        public int Tamanho;
        public void Abrir()
        {
            Console.WriteLine("Mostrando documento do Word: " + Nome);
        }
    }
    public class Imagem : Object
    {
        public string Nome;
        public int Tamanho;
        public void Abrir()
        {
            Console.WriteLine("Exibindo imagem: " + Nome);
        }
    }
    public class Windows
    {
        private ArrayList _arquivos;
        public Windows()
        {
            this._arquivos = new ArrayList();
        }
        public void Add(Object arquivo)
        {
            this._arquivos.Add(arquivo);
        }
        public void Abrir(Object arquivo)
        {
            // delegação
            if (arquivo is Musica)
                (arquivo as Musica).Abrir();
            if (arquivo is Imagem)
                (arquivo as Imagem).Abrir();
            if (arquivo is DocumentoWord)
                (arquivo as DocumentoWord).Abrir();
        }
    }
}
