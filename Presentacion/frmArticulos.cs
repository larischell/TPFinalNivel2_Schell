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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp_TP
{
    public partial class frmArticulo : Form
    {
        private List<Articulo> listaArticulos;

        public frmArticulo()
        {
            InitializeComponent();
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
            cboCampo.Items.Add("Precio");
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }

        //metodo para imagenes sin url
        private void cargarImagen(string imagen)
        {
            try
            {
                pbArticulos.Load(imagen);
            }
            catch (Exception)
            {
                pbArticulos.Load("https://th.bing.com/th/id/R.5f8b98acd656c6d261777d035c50a112?rik=9e0Xk%2brW5WO0Yg&riu=http%3a%2f%2fimg2.wikia.nocookie.net%2f__cb20140518072131%2ftowerofsaviors%2fimages%2f4%2f47%2fPlaceholder.png&ehk=CZAAxtW4x95yvm5bFj%2fqN8pJu9M9F1JW8H5KVFRhKnk%3d&risl=&pid=ImgRaw&r=0");
            }
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listar();
                dgvArticulo.DataSource = listaArticulos;
                dgvArticulo.Columns["ImagenURL"].Visible = false;
                dgvArticulo.Columns["Id"].Visible = false;
                cargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
            catch
            {
                MessageBox.Show("No hay articulos para modificar");
            }
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("Confirma la eliminacion del articulo seleccionado? ", "Eliminando articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch
            {
                MessageBox.Show("No hay articulos seleccionados para eliminar");
            }
        }
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Igual a");
                cboCriterio.Items.Add("Menor a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Contiene");
                cboCriterio.Items.Add("Termina con");
            }
        }
        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un campo para la busqueda");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un criterio para la busqueda");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("por favor ingrese un precio");
                    return true;
                }
                if (!(soloNumeros(txtFiltro.Text)))
                {
                    MessageBox.Show("Solo se pueden ingresar numeros");
                    return true;
                }
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            List<Articulo> lista = new List<Articulo>();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvArticulo.DataSource = articulo.filtrar(campo, criterio, filtro);

                int cantidad = 0;
                lista = articulo.filtrar(campo, criterio, filtro);
                lista.Capacity = cantidad;

                if (cantidad == 0)
                    pbArticulos.Load("https://th.bing.com/th/id/R.5f8b98acd656c6d261777d035c50a112?rik=9e0Xk%2brW5WO0Yg&riu=http%3a%2f%2fimg2.wikia.nocookie.net%2f__cb20140518072131%2ftowerofsaviors%2fimages%2f4%2f47%2fPlaceholder.png&ehk=CZAAxtW4x95yvm5bFj%2fqN8pJu9M9F1JW8H5KVFRhKnk%3d&risl=&pid=ImgRaw&r=0");
            }
            catch
            {

            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                frmVerArticulo ver = new frmVerArticulo(seleccionado);
                ver.ShowDialog();
                cargar();
            }
            catch
            {
                MessageBox.Show("No hay articulos para mostrar");
            }
        }

        private void MenuArgegaMarca_Click(object sender, EventArgs e)
        {
            //Alta de Marcas

            frmAltaMarca alta = new frmAltaMarca("Marca", "Agregar");
            alta.ShowDialog();
        }

        private void MenuAgregaCategoria_Click(object sender, EventArgs e)
        {
            //Altas de Categorias
            frmAltaCategoria altacategoria = new frmAltaCategoria("Categoria", "Agregar");
            altacategoria.ShowDialog();
        }

        private void MenuModificaMarca_Click(object sender, EventArgs e)
        {
            //Modifcacion de Marcas
            frmAltaMarca modificar = new frmAltaMarca("Marca", "Modificar");
            modificar.ShowDialog();
            cargar();

        }

        private void MenuModificaCategoria_Click(object sender, EventArgs e)
        {
            //Modificacion de Categorias
            frmAltaCategoria modificar = new frmAltaCategoria("Categoria", "Modificar");
            modificar.ShowDialog();
            cargar();


        }


    }
}

