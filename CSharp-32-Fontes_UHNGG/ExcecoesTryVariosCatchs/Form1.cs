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

namespace Excecoes
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal peso = Convert.ToDecimal(txtPeso.Text);
                decimal altura = Convert.ToDecimal(txtAltura.Text);
                decimal imc = peso / (altura * altura);
                txtIMC.Text = imc.ToString();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Valor muito grande para peso / altura");
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe valores corretos para peso / altura");
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Altura não pode ser zero");
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Erro aritmético");
            }
            catch (Exception)
            {
                // tratar as mais genéricas por último
                MessageBox.Show("Não foi possível calcular o IMC");
            }
            finally // sempre é executado
            {
                txtAltura.Clear();
                txtPeso.Clear();
            }
            // aqui
        }
    }
}
