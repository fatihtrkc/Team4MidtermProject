using BusinessLayer.Interfaces;
using DataAccessLayer.Context;
using EntitiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.EntitiesBL
{
    public class LifeStyleBL : ICrud<LifeStyle>
    {
        public LifeStyleBL()
        {
            db = new();
        }
        Team4Context db;
        public bool Add(LifeStyle entity)
        {
            db.LifeStyles.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int entityId)
        {
            db.LifeStyles.Remove(Find(entityId));
            return db.SaveChanges() > 0;
        }

        public LifeStyle Find(int entityId)
        {
            return db.LifeStyles.Find(entityId);
        }

        public List<LifeStyle> GetAll()
        {
            return db.LifeStyles.ToList();
        }

        public bool Update(LifeStyle entity)
        {
            db.LifeStyles.Update(entity);
            return db.SaveChanges() > 0;
        }
    }
}
