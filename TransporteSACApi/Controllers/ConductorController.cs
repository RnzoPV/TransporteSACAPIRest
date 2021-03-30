using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Cors;
using System.Web.Http;
using Modelo.Entites;
using Modelo.Modelos;
using Negocio;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace TransporteSACApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ConductorController : ApiController
    {
        ConductorNegocio conductorNegocio = new ConductorNegocio();
        public IEnumerable<ConductorModel> Get()
        {
            try
            {
                return conductorNegocio.getAllConductor();
            }
            catch (Exception e)
            {

                throw new Exception(e.ToString());
            }
        }
        
        public IHttpActionResult PostConductor([FromBody] ConductorModel conductorModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                conductorNegocio.createConductor(conductorModel);
                //return CreatedAtRoute("DefaultApi", new { id = conductorModel.Id }, conductorModel);
                return Ok("exito");
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
        }
        public IHttpActionResult PutConductor(int id, [FromBody] ConductorModel conductorModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != conductorModel.Id)
            {
                return BadRequest();
            }
            try
            {
                conductorNegocio.updateConductor(conductorModel);
            }
            catch (DbUpdateConcurrencyException e)
            {
                if (conductorNegocio.findByID(id) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw new Exception(e.ToString());
                }
            }
            return Ok("exito");
        }

        public IHttpActionResult DeleteConductor(int id)
        {
            Conductor conductorE = conductorNegocio.findByID(id);
            if(conductorE == null)
            {
                return NotFound();
            }
            conductorNegocio.deleteConductor(id);
            return Ok("Exito");
        }
    }
}
