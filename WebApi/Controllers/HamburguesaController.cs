using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProgramacionWebII_Actividad_Complementaria_CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HamburguesaController : ControllerBase
    {

          private static List<Hamburguesa> hamburguesas = new ()
        {
            new Hamburguesa(1, "Hamburguesa Clásica", 100, "Una hamburguesa simple con carne, lechuga y tomate"),
            new Hamburguesa(2, "Hamburguesa Doble", 150, "Una hamburguesa doble con carne, queso, lechuga y tomate"),
            new Hamburguesa(3, "Hamburguesa Vegetariana", 120, "Una hamburguesa vegetariana con una patty de garbanzos y vegetales")
        };

            // GET: api/Hamburguesa
            [HttpGet]
            public ActionResult<IEnumerable<Hamburguesa>> Get()
            {
                return Ok(hamburguesas);
            }

            // GET: api/Hamburguesa/5
            [HttpGet("{id}")]
            public ActionResult<Hamburguesa> Get(int id)
            {
                var hamburguesa = hamburguesas.Find(h => h.Id == id);
                if (hamburguesa == null)
                {
                    return NotFound();
                }
                return Ok(hamburguesa);
            }

            // POST: api/Hamburguesa
            [HttpPost]
            public ActionResult<Hamburguesa> Post([FromBody] Hamburguesa nuevaHamburguesa)
            {
                hamburguesas.Add(nuevaHamburguesa);
                return CreatedAtAction(nameof(Get), new { id = nuevaHamburguesa.Id }, nuevaHamburguesa);
            }

            // PUT: api/Hamburguesa/5
            [HttpPut("{id}")]
            public IActionResult Put(int id, [FromBody] Hamburguesa hamburguesaActualizada)
            {
                var index = hamburguesas.FindIndex(h => h.Id == id);
                if (index == -1)
                {
                    return NotFound();
                }
                hamburguesas[index] = hamburguesaActualizada;
                return NoContent();
            }

            // DELETE: api/Hamburguesa/5
            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                var hamburguesa = hamburguesas.Find(h => h.Id == id);
                if (hamburguesa == null)
                {
                    return NotFound();
                }
                hamburguesas.Remove(hamburguesa);
                return NoContent();
            }
        
    }
}
