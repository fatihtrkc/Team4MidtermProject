using BusinessLayer.Interfaces;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.EntitiesBL
{
    public class UnitBL : ICrud<Unit>
    {
        public UnitBL()
        {
            db = new();
        }
        Team4Context db;
        public bool Add(Unit entity)
        {
            db.Units.Add(entity);
            return db.SaveChanges()>0;
        }

        public bool Delete(int entityId)
        {
            db.Units.Remove(Find(entityId));
            return db.SaveChanges()>0;
        }

        public Unit Find(int entityId)
        {
            return db.Units.Find(entityId);
        }

        public List<Unit> GetAll()
        {
            return db.Units.ToList();
        }

        public bool Update(Unit entity)
        {
            db.Units.Update(entity);
            return db.SaveChanges()>0;
        }
    }
}
