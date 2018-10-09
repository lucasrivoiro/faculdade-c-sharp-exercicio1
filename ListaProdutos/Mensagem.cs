using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaProdutos
{
    class Mensagem
    {
        public static bool Exibir(string mensagem = "Você tem certeza que deseja fazer isso?", string titulo = "Atenção")
        {
            DialogResult pergunta = MessageBox.Show(
                mensagem, 
                titulo, 
                MessageBoxButtons.YesNo
            );

            if (pergunta == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }
    }
}
