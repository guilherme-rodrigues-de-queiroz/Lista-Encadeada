using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaEncadeada
{
    public partial class Form1 : Form
    {
        List<string> lista = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Add(txtValor.Text);

            txtValor.Clear();
            txtValor.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbxValores.Items.Clear();

            for(int i = 0; i < lista.Count; i++)
            {
                lbxValores.Items.Add(lista[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lista.Remove(txtValor.Text);
            txtValor.Clear();
            txtValor.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int posicao = lista.IndexOf(txtValorAntigo.Text);
            
            if(posicao < 0)
            {
                MessageBox.Show("O valor não foi encontrado!");
                return;
            }

            txtValor.Clear();
            txtValor.Focus();
            lista[posicao] = txtValorNovo.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lista.Contains(txtValor.Text))
            {
                MessageBox.Show("Valor existe");
            }
            else
            {
                MessageBox.Show("Valor não existe");
            }
        }
    }
}
