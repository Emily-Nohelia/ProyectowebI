using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiModells;

namespace WebApiInterface
{
    public interface ICategoria
    {
        public List<Categoria> GetAll();
        public Categoria GetById(int ID);
        public Categoria Update(Categoria categoria);
        public void Add(Categoria categoria);
        public void Delete(int id);

    }
}
