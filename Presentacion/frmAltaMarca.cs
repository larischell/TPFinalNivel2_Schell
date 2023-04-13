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
    public partial class frmAltaMarca : Form
    {
     
        Marca seleccionado;
        
        private string accion;
        private string tipo;

        private List<Marca> listaMarcas;
        
        public frmAltaMarca()
        {
            InitializeComponent();
          
        }
        
        public frmAltaMarca(string tipo,string accion)
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
            Marca marca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if(!this.accion.Equals("Modificar"))
                {
                    marca.DescripcionMarca = txbDescripcionmarca.Text;
                    if (string.IsNullOrWhiteSpace(txbDescripcionmarca.Text))
                    {
                       
                        throw new Exception();
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txbDescripcionmarca.Text))
                    {
                        throw new Exception();
                    }
                    
                    //Traigo del la grilla el ID seleccionado.
                    marca.DescripcionMarca = txbDescripcionmarca.Text;
                    SelecionarDescripcionMarca();
                    marca.Id = seleccionado.Id;
                }
               
          
                if(this.accion.Equals("Modificar"))
                {   
                   
                    negocio.modificar(marca);
                    MessageBox.Show("Marca Modificada Existosamente");
                    txbDescripcionmarca.Text = null;
                    cargar();

                }
                else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Marca Agregada Exitosamente");
                    txbDescripcionmarca.Text = null;
                    cargar();
                }

                // Close();
                cargar();

            }
            catch (Exception ex)
            {
                DialogResult respuesta = MessageBox.Show("¿Desea intentar de nuevo?", "No es posible la operacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No)
                {
                    Close();
                }
            }
                
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                cargar();
                //txbDescripcionmarca.Text = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                listaMarcas = negocio.listar();
                dgvMarcasExistentes.DataSource = listaMarcas;
                dgvMarcasExistentes.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

        private void dgvMarcasExistentes_SelectionChanged(object sender, EventArgs e)
        {
            SelecionarDescripcionMarca();
        }

        private void SelecionarDescripcionMarca()
        {
         
            if (dgvMarcasExistentes.CurrentRow != null && this.accion.Equals("Modificar"))
            {

                seleccionado = (Marca)dgvMarcasExistentes.CurrentRow.DataBoundItem;
                txbDescripcionmarca.Text = seleccionado.DescripcionMarca;

            }
        }


    }
}
