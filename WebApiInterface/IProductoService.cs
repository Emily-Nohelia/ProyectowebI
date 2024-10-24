using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiModells;

namespace WebApiInterface
{
    public interface IProductoService
    {
        public List<Producto> GetAll();
        public Producto GetById(int ID);
        public Producto Update(Producto producto);
        public void Add(Producto producto);
        public void Delete(int ID);


    }
}
