namespace WindowsFormsApp_TP
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbIdmarca = new System.Windows.Forms.Label();
            this.lbIdcategoria = new System.Windows.Forms.Label();
            this.lbURL = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbURL = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cboIdmarca = new System.Windows.Forms.ComboBox();
            this.cboIdcategoria = new System.Windows.Forms.ComboBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.pbxImagenAlta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(52, 59);
            this.lbCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Codigo";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(49, 93);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(32, 124);
            this.lbDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 2;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // lbIdmarca
            // 
            this.lbIdmarca.AutoSize = true;
            this.lbIdmarca.Location = new System.Drawing.Point(45, 157);
            this.lbIdmarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdmarca.Name = "lbIdmarca";
            this.lbIdmarca.Size = new System.Drawing.Size(51, 13);
            this.lbIdmarca.TabIndex = 3;
            this.lbIdmarca.Text = "ID Marca";
            // 
            // lbIdcategoria
            // 
            this.lbIdcategoria.AutoSize = true;
            this.lbIdcategoria.Location = new System.Drawing.Point(29, 188);
            this.lbIdcategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdcategoria.Name = "lbIdcategoria";
            this.lbIdcategoria.Size = new System.Drawing.Size(66, 13);
            this.lbIdcategoria.TabIndex = 4;
            this.lbIdcategoria.Text = "ID Categoria";
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(29, 219);
            this.lbURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(67, 13);
            this.lbURL.TabIndex = 5;
            this.lbURL.Text = "URL Imagen";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(56, 258);
            this.lbPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(37, 13);
            this.lbPrecio.TabIndex = 6;
            this.lbPrecio.Text = "Precio";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(110, 54);
            this.txbCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(150, 20);
            this.txbCodigo.TabIndex = 0;
            this.txbCodigo.Tag = "";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(110, 89);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(150, 20);
            this.txbNombre.TabIndex = 1;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(110, 122);
            this.txbDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(150, 20);
            this.txbDescripcion.TabIndex = 2;
            // 
            // txbURL
            // 
            this.txbURL.Location = new System.Drawing.Point(110, 214);
            this.txbURL.Margin = new System.Windows.Forms.Padding(2);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(150, 20);
            this.txbURL.TabIndex = 5;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(110, 255);
            this.txbPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(150, 20);
            this.txbPrecio.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(110, 297);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(56, 25);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(197, 297);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(61, 25);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTitulo.Location = new System.Drawing.Point(30, 7);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(168, 26);
            this.lbTitulo.TabIndex = 16;
            this.lbTitulo.Text = "Agregar Articulo";
            // 
            // cboIdmarca
            // 
            this.cboIdmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdmarca.FormattingEnabled = true;
            this.cboIdmarca.Location = new System.Drawing.Point(110, 150);
            this.cboIdmarca.Margin = new System.Windows.Forms.Padding(2);
            this.cboIdmarca.Name = "cboIdmarca";
            this.cboIdmarca.Size = new System.Drawing.Size(150, 21);
            this.cboIdmarca.TabIndex = 3;
            // 
            // cboIdcategoria
            // 
            this.cboIdcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdcategoria.FormattingEnabled = true;
            this.cboIdcategoria.Location = new System.Drawing.Point(110, 181);
            this.cboIdcategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboIdcategoria.Name = "cboIdcategoria";
            this.cboIdcategoria.Size = new System.Drawing.Size(150, 21);
            this.cboIdcategoria.TabIndex = 4;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(264, 214);
            this.btnImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnImagen.Size = new System.Drawing.Size(26, 20);
            this.btnImagen.TabIndex = 17;
            this.btnImagen.Text = "+";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click_1);
            // 
            // pbxImagenAlta
            // 
            this.pbxImagenAlta.BackColor = System.Drawing.SystemColors.Info;
            this.pbxImagenAlta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImagenAlta.Location = new System.Drawing.Point(317, 54);
            this.pbxImagenAlta.Margin = new System.Windows.Forms.Padding(2);
            this.pbxImagenAlta.Name = "pbxImagenAlta";
            this.pbxImagenAlta.Size = new System.Drawing.Size(213, 211);
            this.pbxImagenAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenAlta.TabIndex = 18;
            this.pbxImagenAlta.TabStop = false;
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 333);
            this.Controls.Add(this.pbxImagenAlta);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.cboIdcategoria);
            this.Controls.Add(this.cboIdmarca);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbURL);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.lbIdcategoria);
            this.Controls.Add(this.lbIdmarca);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbIdmarca;
        private System.Windows.Forms.Label lbIdcategoria;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ComboBox cboIdmarca;
        private System.Windows.Forms.ComboBox cboIdcategoria;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.PictureBox pbxImagenAlta;
    }
}