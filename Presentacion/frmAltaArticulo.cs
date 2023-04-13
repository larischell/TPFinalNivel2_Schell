using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Dominio;
using Negocio;

namespace WindowsFormsApp_TP
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
            lbTitulo.Text = "Modificar Articulo";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            bool b = true;
            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }

                //Validar que no tenga esapacios el codigo
                if (!string.IsNullOrWhiteSpace(txbCodigo.Text))
                {
                    articulo.Codigo = txbCodigo.Text;
                }
                else
                {
                    throw new Exception();
                }

                articulo.Nombre = txbNombre.Text;
                articulo.Descripcion = txbDescripcion.Text;

                //Recibo del comboBox el item seleccionado y hago un casteo del objeto.
                articulo.marca = (Marca)cboIdmarca.SelectedItem;
                articulo.categoria = (Categoria)cboIdcategoria.SelectedItem;

                articulo.ImagenUrl = txbURL.Text;
                // Validar si el formato del precio es vacio o es 0
                
                    if (decimal.Parse(txbPrecio.Text) > 0)
                    {
                        //articulo.Precio = Convert.ToDecimal(txbPrecio.Text);
                        articulo.Precio = decimal.Parse(txbPrecio.Text);
                    }
                    else
                    {
                        //si el precio es menor a 0 o vacio, entonces ir directamente al catch
                        throw new Exception();
                    }
   
                
                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Articulo modificado con exito");
                    CargarImagen(articulo.ImagenUrl);
                    b = false;
                    Clear();
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo agregado con exito");
                    b = false;
                    Clear();
                }

                if (archivo != null && !(txbURL.Text.ToUpper().Contains("HTTP")))
                    PictureLocal();

                this.Close();
            }
            catch (Exception ex)
            {
                if (b) {
                    DialogResult respuesta = MessageBox.Show("¿Desea intentar de nuevo?", "Verifique los campos y que el precio sea un numero", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.No)
                        Close();
                }
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
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

                if (articulo != null)
                {
                    txbCodigo.Text = articulo.Codigo;
                    txbNombre.Text = articulo.Nombre;
                    txbDescripcion.Text = articulo.Descripcion;
                    cboIdmarca.SelectedValue = articulo.marca.Id;
                    cboIdcategoria.SelectedValue = articulo.categoria.Id;
                    txbURL.Text = articulo.ImagenUrl;
                    txbPrecio.Text = articulo.Precio.ToString();
                    CargarImagen(txbURL.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnImagen_Click_1(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png|gif|*.gif";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txbURL.Text = archivo.FileName;
                CargarImagen(archivo.FileName);
            }
        }
        private void PictureLocal()
        {
            File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Articulo - App"] + archivo.SafeFileName);
        }

        private void Clear()
        {
            txbCodigo.Text = null;
            txbDescripcion.Text = null;
            txbNombre.Text = null;
            txbPrecio.Text = null;
            txbURL.Text = null;
            CargarImagen(null);
        }

        private void CargarImagen(string imagen)
        {
            try
            {

                pbxImagenAlta.Load(imagen);

            }
            catch (Exception)
            {

                pbxImagenAlta.Load("https://th.bing.com/th/id/R.5f8b98acd656c6d261777d035c50a112?rik=9e0Xk%2brW5WO0Yg&riu=http%3a%2f%2fimg2.wikia.nocookie.net%2f__cb20140518072131%2ftowerofsaviors%2fimages%2f4%2f47%2fPlaceholder.png&ehk=CZAAxtW4x95yvm5bFj%2fqN8pJu9M9F1JW8H5KVFRhKnk%3d&risl=&pid=ImgRaw&r=0");
            }
        }


    }
}
