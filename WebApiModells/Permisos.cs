using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiModells
{
    internal class Permisos
    {
       public int IdPermiso {  get; set; }  
       public string NombrePermiso { get; set; }
       public string DescripcionPermiso { get; set; }
       public bool Estado {  get; set; }


    }
}
