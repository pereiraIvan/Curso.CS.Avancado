using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace DevNotePad
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void LerArquivo(string FileName)
        {
            
            StreamReader reader = File.OpenText(FileName);
            string str = "";
            StringBuilder builder = new StringBuilder();
            // le arquivo linha a linha
            while ((str = reader.ReadLine()) != null)
            {
                builder.AppendLine(str);
            }
            txtArquivo.Text = builder.ToString();
        }

        private void SalvarArquivo(string FileName)
        {
            if (!File.Exists(FileName))
            {
                FileStream fs = File.Create(FileName);
                Byte[] arq = new UTF8Encoding(true).GetBytes(txtArquivo.Text);
                fs.Write(arq, 0, arq.Length);
                fs.Close();
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openDlg.ShowDialog() == DialogResult.OK)
                LerArquivo(openDlg.FileName);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (saveDlg.ShowDialog() == DialogResult.OK)
                SalvarArquivo(saveDlg.FileName);
        }
    }
}
