using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiModells;

namespace WebApiInterface
{
    public interface IUsuario
    {
        public List<Usuario> GetAll();
        public Usuario GetById(int ID);
        public Categoria Update(Usuario usuario);
        public void Add(Usuario usuario);
        public void Delete(int ID);

    }
}
