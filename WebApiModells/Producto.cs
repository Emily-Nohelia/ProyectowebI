using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApiModells
{
    internal class Producto
    {
       public int Categoria {  get; set; }
       public string Nombre { get; set; }
       public string Descripcion {  get; set; }
       public bool Estado { get; set; }


    }
}
