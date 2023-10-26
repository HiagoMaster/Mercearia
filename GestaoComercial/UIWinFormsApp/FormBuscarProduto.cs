﻿using BLL;
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
    public partial class FormBuscarProduto : Form
    {
        public FormBuscarProduto()
        {
            InitializeComponent();
        }

        private void button1Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        bindingSourceProduto.DataSource = new ProdutoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarPor.Text));
                        break;
                    case 1:
                        bindingSourceProduto.DataSource = new ProdutoBLL().BuscarPorNome(textBoxBuscarPor.Text);
                        break;
                    case 2:
                        bindingSourceProduto.DataSource = new ProdutoBLL().BuscarPorCodigoDeBarra(textBoxBuscarPor.Text);
                        break;
                    default:
                        bindingSourceProduto.DataSource = new ProdutoBLL().BuscarTodos();
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
    

