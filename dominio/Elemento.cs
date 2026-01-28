using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    //Clase que surge como compocision de la clase pokemon. El pokemon tiene elemento.
    public class Elemento
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        //Sobreescritura del metodo tostring, devuelve el atributo descripcion. 
        //Caso de no existir, el dataGraidviw no lo leeria. Solo leeria el objeto.
        public override string ToString()
        {
            return descripcion;
        }
    }
}
