using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiModells;

namespace WebApiInterface
{
    public interface IRolesService
    {
        public  List<Roles> GetAll();
        public Roles GetById(int Id);
        public Roles Update(Roles roles);
        public void Add(Roles roles);
        public void Delete(int Id);

    }
}
