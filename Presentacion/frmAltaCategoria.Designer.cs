namespace WindowsFormsApp_TP
{
    partial class frmAltaCategoria
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txbDescripcioncategoria = new System.Windows.Forms.TextBox();
            this.lbIdcategoriaExistente = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.dgvCategoriasExistentes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriasExistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTitulo.Location = new System.Drawing.Point(3, 14);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(128, 26);
            this.lbTitulo.TabIndex = 40;
            this.lbTitulo.Text = "Registration";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(281, 103);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(61, 25);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(194, 103);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(56, 25);
            this.btnAceptar.TabIndex = 38;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txbDescripcioncategoria
            // 
            this.txbDescripcioncategoria.Location = new System.Drawing.Point(196, 60);
            this.txbDescripcioncategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbDescripcioncategoria.Name = "txbDescripcioncategoria";
            this.txbDescripcioncategoria.Size = new System.Drawing.Size(150, 20);
            this.txbDescripcioncategoria.TabIndex = 35;
            this.txbDescripcioncategoria.Tag = "";
            // 
            // lbIdcategoriaExistente
            // 
            this.lbIdcategoriaExistente.AutoSize = true;
            this.lbIdcategoriaExistente.Location = new System.Drawing.Point(434, 34);
            this.lbIdcategoriaExistente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdcategoriaExistente.Name = "lbIdcategoriaExistente";
            this.lbIdcategoriaExistente.Size = new System.Drawing.Size(108, 13);
            this.lbIdcategoriaExistente.TabIndex = 37;
            this.lbIdcategoriaExistente.Text = "Categorias Existentes";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(25, 66);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(137, 13);
            this.lblDescripcion.TabIndex = 34;
            this.lblDescripcion.Text = "Descripcion de la Categoria";
            // 
            // dgvCategoriasExistentes
            // 
            this.dgvCategoriasExistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoriasExistentes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCategoriasExistentes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvCategoriasExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriasExistentes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategoriasExistentes.Location = new System.Drawing.Point(404, 50);
            this.dgvCategoriasExistentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCategoriasExistentes.MultiSelect = false;
            this.dgvCategoriasExistentes.Name = "dgvCategoriasExistentes";
            this.dgvCategoriasExistentes.RowHeadersWidth = 4;
            this.dgvCategoriasExistentes.RowTemplate.Height = 24;
            this.dgvCategoriasExistentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoriasExistentes.Size = new System.Drawing.Size(170, 182);
            this.dgvCategoriasExistentes.TabIndex = 41;
            this.dgvCategoriasExistentes.SelectionChanged += new System.EventHandler(this.dgvCategoriasExistentes_SelectionChanged);
            // 
            // frmAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 278);
            this.Controls.Add(this.dgvCategoriasExistentes);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txbDescripcioncategoria);
            this.Controls.Add(this.lbIdcategoriaExistente);
            this.Controls.Add(this.lblDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altas de Categorias";
            this.Load += new System.EventHandler(this.frmAltaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriasExistentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txbDescripcioncategoria;
        private System.Windows.Forms.Label lbIdcategoriaExistente;
        private System.Windows.Forms.Label lblDescripcion;
        public System.Windows.Forms.DataGridView dgvCategoriasExistentes;
    }
}