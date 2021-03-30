using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entites;
using Modelo.Modelos;


namespace Datos.Utils
{
    public static class Converter
    {
        public static ConductorModel entity2model(Conductor conductorEntity)
        {
            ConductorModel conductorModel = new ConductorModel();
            conductorModel.Id = conductorEntity.id;
            conductorModel.Nombre = conductorEntity.nombre;
            conductorModel.ape_pat = conductorEntity.ape_pat;
            conductorModel.ape_mat = conductorEntity.ape_mat;
            conductorModel.Telefono = conductorEntity.telefono;
            return conductorModel;
        }
        public static Conductor model2enity(ConductorModel conductorModel)
        {
            Conductor conductorEntity = new Conductor();
            conductorEntity.id = conductorModel.Id;
            conductorEntity.nombre = conductorModel.Nombre;
            conductorEntity.ape_pat = conductorModel.ape_pat;
            conductorEntity.ape_mat = conductorModel.ape_mat;
            conductorEntity.telefono = conductorModel.Telefono;
            return conductorEntity;
        }
    }
}
