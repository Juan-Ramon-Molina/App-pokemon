namespace pokprueba
{
    partial class Ventana1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana1));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPokemon = new System.Windows.Forms.DataGridView();
            this.picboxpoke = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.capturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnmodificar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.btninactivar = new System.Windows.Forms.ToolStripMenuItem();
            this.btneliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.congeladosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxBusquedaRapida = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.LblCampo = new System.Windows.Forms.Label();
            this.LblCriterio = new System.Windows.Forms.Label();
            this.LblFiltro = new System.Windows.Forms.Label();
            this.TbxFiltro = new System.Windows.Forms.TextBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.CbxCampo = new System.Windows.Forms.ComboBox();
            this.CbxCriterio = new System.Windows.Forms.ComboBox();
            this.BtnRecarga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxpoke)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pokemon";
            // 
            // dgvPokemon
            // 
            this.dgvPokemon.BackgroundColor = System.Drawing.Color.Red;
            this.dgvPokemon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokemon.Location = new System.Drawing.Point(32, 227);
            this.dgvPokemon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPokemon.MultiSelect = false;
            this.dgvPokemon.Name = "dgvPokemon";
            this.dgvPokemon.RowHeadersWidth = 51;
            this.dgvPokemon.RowTemplate.Height = 24;
            this.dgvPokemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemon.Size = new System.Drawing.Size(572, 247);
            this.dgvPokemon.TabIndex = 1;
            this.dgvPokemon.SelectionChanged += new System.EventHandler(this.dgvPokemon_SelectionChanged);
            // 
            // picboxpoke
            // 
            this.picboxpoke.Location = new System.Drawing.Point(331, 36);
            this.picboxpoke.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picboxpoke.Name = "picboxpoke";
            this.picboxpoke.Size = new System.Drawing.Size(225, 176);
            this.picboxpoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxpoke.TabIndex = 2;
            this.picboxpoke.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStrip1.Size = new System.Drawing.Size(837, 29);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(125, 21);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturarToolStripMenuItem,
            this.elementosToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.btnmodificar});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 27);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // capturarToolStripMenuItem
            // 
            this.capturarToolStripMenuItem.Name = "capturarToolStripMenuItem";
            this.capturarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.capturarToolStripMenuItem.Text = "Capturar";
            // 
            // elementosToolStripMenuItem
            // 
            this.elementosToolStripMenuItem.Name = "elementosToolStripMenuItem";
            this.elementosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.elementosToolStripMenuItem.Text = "Elementos";
            this.elementosToolStripMenuItem.Click += new System.EventHandler(this.elementosToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(224, 26);
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btninactivar,
            this.btneliminar});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(39, 27);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // btninactivar
            // 
            this.btninactivar.Name = "btninactivar";
            this.btninactivar.Size = new System.Drawing.Size(224, 26);
            this.btninactivar.Text = "Inactivar";
            this.btninactivar.Click += new System.EventHandler(this.inactivarToolStripMenuItem_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(224, 26);
            this.btneliminar.Text = "Eliminar ";
            this.btneliminar.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.congeladosToolStripMenuItem});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(39, 27);
            this.toolStripSplitButton3.Text = "toolStripSplitButton3";
            // 
            // congeladosToolStripMenuItem
            // 
            this.congeladosToolStripMenuItem.Name = "congeladosToolStripMenuItem";
            this.congeladosToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.congeladosToolStripMenuItem.Text = "Congelados";
            this.congeladosToolStripMenuItem.Click += new System.EventHandler(this.congeladosToolStripMenuItem_Click);
            // 
            // tbxBusquedaRapida
            // 
            this.tbxBusquedaRapida.Location = new System.Drawing.Point(37, 168);
            this.tbxBusquedaRapida.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxBusquedaRapida.Name = "tbxBusquedaRapida";
            this.tbxBusquedaRapida.Size = new System.Drawing.Size(210, 27);
            this.tbxBusquedaRapida.TabIndex = 4;
            this.tbxBusquedaRapida.TextChanged += new System.EventHandler(this.tbxBusquedaRapida_TextChanged);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.Location = new System.Drawing.Point(32, 141);
            this.LblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(63, 19);
            this.LblBuscar.TabIndex = 5;
            this.LblBuscar.Text = "Buscar:";
            // 
            // LblCampo
            // 
            this.LblCampo.AutoSize = true;
            this.LblCampo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampo.Location = new System.Drawing.Point(605, 32);
            this.LblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCampo.Name = "LblCampo";
            this.LblCampo.Size = new System.Drawing.Size(67, 19);
            this.LblCampo.TabIndex = 6;
            this.LblCampo.Text = "Campo:";
            // 
            // LblCriterio
            // 
            this.LblCriterio.AutoSize = true;
            this.LblCriterio.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCriterio.Location = new System.Drawing.Point(605, 96);
            this.LblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCriterio.Name = "LblCriterio";
            this.LblCriterio.Size = new System.Drawing.Size(68, 19);
            this.LblCriterio.TabIndex = 7;
            this.LblCriterio.Text = "Criterio:";
            // 
            // LblFiltro
            // 
            this.LblFiltro.AutoSize = true;
            this.LblFiltro.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFiltro.Location = new System.Drawing.Point(605, 163);
            this.LblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFiltro.Name = "LblFiltro";
            this.LblFiltro.Size = new System.Drawing.Size(51, 19);
            this.LblFiltro.TabIndex = 8;
            this.LblFiltro.Text = "Filtro:";
            // 
            // TbxFiltro
            // 
            this.TbxFiltro.Location = new System.Drawing.Point(609, 185);
            this.TbxFiltro.Name = "TbxFiltro";
            this.TbxFiltro.Size = new System.Drawing.Size(176, 27);
            this.TbxFiltro.TabIndex = 11;
            this.TbxFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxFiltro_KeyPress);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(609, 238);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(176, 34);
            this.BtnFiltrar.TabIndex = 12;
            this.BtnFiltrar.Text = "Buscar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // CbxCampo
            // 
            this.CbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCampo.FormattingEnabled = true;
            this.CbxCampo.Location = new System.Drawing.Point(609, 54);
            this.CbxCampo.Name = "CbxCampo";
            this.CbxCampo.Size = new System.Drawing.Size(176, 27);
            this.CbxCampo.TabIndex = 13;
            this.CbxCampo.SelectedIndexChanged += new System.EventHandler(this.CbxCampo_SelectedIndexChanged);
            // 
            // CbxCriterio
            // 
            this.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCriterio.FormattingEnabled = true;
            this.CbxCriterio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CbxCriterio.Location = new System.Drawing.Point(609, 128);
            this.CbxCriterio.Name = "CbxCriterio";
            this.CbxCriterio.Size = new System.Drawing.Size(176, 27);
            this.CbxCriterio.TabIndex = 14;
            // 
            // BtnRecarga
            // 
            this.BtnRecarga.Location = new System.Drawing.Point(609, 292);
            this.BtnRecarga.Name = "BtnRecarga";
            this.BtnRecarga.Size = new System.Drawing.Size(176, 33);
            this.BtnRecarga.TabIndex = 15;
            this.BtnRecarga.Text = "Recarga";
            this.BtnRecarga.UseVisualStyleBackColor = true;
            this.BtnRecarga.Click += new System.EventHandler(this.BtnRecarga_Click);
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(837, 525);
            this.Controls.Add(this.BtnRecarga);
            this.Controls.Add(this.CbxCriterio);
            this.Controls.Add(this.CbxCampo);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.TbxFiltro);
            this.Controls.Add(this.LblFiltro);
            this.Controls.Add(this.LblCriterio);
            this.Controls.Add(this.LblCampo);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.tbxBusquedaRapida);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.picboxpoke);
            this.Controls.Add(this.dgvPokemon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Ventana1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeApp";
            this.Load += new System.EventHandler(this.Ventana1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxpoke)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPokemon;
        private System.Windows.Forms.PictureBox picboxpoke;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem capturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem elementosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnmodificar;
        private System.Windows.Forms.ToolStripMenuItem btninactivar;
        private System.Windows.Forms.ToolStripMenuItem btneliminar;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem congeladosToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxBusquedaRapida;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Label LblCampo;
        private System.Windows.Forms.Label LblCriterio;
        private System.Windows.Forms.Label LblFiltro;
        private System.Windows.Forms.TextBox TbxFiltro;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.ComboBox CbxCampo;
        private System.Windows.Forms.ComboBox CbxCriterio;
        private System.Windows.Forms.Button BtnRecarga;
    }
}

