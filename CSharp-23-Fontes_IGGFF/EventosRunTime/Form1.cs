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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosRunTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarButtonEmRuntime_Click(object sender, EventArgs e)
        {
            var bt = new Button();
            bt.Parent = this;
            this.Controls.Add(bt);
            bt.Text = "Clique aqui";
            bt.Location = new System.Drawing.Point(58, 80);
            bt.Click += new EventHandler(bt_Click); // apontando o evento para um método 
            bt.Click += delegate(object s, EventArgs ea)
                {
                    // método anônimo
                    MessageBox.Show("Ola Mundo!");
                };
            bt.Click += (s, ea) => MessageBox.Show("Hello world");
        }

        void bt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ola Mundo!");
        }
    }
}
