using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entites;
using Modelo.Modelos;
using Datos;

namespace Negocio
{
    public class ConductorNegocio
    {
        ConductorDatos conductorDatos = new ConductorDatos();
        public List<ConductorModel> getAllConductor()
        {
            return conductorDatos.getAllConductor();
        }
        public void createConductor(ConductorModel conductorModel)
        {
            conductorDatos.createConductor(conductorModel);
        }
        public Conductor findByID(int id)
        {
            return conductorDatos.findByID(id);
        }
        public void updateConductor(ConductorModel conductorModel)
        {
            conductorDatos.updateConductor(conductorModel);
        }
        public void deleteConductor(int id)
        {
            conductorDatos.deleteConductor(id);
        }
    }
}
