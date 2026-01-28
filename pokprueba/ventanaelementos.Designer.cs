namespace pokprueba
{
    partial class ventanaelementos
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
            this.dgvelementos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvelementos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvelementos
            // 
            this.dgvelementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvelementos.Location = new System.Drawing.Point(76, 72);
            this.dgvelementos.Name = "dgvelementos";
            this.dgvelementos.RowHeadersWidth = 51;
            this.dgvelementos.RowTemplate.Height = 24;
            this.dgvelementos.Size = new System.Drawing.Size(441, 222);
            this.dgvelementos.TabIndex = 0;
            // 
            // ventanaelementos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvelementos);
            this.Name = "ventanaelementos";
            this.Text = "Elementos";
            this.Load += new System.EventHandler(this.ventanaelementos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvelementos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvelementos;
    }
}