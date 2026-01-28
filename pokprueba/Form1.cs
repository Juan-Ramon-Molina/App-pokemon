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
{   //ventana hereda de form.
    public partial class Ventana1 : Form
    {
        ErrorProvider ErrorProvider1 = new ErrorProvider();
        public Ventana1()
        {
            InitializeComponent();
            ErrorProvider1.ContainerControl = this;
        }
        //lista de pokemon para almacenar los objetos que se obtengan del metodo listar. propiedad privada.
        //para utilizar en varios eventos.
        private List<Pokemon> Listapokemon;
        private void Ventana1_Load(object sender, EventArgs e)
        {
            //Metodo que carga el dataGV.
            CargarDGV();
            CbxCampo.Items.Add("Numero");
            CbxCampo.Items.Add("Nombre");
            CbxCampo.Items.Add("Descripcion");
            CbxCampo.SelectedItem=CbxCampo.Items[0];
            CbxCriterio.SelectedItem = CbxCriterio.Items[0];
            Herramienta.BloqueoBotonesSinSeleccionado(dgvPokemon, btneliminar, btninactivar, btnmodificar);
        }
        //Metodo para simplificar codigo.
        private void CargarDGV()
        {
            //Crear instancia de servicios para llamar el metodo.
            PokemonServicio pok = new PokemonServicio();
            try
            {
                //almacena.
                Listapokemon = pok.Listar();
                //Vuelca en el data.
                dgvPokemon.DataSource = Listapokemon;
                Herramienta.OcultarColumna(dgvPokemon, "imagen");
                Herramienta.OcultarColumna(dgvPokemon, "Id");
                Herramienta.CargarUrl(picboxpoke, Listapokemon[0].imagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            //Cambia la imagen segun la fila seleccionada.
            //instancia del elemento seleccionado.
            Herramienta.BloqueoBotonesSinSeleccionado(dgvPokemon,btnmodificar,btninactivar,btneliminar);
            if(dgvPokemon.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
                Herramienta.CargarUrl(picboxpoke, seleccionado.imagen);
            }
            
        }

        //Ventana de elementos.
        private void elementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaelementos ventanaelementos = new ventanaelementos();
            ventanaelementos.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaNvopokemon nvopokemon = new VentanaNvopokemon();
            nvopokemon.ShowDialog();
            //Al cerrarce la ventana, refresca la lista.
            CargarDGV();

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;

            VentanaNvopokemon modificar = new VentanaNvopokemon(seleccionado);
            modificar.ShowDialog();
            CargarDGV();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarpokemon();
        }


        private void inactivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarpokemon(true);
        }
        private void borrarpokemon(bool BdLogica = false)
        {
            PokemonServicio data = new PokemonServicio();
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminarlo?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {
                try
                {
                    Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
                    if (BdLogica)
                    {
                        data.EliminacionLogica(seleccionado);
                        MessageBox.Show("Pokemon congelado");
                        CargarDGV();
                    }
                    else
                    {
                        data.EliminacionFisica(seleccionado);
                        MessageBox.Show("Su pokemon ha muerto");
                        CargarDGV();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void congeladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaInactivos inactivos = new VentanaInactivos();
            inactivos.ShowDialog();
            CargarDGV();
        }

        private void tbxBusquedaRapida_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listafiltrada;
            string filtro=tbxBusquedaRapida.Text;
            if (filtro.Length>2)
            {
                listafiltrada = Listapokemon.FindAll(x => x.nombre.ToUpper().Contains(filtro.ToUpper()) || x.tipo.descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listafiltrada = Listapokemon;
            }
            dgvPokemon.DataSource = null;
            dgvPokemon.DataSource = listafiltrada;
            Herramienta.OcultarColumna(dgvPokemon, "imagen");
            Herramienta.OcultarColumna(dgvPokemon, "id");
        }

        private void CbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion=CbxCampo.SelectedItem.ToString();
            
            switch (opcion)
            {
                case "Numero":
                    CbxCriterio.Items.Clear();
                    CbxCriterio.Items.Add("Mayores a:");
                    CbxCriterio.Items.Add("Menores a:");
                    CbxCriterio.Items.Add("Iguales a:");                    
                    break;
                case "Nombre":
                case "Descripcion":
                    CbxCriterio.Items.Clear();
                    CbxCriterio.Items.Add("Empieza con:");
                    CbxCriterio.Items.Add("Termina con:");
                    CbxCriterio.Items.Add("Contiene:");
                    break;
            }
            
            
        }

        private bool validarFiltro()
        {
            ErrorProvider1.Clear();
            bool hayerror = false;

            if (CbxCampo.SelectedIndex < 0)
            {
                ErrorProvider1.SetError(CbxCampo, "Seleccione campo");
                hayerror = true;
            }
            if (CbxCriterio.SelectedIndex < 0)
            {
                ErrorProvider1.SetError(CbxCriterio, "Seleccione criterio");
                hayerror=true;
            }
            if (string.IsNullOrWhiteSpace(TbxFiltro.Text))
            {
                ErrorProvider1.SetError(TbxFiltro, "Complete");
                hayerror = true;
            }
            else
            {
                string campo = CbxCampo.SelectedItem.ToString();

                switch (campo)
                {
                    case "Numero":
                        {
                            if (!TbxFiltro.Text.All(char.IsDigit))
                            {
                                ErrorProvider1.SetError(TbxFiltro, "Solo numeros");
                                hayerror = true;
                            }
                            break;
                        }
                }
            }
            
            


                return hayerror;
        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            PokemonServicio data=new PokemonServicio();
            try
            {
                if (validarFiltro())
                {
                    return;
                }
                string campo = CbxCampo.SelectedItem.ToString();
                string criterio = CbxCriterio.SelectedItem.ToString();
                string filtro = TbxFiltro.Text;
               
                dgvPokemon.DataSource = data.BusquedaAvanzada(campo, criterio, filtro);
                Herramienta.BloqueoBotonesSinSeleccionado(dgvPokemon, btneliminar, btninactivar, btnmodificar);
                
          
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        private void TbxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrorProvider1.Clear();
            if(CbxCampo.SelectedItem.ToString() == "Numero" && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                ErrorProvider1.SetError(TbxFiltro, "Solo numeros");
            }
            else
            {
                ErrorProvider1.SetError(TbxFiltro, "");
            }
        }

        private void BtnRecarga_Click(object sender, EventArgs e)
        {
            CargarDGV();
        }
    }
}
