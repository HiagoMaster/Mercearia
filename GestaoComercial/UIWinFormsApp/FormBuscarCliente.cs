using BLL;
using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWinFormsApp
{
    public partial class FormBuscarCliente : Form
    {
        public FormBuscarCliente()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        bindingSourceCliente.DataSource = new ClienteBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarPor.Text));
                        break;
                    case 1:
                        bindingSourceCliente.DataSource = new ClienteBLL().BuscarPorNome(textBoxBuscarPor.Text);
                        break;
                    case 2:
                        bindingSourceCliente.DataSource = new ClienteBLL().BuscarPorTelefone(textBoxBuscarPor.Text);
                        break;
                    default:
                        bindingSourceCliente.DataSource = new ClienteBLL().BuscarTodos();
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((Cliente)bindingSourceCliente.Current).Id;
            using(FormCadastrarCliente frm = new FormCadastrarCliente())
            {
                frm.ShowDialog();
            }

        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using(FormCadastrarCliente frm = new FormCadastrarCliente())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse cliente?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                return;
            int id = ((Cliente)bindingSourceCliente.Current).Id;
            new UsuarioBLL().Excluir(id);
            bindingSourceCliente.RemoveCurrent();
            MessageBox.Show("Cliente excluido com sucesso!");
        }
    }
}
    

