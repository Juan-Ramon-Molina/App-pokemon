namespace pokprueba
{
    partial class VentanaInactivos
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
            this.PbxCongelado = new System.Windows.Forms.PictureBox();
            this.BtnDescongelar = new System.Windows.Forms.Button();
            this.BtnDesvivir = new System.Windows.Forms.Button();
            this.DgvCongelados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCongelado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCongelados)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxCongelado
            // 
            this.PbxCongelado.Location = new System.Drawing.Point(72, 54);
            this.PbxCongelado.Name = "PbxCongelado";
            this.PbxCongelado.Size = new System.Drawing.Size(243, 188);
            this.PbxCongelado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCongelado.TabIndex = 0;
            this.PbxCongelado.TabStop = false;
            // 
            // BtnDescongelar
            // 
            this.BtnDescongelar.Location = new System.Drawing.Point(368, 54);
            this.BtnDescongelar.Name = "BtnDescongelar";
            this.BtnDescongelar.Size = new System.Drawing.Size(184, 45);
            this.BtnDescongelar.TabIndex = 1;
            this.BtnDescongelar.Text = "Descongelar";
            this.BtnDescongelar.UseVisualStyleBackColor = true;
            this.BtnDescongelar.Click += new System.EventHandler(this.BtnDescongelar_Click);
            // 
            // BtnDesvivir
            // 
            this.BtnDesvivir.Location = new System.Drawing.Point(368, 197);
            this.BtnDesvivir.Name = "BtnDesvivir";
            this.BtnDesvivir.Size = new System.Drawing.Size(184, 45);
            this.BtnDesvivir.TabIndex = 2;
            this.BtnDesvivir.Text = "Desvivir";
            this.BtnDesvivir.UseVisualStyleBackColor = true;
            this.BtnDesvivir.Click += new System.EventHandler(this.BtnDesvivir_Click);
            // 
            // DgvCongelados
            // 
            this.DgvCongelados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvCongelados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvCongelados.BackgroundColor = System.Drawing.Color.Red;
            this.DgvCongelados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCongelados.ColumnHeadersHeight = 29;
            this.DgvCongelados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvCongelados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvCongelados.Location = new System.Drawing.Point(72, 296);
            this.DgvCongelados.MultiSelect = false;
            this.DgvCongelados.Name = "DgvCongelados";
            this.DgvCongelados.RowHeadersWidth = 51;
            this.DgvCongelados.RowTemplate.Height = 24;
            this.DgvCongelados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCongelados.Size = new System.Drawing.Size(880, 150);
            this.DgvCongelados.TabIndex = 3;
            this.DgvCongelados.SelectionChanged += new System.EventHandler(this.DgvCongelados_SelectionChanged);
            // 
            // VentanaInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1018, 478);
            this.Controls.Add(this.DgvCongelados);
            this.Controls.Add(this.BtnDesvivir);
            this.Controls.Add(this.BtnDescongelar);
            this.Controls.Add(this.PbxCongelado);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentanaInactivos";
            this.Text = "Inactivos";
            this.Load += new System.EventHandler(this.Inactivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxCongelado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCongelados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxCongelado;
        private System.Windows.Forms.Button BtnDescongelar;
        private System.Windows.Forms.Button BtnDesvivir;
        private System.Windows.Forms.DataGridView DgvCongelados;
    }
}