using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokprueba
{
	//Clase que birnda soporte a las ventanas, brindandoles metodos para simplificar codificacion.
	//Es necesario que este en este proyecto de winform para que reciba picturbox. 
	//using system.windows.forms;
    internal class Herramienta
    {
        public static void CargarUrl(PictureBox picture,string url)
        {
			try
			{
				picture.Load(url);
			}
			catch (Exception ex)
			{
				//Imagen alternativa en caso de excepcion a la hora de cargar url o vacio.
				picture.Load("https://preview.redd.it/whos-that-pokemon-v0-junnky9wo3df1.jpeg?width=640&crop=smart&auto=webp&s=06750bb2ca565c3ec962053dd7059b24ae9f1252");
			}
        } 
		public static void OcultarColumna(DataGridView dgv, string columna)
		{
            dgv.Columns[columna].Visible = false;
        }

		public static void BloqueoBotonesSinSeleccionado(DataGridView dgv, params ToolStripItem[] botones)
		{
			bool haySeleccionado = dgv.CurrentRow?.DataBoundItem != null;
			foreach (var boton in botones)
			{
				boton.Enabled = haySeleccionado;
			}
		}
    }
}
