using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Modelo.Entites;
using Modelo.Modelos;
using Datos.Utils;
namespace Datos
{
    public class ConductorDatos
    {
        public List<ConductorModel> getAllConductor()
        {
            List<Conductor> conductors;
            List<ConductorModel> conductorModels = new List<ConductorModel>();
            using (TransporteSACDBEntities db = new TransporteSACDBEntities())
            {
                conductors = db.Conductor.ToList();
            }
            foreach (Conductor conductorE in conductors)
            {
                ConductorModel conductorM = Converter.entity2model(conductorE);
                conductorModels.Add(conductorM);
            }
            return conductorModels;
        }
        public void createConductor(ConductorModel conductorModel)
        {
            using (TransporteSACDBEntities db = new TransporteSACDBEntities())
            {
                db.Conductor.Add(Converter.model2enity(conductorModel));
                db.SaveChanges();
            }
        }
        public Conductor findByID(int id) {
            Conductor conductorE;
            using (TransporteSACDBEntities db = new TransporteSACDBEntities())
            {
                conductorE = db.Conductor.Find(id);
            }
            return conductorE;
        }
        public void updateConductor(ConductorModel conductorModel)
        {
            Conductor conductorE = Converter.model2enity(conductorModel);
            using (TransporteSACDBEntities db = new TransporteSACDBEntities())
            {
                db.Entry(conductorE).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void deleteConductor(int id) {
            using (TransporteSACDBEntities db = new TransporteSACDBEntities())
            {
                var conductor = db.Conductor.Find(id);
                db.Entry(conductor).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
