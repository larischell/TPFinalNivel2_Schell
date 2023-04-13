namespace WindowsFormsApp_TP
{
    partial class frmVerArticulo
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
            this.cboIdcategoria = new System.Windows.Forms.ComboBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbIdcategoria = new System.Windows.Forms.Label();
            this.lbIdmarca = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.pbArticulos = new System.Windows.Forms.PictureBox();
            this.cboIdmarca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // cboIdcategoria
            // 
            this.cboIdcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdcategoria.Enabled = false;
            this.cboIdcategoria.FormattingEnabled = true;
            this.cboIdcategoria.Location = new System.Drawing.Point(100, 397);
            this.cboIdcategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboIdcategoria.Name = "cboIdcategoria";
            this.cboIdcategoria.Size = new System.Drawing.Size(150, 21);
            this.cboIdcategoria.TabIndex = 15;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(100, 436);
            this.txbPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.ReadOnly = true;
            this.txbPrecio.Size = new System.Drawing.Size(150, 20);
            this.txbPrecio.TabIndex = 19;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(100, 325);
            this.txbDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.ReadOnly = true;
            this.txbDescripcion.Size = new System.Drawing.Size(150, 20);
            this.txbDescripcion.TabIndex = 11;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(100, 292);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.ReadOnly = true;
            this.txbNombre.Size = new System.Drawing.Size(150, 20);
            this.txbNombre.TabIndex = 9;
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(100, 257);
            this.txbCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.ReadOnly = true;
            this.txbCodigo.Size = new System.Drawing.Size(150, 20);
            this.txbCodigo.TabIndex = 7;
            this.txbCodigo.Tag = "";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(46, 443);
            this.lbPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(37, 13);
            this.lbPrecio.TabIndex = 20;
            this.lbPrecio.Text = "Precio";
            // 
            // lbIdcategoria
            // 
            this.lbIdcategoria.AutoSize = true;
            this.lbIdcategoria.Location = new System.Drawing.Point(20, 405);
            this.lbIdcategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdcategoria.Name = "lbIdcategoria";
            this.lbIdcategoria.Size = new System.Drawing.Size(66, 13);
            this.lbIdcategoria.TabIndex = 16;
            this.lbIdcategoria.Text = "ID Categoria";
            // 
            // lbIdmarca
            // 
            this.lbIdmarca.AutoSize = true;
            this.lbIdmarca.Location = new System.Drawing.Point(34, 366);
            this.lbIdmarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdmarca.Name = "lbIdmarca";
            this.lbIdmarca.Size = new System.Drawing.Size(51, 13);
            this.lbIdmarca.TabIndex = 14;
            this.lbIdmarca.Text = "ID Marca";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(23, 328);
            this.lbDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 12;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(39, 296);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 10;
            this.lbNombre.Text = "Nombre";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(42, 262);
            this.lbCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 8;
            this.lbCodigo.Text = "Codigo";
            // 
            // pbArticulos
            // 
            this.pbArticulos.BackColor = System.Drawing.SystemColors.Info;
            this.pbArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbArticulos.Location = new System.Drawing.Point(66, 21);
            this.pbArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbArticulos.Name = "pbArticulos";
            this.pbArticulos.Size = new System.Drawing.Size(206, 220);
            this.pbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulos.TabIndex = 21;
            this.pbArticulos.TabStop = false;
            // 
            // cboIdmarca
            // 
            this.cboIdmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdmarca.Enabled = false;
            this.cboIdmarca.FormattingEnabled = true;
            this.cboIdmarca.Location = new System.Drawing.Point(100, 363);
            this.cboIdmarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboIdmarca.Name = "cboIdmarca";
            this.cboIdmarca.Size = new System.Drawing.Size(150, 21);
            this.cboIdmarca.TabIndex = 13;
            // 
            // frmVerArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 488);
            this.Controls.Add(this.pbArticulos);
            this.Controls.Add(this.cboIdcategoria);
            this.Controls.Add(this.cboIdmarca);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbIdcategoria);
            this.Controls.Add(this.lbIdmarca);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVerArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerArticulo";
            this.Load += new System.EventHandler(this.frmVerArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboIdcategoria;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbIdcategoria;
        private System.Windows.Forms.Label lbIdmarca;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.PictureBox pbArticulos;
        private System.Windows.Forms.ComboBox cboIdmarca;
    }
}