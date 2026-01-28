using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using servicios;

namespace pokprueba
{
    public partial class VentanaInactivos : Form
    {
        public VentanaInactivos()
        {
            InitializeComponent();
        }
        
        List<Pokemon> congelados = new List<Pokemon>();
        PokemonServicio datapokemon=new PokemonServicio();
        private void Inactivos_Load(object sender, EventArgs e)
        {
            
            try
            {
                CargarDGV();
                DgvCongelados.Columns["imagen"].Visible=false;
                Herramienta.CargarUrl(PbxCongelado, congelados[0].imagen);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DgvCongelados_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)DgvCongelados.CurrentRow.DataBoundItem;
            Herramienta.CargarUrl(PbxCongelado, seleccionado.imagen);
        }

        private void BtnDesvivir_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)DgvCongelados.CurrentRow.DataBoundItem;
            try
            {
                DialogResult respuesta= MessageBox.Show("Desea eliminarlo", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (respuesta==DialogResult.OK)
                {
                    datapokemon.EliminacionFisica(seleccionado);
                    MessageBox.Show("Su pokemon ha muerto");
                    CargarDGV();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public void CargarDGV()
        {
            congelados = datapokemon.ListarInactivos();
            DgvCongelados.DataSource = congelados;
        }

        private void BtnDescongelar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)DgvCongelados.CurrentRow.DataBoundItem;
            try
            {
                DialogResult respuesta=MessageBox.Show("Quiere descongelarlo?", "Descongelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.OK) 
                {
                    datapokemon.Activacion(seleccionado.id);
                    MessageBox.Show("Pokemon descongelado");
                    CargarDGV();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
