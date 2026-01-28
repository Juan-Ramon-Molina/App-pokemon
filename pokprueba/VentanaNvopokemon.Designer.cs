namespace pokprueba
{
    partial class VentanaNvopokemon
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
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblDebilidad = new System.Windows.Forms.Label();
            this.BtnCarga = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CbxDebilidad = new System.Windows.Forms.ComboBox();
            this.CbxTipo = new System.Windows.Forms.ComboBox();
            this.TbxNumero = new System.Windows.Forms.TextBox();
            this.TbxNombre = new System.Windows.Forms.TextBox();
            this.TbxDescripcion = new System.Windows.Forms.TextBox();
            this.lblurlimagen = new System.Windows.Forms.Label();
            this.tbxUrlImagen = new System.Windows.Forms.TextBox();
            this.PBoxPokemon = new System.Windows.Forms.PictureBox();
            this.BttnAgregarImagenPc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(69, 236);
            this.LblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(80, 24);
            this.LblNumero.TabIndex = 0;
            this.LblNumero.Text = "Numero";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(69, 289);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(80, 24);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(72, 395);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(109, 24);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Text = "Descripcion";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(72, 443);
            this.LblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(48, 24);
            this.LblTipo.TabIndex = 3;
            this.LblTipo.Text = "Tipo";
            // 
            // LblDebilidad
            // 
            this.LblDebilidad.AutoSize = true;
            this.LblDebilidad.Location = new System.Drawing.Point(72, 497);
            this.LblDebilidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDebilidad.Name = "LblDebilidad";
            this.LblDebilidad.Size = new System.Drawing.Size(91, 24);
            this.LblDebilidad.TabIndex = 4;
            this.LblDebilidad.Text = "Debilidad";
            // 
            // BtnCarga
            // 
            this.BtnCarga.Location = new System.Drawing.Point(73, 553);
            this.BtnCarga.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCarga.Name = "BtnCarga";
            this.BtnCarga.Size = new System.Drawing.Size(148, 65);
            this.BtnCarga.TabIndex = 5;
            this.BtnCarga.Text = "Cargar";
            this.BtnCarga.UseVisualStyleBackColor = true;
            this.BtnCarga.Click += new System.EventHandler(this.BtnCarga_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(245, 552);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(149, 66);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CbxDebilidad
            // 
            this.CbxDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDebilidad.FormattingEnabled = true;
            this.CbxDebilidad.Location = new System.Drawing.Point(229, 497);
            this.CbxDebilidad.Margin = new System.Windows.Forms.Padding(4);
            this.CbxDebilidad.Name = "CbxDebilidad";
            this.CbxDebilidad.Size = new System.Drawing.Size(165, 32);
            this.CbxDebilidad.TabIndex = 7;
            // 
            // CbxTipo
            // 
            this.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipo.FormattingEnabled = true;
            this.CbxTipo.Location = new System.Drawing.Point(229, 443);
            this.CbxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.CbxTipo.Name = "CbxTipo";
            this.CbxTipo.Size = new System.Drawing.Size(165, 32);
            this.CbxTipo.TabIndex = 8;
            // 
            // TbxNumero
            // 
            this.TbxNumero.Location = new System.Drawing.Point(226, 236);
            this.TbxNumero.Margin = new System.Windows.Forms.Padding(4);
            this.TbxNumero.Name = "TbxNumero";
            this.TbxNumero.Size = new System.Drawing.Size(168, 29);
            this.TbxNumero.TabIndex = 9;
            this.TbxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxNumero_KeyPress);
            // 
            // TbxNombre
            // 
            this.TbxNombre.Location = new System.Drawing.Point(229, 289);
            this.TbxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.Size = new System.Drawing.Size(165, 29);
            this.TbxNombre.TabIndex = 10;
            // 
            // TbxDescripcion
            // 
            this.TbxDescripcion.Location = new System.Drawing.Point(229, 395);
            this.TbxDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TbxDescripcion.Name = "TbxDescripcion";
            this.TbxDescripcion.Size = new System.Drawing.Size(165, 29);
            this.TbxDescripcion.TabIndex = 11;
            // 
            // lblurlimagen
            // 
            this.lblurlimagen.AutoSize = true;
            this.lblurlimagen.Location = new System.Drawing.Point(73, 339);
            this.lblurlimagen.Name = "lblurlimagen";
            this.lblurlimagen.Size = new System.Drawing.Size(119, 24);
            this.lblurlimagen.TabIndex = 12;
            this.lblurlimagen.Text = "Url (Imagen)";
            // 
            // tbxUrlImagen
            // 
            this.tbxUrlImagen.Location = new System.Drawing.Point(229, 340);
            this.tbxUrlImagen.Name = "tbxUrlImagen";
            this.tbxUrlImagen.Size = new System.Drawing.Size(165, 29);
            this.tbxUrlImagen.TabIndex = 13;
            this.tbxUrlImagen.Leave += new System.EventHandler(this.tbxUrlImagen_Leave);
            // 
            // PBoxPokemon
            // 
            this.PBoxPokemon.Location = new System.Drawing.Point(73, 34);
            this.PBoxPokemon.Name = "PBoxPokemon";
            this.PBoxPokemon.Size = new System.Drawing.Size(321, 173);
            this.PBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxPokemon.TabIndex = 14;
            this.PBoxPokemon.TabStop = false;
            // 
            // BttnAgregarImagenPc
            // 
            this.BttnAgregarImagenPc.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnAgregarImagenPc.Location = new System.Drawing.Point(400, 340);
            this.BttnAgregarImagenPc.Name = "BttnAgregarImagenPc";
            this.BttnAgregarImagenPc.Size = new System.Drawing.Size(131, 29);
            this.BttnAgregarImagenPc.TabIndex = 15;
            this.BttnAgregarImagenPc.Text = "Examinar";
            this.BttnAgregarImagenPc.UseVisualStyleBackColor = true;
            this.BttnAgregarImagenPc.Click += new System.EventHandler(this.BttnAgregarImagenPc_Click);
            // 
            // VentanaNvopokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(543, 675);
            this.Controls.Add(this.BttnAgregarImagenPc);
            this.Controls.Add(this.PBoxPokemon);
            this.Controls.Add(this.tbxUrlImagen);
            this.Controls.Add(this.lblurlimagen);
            this.Controls.Add(this.TbxDescripcion);
            this.Controls.Add(this.TbxNombre);
            this.Controls.Add(this.TbxNumero);
            this.Controls.Add(this.CbxTipo);
            this.Controls.Add(this.CbxDebilidad);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCarga);
            this.Controls.Add(this.LblDebilidad);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblNumero);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaNvopokemon";
            this.Text = "Originar pokemon";
            this.Load += new System.EventHandler(this.VentanaNvopokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblDebilidad;
        private System.Windows.Forms.Button BtnCarga;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CbxDebilidad;
        private System.Windows.Forms.ComboBox CbxTipo;
        private System.Windows.Forms.TextBox TbxNumero;
        private System.Windows.Forms.TextBox TbxNombre;
        private System.Windows.Forms.TextBox TbxDescripcion;
        private System.Windows.Forms.Label lblurlimagen;
        private System.Windows.Forms.TextBox tbxUrlImagen;
        private System.Windows.Forms.PictureBox PBoxPokemon;
        private System.Windows.Forms.Button BttnAgregarImagenPc;
    }
}