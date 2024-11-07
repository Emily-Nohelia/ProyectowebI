using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiModells;

namespace WebApiService
{
    public class Categoria
    {
        private readonly CategoriaDAL _categoriaDAL;

        public CategoriaService(IConfiguration configuration)
        {
            _categoriaDAL = new CategoriaDAL(configuration);
        }

        public List<Categoria> ObtenerCategorias()
        {
            return _categoriaDAL.ListarCategorias();
        }

        public bool AgregarCategoria(Categoria categoria)
        {
            return _categoriaDAL.InsertarCategoria(categoria);
        }

        public bool ActualizarCategoria(Categoria categoria)
        {
            return _categoriaDAL.ActualizarCategoria(categoria);
        }

        public bool EliminarCategoria(int idCategoria)
        {
            return _categoriaDAL.EliminarCategoria(idCategoria);
        }
    }
}

