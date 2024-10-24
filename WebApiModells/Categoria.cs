using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebApiModells
{
    public class Categoria
    {
       public int  ID_Categoria {  get; set; }
       public string Nombre {  get; set; }
       public string Descripcion {  get; set; }
       public bool Estado {  get; set; }

    }
}
