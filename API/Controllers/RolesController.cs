using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiImplementación;

namespace WebApi.Api.Controladores
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly RolesService _rolesService;

        public RolesController(RolesService rolesService)
        {
            _rolesService = rolesService;
        }

        // GET: api/usuario
        [HttpGet]
        public ActionResult<List<Roles>> GetRoles()
        {
            var roles = _rolesService.ObtenerRoles();
            return Ok(roles);
        }

        // POST: api/usuario
        [HttpPost]
        public ActionResult<bool> PostUsuario(Roles roles)
        {
            var result = _rolesService.AgregarRoles(roles);
            return Ok(result);
        }

        // PUT: api/usuario/5
        [HttpPut("{id}")]
        public IActionResult PutRoles(int id, Roles roles)
        {
            if (id != roles.ID_Roles)
            {
                return BadRequest();
            }

            var result = _rolesService.ActualizarRoles(roles);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/usuario/5
        [HttpDelete("{id}")]
        public IActionResult DeleteRoles(int id)
        {
            var result = _rolesService.EliminarRoles(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
