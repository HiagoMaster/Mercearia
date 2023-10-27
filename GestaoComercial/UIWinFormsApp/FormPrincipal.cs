using System.Security.Cryptography;
using System.Windows.Forms;

namespace UIWinFormsApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

   
        

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormBuscarCliente frm = new FormBuscarCliente())
            {
                frm.ShowDialog();
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormBuscarProduto frm = new FormBuscarProduto())
            {
                frm.ShowDialog();
            }
        }
    }
}