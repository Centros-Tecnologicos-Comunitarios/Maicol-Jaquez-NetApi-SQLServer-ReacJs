using GestionEmpresarial.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionEmpresarial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {

        private readonly GestionPersonalContext _context;
        public EmpleadoController(GestionPersonalContext context)
        {
            _context = context;
        }
        // GET: api/<EmpleadoController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.Empleados.ToList());

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<EmpleadoController>/5
        [HttpGet("{id}", Name = "GetEmpleado")]
        public ActionResult Get(int id)
        {
            try
            {
                var empleadoid = _context.Empleados.FirstOrDefault(c => c.Id == id);
                return Ok(empleadoid);

            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<EmpleadoController>
        [HttpPost]
        public ActionResult Post([FromBody] Empleado empleado)
        {
            try
            {
                if(empleado.Id != null)
                {
                    _context.Empleados.Add(empleado);
                    _context.SaveChanges();
                    return CreatedAtRoute("GetEmpleado", new { id = empleado }, empleado);
                } else
                {
                    return BadRequest();
                }

                


            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Empleado empleado)
        {
            try
            {
                if( empleado.Id == id)
                {
                    _context.Entry(empleado).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetEmpleado", new { id = empleado }, empleado);

                } else
                {
                    return BadRequest();
                }

            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<EmpleadoController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var empleadoid = _context.Empleados.FirstOrDefault(c => c.Id == id);

                if(empleadoid != null)
                {
                    _context.Remove(empleadoid);
                    _context.SaveChanges();
                    return CreatedAtRoute("GetEmpleado", new { id = empleadoid }, empleadoid);
                } else
                {
                    return BadRequest();
                }

            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
