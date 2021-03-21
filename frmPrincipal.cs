using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrSystem
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            

        }

        private void frmPrincipal_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private frmLogin Login = null;
        private frmBuscarClientes BuscarClientes = null;
        private frmEditarCliente EditarCliente = null;
        private frmEsqueciSenha EsqueciSenha = null;
        private frmPrimeiroAcesso PrimeiroAcesso = null;

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            #region inicio
           
            #endregion
            #region Clientes
            if (treeView1.SelectedNode.Text == "Buscar clientes")
            {
                
                if (Application.OpenForms.OfType<frmBuscarClientes>().Count() > 0)
                {
                    this.BuscarClientes.WindowState = FormWindowState.Normal;

                }
                else
                {

                    this.BuscarClientes = new frmBuscarClientes();
                    this.BuscarClientes.Text = "Buscar Clientes";
                    this.BuscarClientes.TopLevel = false;
                    
                    this.BuscarClientes.Visible = true;
                    this.BuscarClientes.FormBorderStyle = FormBorderStyle.Sizable;
                    gbPrincipal.Controls.Add(BuscarClientes);
                }
            }
            else if (treeView1.SelectedNode.Text == "Cadastrar/Editar/Excluir")
            {

                if (Application.OpenForms.OfType<frmEditarCliente>().Count() > 0)
                {
                    this.EditarCliente.WindowState = FormWindowState.Normal;

                }
                else
                {

                    this.EditarCliente = new frmEditarCliente();
                    this.EditarCliente.Text = "Cadastrar/Editar/Excluir";
                    this.EditarCliente.TopLevel = false;
                    this.EditarCliente.Visible = true;
                    this.EditarCliente.FormBorderStyle = FormBorderStyle.Sizable;
                    gbPrincipal.Controls.Add(EditarCliente);
                }
            }
            


            #endregion


        }
    }
}
