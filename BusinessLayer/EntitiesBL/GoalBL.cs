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
    public class GoalBL : ICrud<Goal>
    {
        public GoalBL()
        {
            db = new();
        }

        Team4Context db;

        public bool Add(Goal entity)
        {
            db.Goals.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int entityId)
        {
            db.Goals.Remove(Find(entityId));
            return db.SaveChanges() > 0;
        }

        public Goal Find(int entityId)
        {
            return db.Goals.Find(entityId);
        }

        public List<Goal> GetAll()
        {
            return db.Goals.ToList();
        }

        public bool Update(Goal entity)
        {
            db.Goals.Update(entity);
            return db.SaveChanges() > 0;
        }
    }
}
