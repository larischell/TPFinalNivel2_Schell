using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_TP
{
    public partial class frmVerArticulo : Form
    {
        private Articulo articulo = null;
        public frmVerArticulo()
        {
            InitializeComponent();
        }

        public frmVerArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalle del articulo";
        }

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
        private void frmVerArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                cboIdmarca.DataSource = marcaNegocio.listar();
                cboIdmarca.ValueMember = "Id";
                cboIdmarca.DisplayMember = "DescripcionMarca";
                cboIdcategoria.DataSource = categoriaNegocio.listar();
                cboIdcategoria.ValueMember = "Id";
                cboIdcategoria.DisplayMember = "Descripcion";

                txbCodigo.Text = articulo.Codigo;
                txbNombre.Text = articulo.Nombre;
                txbDescripcion.Text = articulo.Descripcion;
                cargarImagen(articulo.ImagenUrl);
                cboIdmarca.SelectedValue = articulo.marca.Id;
                cboIdcategoria.SelectedValue = articulo.categoria.Id;
                txbPrecio.Text = articulo.Precio.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }
    }
}
