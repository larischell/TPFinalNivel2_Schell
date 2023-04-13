using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WindowsFormsApp_TP
{
    public partial class frmAltaCategoria : Form
    {
        private string accion;
        private string tipo;

        Categoria seleccionado;

        private List<Categoria> listaCategorias;

        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        public frmAltaCategoria(string tipo, string accion)
        {
            InitializeComponent();

            Text = tipo;
            lbTitulo.Text = accion;
            this.accion = accion;
            this.tipo = tipo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (!this.accion.Equals("Modificar"))
                {
                    categoria.Descripcion = txbDescripcioncategoria.Text;
                    if (string.IsNullOrWhiteSpace(txbDescripcioncategoria.Text))
                    {
                        throw new Exception();
                    }
                }
                else
                {

                    if (string.IsNullOrWhiteSpace(txbDescripcioncategoria.Text))
                    {
                        throw new Exception();
                    }
                    categoria.Descripcion = txbDescripcioncategoria.Text;
                    SelecionarDescripcionCategoria();
                    categoria.Id = seleccionado.Id;
                }


                if (this.accion.Equals("Modificar"))
                {

                    negocio.modificar(categoria);
                    MessageBox.Show("Categoria Modificada Exitosamente");
                    txbDescripcioncategoria.Text = null;
                    cargar();

                }
                else
                {
                    negocio.agregar(categoria);
                    MessageBox.Show("Categoria Agregada Exitosamente");
                    txbDescripcioncategoria.Text = null;

                    cargar();
                }

                cargar();

            }
            catch (Exception ex)
            {
                DialogResult respuesta = MessageBox.Show("¿Desea intentar de nuevo?", "Faltan Campos para grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No)
                {
                    Close();
                }
            }
        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                listaCategorias = negocio.listar();
                dgvCategoriasExistentes.DataSource = listaCategorias;
                dgvCategoriasExistentes.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvCategoriasExistentes_SelectionChanged(object sender, EventArgs e)
        {
            SelecionarDescripcionCategoria();
        }

        private void SelecionarDescripcionCategoria()
        {

            if (dgvCategoriasExistentes.CurrentRow != null && this.accion.Equals("Modificar"))
            {

                seleccionado = (Categoria)dgvCategoriasExistentes.CurrentRow.DataBoundItem;
                txbDescripcioncategoria.Text = seleccionado.Descripcion;

            }
        }


    }
}
