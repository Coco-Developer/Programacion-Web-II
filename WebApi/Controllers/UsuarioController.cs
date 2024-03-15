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
    public class UsuarioController : ControllerBase
    {
 
            private static List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario(1, new DateTime(1990, 1, 1), 31, "John", "Doe"),
            new Usuario(2, new DateTime(1985, 5, 15), 36, "Jane", "Smith"),
            new Usuario(3, new DateTime(2000, 10, 20), 21, "Alice", "Johnson")
        };

            // GET: api/Usuario
            [HttpGet]
            public ActionResult<IEnumerable<Usuario>> Get()
            {
                return Ok(usuarios);
            }

            // GET: api/Usuario/5
            [HttpGet("{id}")]
            public ActionResult<Usuario> Get(int id)
            {
                var usuario = usuarios.Find(u => u.Id == id);
                if (usuario == null)
                {
                    return NotFound();
                }
                return Ok(usuario);
            }

            // POST: api/Usuario
            [HttpPost]
            public ActionResult<Usuario> Post([FromBody] Usuario nuevoUsuario)
            {
                usuarios.Add(nuevoUsuario);
                return CreatedAtAction(nameof(Get), new { id = nuevoUsuario.Id }, nuevoUsuario);
            }

            // PUT: api/Usuario/5
            [HttpPut("{id}")]
            public IActionResult Put(int id, [FromBody] Usuario usuarioActualizado)
            {
                var index = usuarios.FindIndex(u => u.Id == id);
                if (index == -1)
                {
                    return NotFound();
                }
                usuarios[index] = usuarioActualizado;
                return NoContent();
            }

            // DELETE: api/Usuario/5
            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                var usuario = usuarios.Find(u => u.Id == id);
                if (usuario == null)
                {
                    return NotFound();
                }
                usuarios.Remove(usuario);
                return NoContent();
            }
     }



    
}
