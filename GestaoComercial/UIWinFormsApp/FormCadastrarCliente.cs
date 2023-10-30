using BLL;
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
    public partial class FormCadastrarCliente : Form
    {
        private int id;
        public FormCadastrarCliente(int _id = 0)
        {
            InitializeComponent();
            id = _id;
            if (id == 0)
                bindingSourceCadastrarCliente.AddNew();
            else
                bindingSourceCadastrarCliente.DataSource = new ClienteBLL().BuscarPorId(id);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastrarCliente.EndEdit();
                Cliente cliente = (Cliente)bindingSourceCadastrarCliente.Current;
                if(id == 0)
                    new ClienteBLL().Inserir(cliente);
                else
                    new ClienteBLL().Alterar(cliente);
                MessageBox.Show("Cliente salvo com sucesso!"); 
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
