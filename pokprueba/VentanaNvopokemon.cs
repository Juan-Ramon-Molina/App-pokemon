using dominio;
using servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace pokprueba
{
    public partial class VentanaNvopokemon : Form
    {
        private Pokemon Pokemon=null;
        private OpenFileDialog archivo;
        private ErrorProvider errorProv1;

        public VentanaNvopokemon()
        {
            InitializeComponent();
            errorProv1 = new ErrorProvider();
            errorProv1.ContainerControl = this;
        }
        public VentanaNvopokemon(Pokemon Pokemon)
        {
            InitializeComponent();
            this.Pokemon= Pokemon;
            Text = "Modificar pokemon";
            errorProv1 = new ErrorProvider();
            errorProv1.ContainerControl = this;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCarga_Click(object sender, EventArgs e)
        {
            PokemonServicio data=new PokemonServicio();

            try
            {
                errorProv1.Clear();
                if (Pokemon == null)
                {
                    Pokemon = new Pokemon();
                }

                if (!int.TryParse(TbxNumero.Text, out int numero)) 
                {
                    errorProv1.SetError(TbxNumero,"Ingrese numero");
                    return;
                }
                Pokemon.numero= numero;
                Pokemon.nombre = TbxNombre.Text;
                Pokemon.descripcion = TbxDescripcion.Text;
                Pokemon.tipo = (Elemento)CbxTipo.SelectedItem;
                Pokemon.debilidad = (Elemento)CbxDebilidad.SelectedItem;
                Pokemon.imagen = tbxUrlImagen.Text;

                //FluentValidacion
                PokemonValidation validacion = new PokemonValidation();
                var resultado = validacion.Validate(Pokemon);
                errorProv1.Clear();
                if (!resultado.IsValid)
                {
                    foreach (var error in resultado.Errors)
                    {
                        switch (error.PropertyName)
                        {
                            case "numero":
                                errorProv1.SetError(TbxNumero, error.ErrorMessage);
                                break;
                            case "nombre":
                                errorProv1.SetError(TbxNombre, error.ErrorMessage);
                                break;
                            case "descripcion":
                                errorProv1.SetError(TbxDescripcion, error.ErrorMessage);
                                break;
                        }
                    }
                }
                else
                {
                    if (Pokemon.id == 0)
                    {
                        data.CrearPokemon(Pokemon);
                        MessageBox.Show("Pokemon capturado");
                        
                    }
                    else
                    {
                        data.ModificarPokemon(Pokemon);
                        MessageBox.Show("Pokemon modificado");
                        
                    }
                    //Guardar imagen examinada de pc en carpeta y guardar ruta.
                    if (archivo != null && !(archivo.FileName.StartsWith("http", StringComparison.OrdinalIgnoreCase)))
                    {
                        string nombrearchivo = Guid.NewGuid().ToString() + Path.GetExtension(archivo.FileName);
                        string destino = Path.Combine(ConfigurationManager.AppSettings["folder_imagen_pokemon"], nombrearchivo);
                        File.Copy(archivo.FileName, destino);
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

               
        
        private void VentanaNvopokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementdata=new ElementoNegocio();
            try
            {

                CbxTipo.DataSource=elementdata.ListarElementos();
                CbxTipo.ValueMember="id";
                CbxTipo.DisplayMember = "descripcion";
                CbxDebilidad.DataSource = elementdata.ListarElementos();
                CbxDebilidad.ValueMember="id";
                CbxDebilidad.DisplayMember = "descripcion";

                if (Pokemon != null)
                {
                    TbxNumero.Text=Pokemon.numero.ToString();
                    TbxNombre.Text = Pokemon.nombre;
                    TbxDescripcion.Text = Pokemon.descripcion;
                    tbxUrlImagen.Text = Pokemon.imagen;
                    Herramienta.CargarUrl(PBoxPokemon,tbxUrlImagen.Text);
                    CbxTipo.SelectedValue = Pokemon.tipo.id;
                    CbxDebilidad.SelectedValue = Pokemon.debilidad.id;
                }

            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void tbxUrlImagen_Leave(object sender, EventArgs e)
        {
            Herramienta.CargarUrl(PBoxPokemon, tbxUrlImagen.Text);
        }

        private void BttnAgregarImagenPc_Click(object sender, EventArgs e)
        {
            //Examinar documentos.
            archivo=new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg";
            if(archivo.ShowDialog()==DialogResult.OK)
            {
                tbxUrlImagen.Text = archivo.FileName;
                Herramienta.CargarUrl(PBoxPokemon,archivo.FileName);
            }
        }

        private void TbxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProv1.SetError(TbxNumero, "Solo numeros");
            }
            else
            {
                errorProv1.SetError(TbxNumero, "");
            }
        }
    }
}
