namespace WindowsFormsApp_TP
{
    partial class frmAltaMarca
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
            this.txbDescripcionmarca = new System.Windows.Forms.TextBox();
            this.lbIdmarcaExistente = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.dgvMarcasExistentes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcasExistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTitulo.Location = new System.Drawing.Point(21, 25);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(128, 26);
            this.lbTitulo.TabIndex = 33;
            this.lbTitulo.Text = "Registration";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(286, 115);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(61, 25);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(200, 115);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(56, 25);
            this.btnAceptar.TabIndex = 31;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txbDescripcionmarca
            // 
            this.txbDescripcionmarca.Location = new System.Drawing.Point(200, 72);
            this.txbDescripcionmarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbDescripcionmarca.Name = "txbDescripcionmarca";
            this.txbDescripcionmarca.Size = new System.Drawing.Size(150, 20);
            this.txbDescripcionmarca.TabIndex = 18;
            this.txbDescripcionmarca.Tag = "";
            // 
            // lbIdmarcaExistente
            // 
            this.lbIdmarcaExistente.AutoSize = true;
            this.lbIdmarcaExistente.Location = new System.Drawing.Point(436, 36);
            this.lbIdmarcaExistente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdmarcaExistente.Name = "lbIdmarcaExistente";
            this.lbIdmarcaExistente.Size = new System.Drawing.Size(93, 13);
            this.lbIdmarcaExistente.TabIndex = 24;
            this.lbIdmarcaExistente.Text = "Marcas Existentes";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(43, 77);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(122, 13);
            this.lblDescripcion.TabIndex = 17;
            this.lblDescripcion.Text = "Descripcion de la Marca";
            // 
            // dgvMarcasExistentes
            // 
            this.dgvMarcasExistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarcasExistentes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMarcasExistentes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvMarcasExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcasExistentes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcasExistentes.Location = new System.Drawing.Point(394, 61);
            this.dgvMarcasExistentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMarcasExistentes.MultiSelect = false;
            this.dgvMarcasExistentes.Name = "dgvMarcasExistentes";
            this.dgvMarcasExistentes.RowHeadersWidth = 4;
            this.dgvMarcasExistentes.RowTemplate.Height = 24;
            this.dgvMarcasExistentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcasExistentes.Size = new System.Drawing.Size(170, 169);
            this.dgvMarcasExistentes.TabIndex = 34;
            this.dgvMarcasExistentes.SelectionChanged += new System.EventHandler(this.dgvMarcasExistentes_SelectionChanged);
            // 
            // frmAltaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 270);
            this.Controls.Add(this.dgvMarcasExistentes);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txbDescripcionmarca);
            this.Controls.Add(this.lbIdmarcaExistente);
            this.Controls.Add(this.lblDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altas de Marcas";
            this.Load += new System.EventHandler(this.frmAltaMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcasExistentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txbDescripcionmarca;
        private System.Windows.Forms.Label lbIdmarcaExistente;
        private System.Windows.Forms.Label lblDescripcion;
        public System.Windows.Forms.DataGridView dgvMarcasExistentes;
    }
}