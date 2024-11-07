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
    public class ProductosController : ControllerBase
    {
                    
            private readonly ProductoService _productoService = new ProductoService();

            // GET: api/producto
            [HttpGet]
            public ActionResult<List<Producto>> GetProductos()
            {
                var productos = _productoService.ObtenerProductos();
                return Ok(productos);
            }

            // GET: api/producto/5
            [HttpGet("{id}")]
            public ActionResult<Producto> GetProducto(int id)
            {
                var producto = _productoService.ObtenerProductos().Find(p => p.ID_Producto == id);

                if (producto == null)
                {
                    return NotFound();
                }

                return Ok(producto);
            }

            // POST: api/producto
            [HttpPost]
            public ActionResult<int> PostProducto(Producto producto)
            {
                var idProducto = _productoService.AgregarProducto(producto);
                return CreatedAtAction(nameof(GetProducto), new { id = idProducto }, producto);
            }

            // PUT: api/producto/5
            [HttpPut("{id}")]
            public IActionResult PutProducto(int id, Producto producto)
            {
                if (id != producto.ID_Producto)
                {
                    return BadRequest();
                }

                var result = _productoService.ActualizarProducto(producto);
                if (!result)
                {
                    return NotFound();
                }

                return NoContent();
            }

            // DELETE: api/producto/5
            [HttpDelete("{id}")]
            public IActionResult DeleteProducto(int id)
            {
                var result = _productoService.EliminarProducto(id);
                if (!result)
                {
                    return NotFound();
                }

                return NoContent();
            }
        
    }
}
