using dominio;
using servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokprueba
{
    public partial class ventanaelementos : Form
    {
        public ventanaelementos()
        {
            InitializeComponent();
        }
        List<Elemento> elementos = new List<Elemento>();
        private void ventanaelementos_Load(object sender, EventArgs e)
        {
            ElementoNegocio data= new ElementoNegocio();
            elementos = data.ListarElementos();
            dgvelementos.DataSource= elementos;
        }
    }
}
