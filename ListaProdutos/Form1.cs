using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaProdutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Timer temporizador = new Timer();
            temporizador.Interval = 1000;
            temporizador.Tick += new EventHandler(alterarDataHora);
            temporizador.Start();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputLista.Text))
            {
                if (Mensagem.Exibir("Você tem certeza que deseja inserir esse item na lista?"))
                {
                    boxLista.Items.Add(inputLista.Text.ToUpper());
                    inputLista.Clear();
                    inputLista.Focus();
                }
            }
        }

        void alterarDataHora(object sender, EventArgs e)
        {
            dataHora.Text = DateTime.Now.ToString();
        }

        private void remover_Click(object sender, EventArgs e)
        {
            int item = boxLista.SelectedIndex;

            if (item >= 0)
            {
                if (Mensagem.Exibir("Você tem certeza que deseja remover o item?"))
                {
                    boxLista.Items.RemoveAt(item);
                }
            }
        }

        private void removerTudo_Click(object sender, EventArgs e)
        {

            if (Mensagem.Exibir("Tem certeza que deseja remover a lista toda?"))
            {
                boxLista.Items.Clear();
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            inputLista.Clear();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            if (Mensagem.Exibir())
            {
                this.Close();
            }
        }
    }
}
