using BusinessLayer.Interfaces;
using BusinessLayer.Interfaces;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.EntitiesBL
{
    public class MealBL : ICrud<Meal>
    {
        public MealBL()
        {
            db = new Team4Context();
        }

        Team4Context db;
        public bool Add(Meal entity)
        {
            db.Meals.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int entityId)
        {
            db.Remove(Find(entityId));
            return db.SaveChanges() > 0;
        }

        public Meal Find(int entityId)
        {
            return db.Meals.Find(entityId);
        }

        public List<Meal> GetAll()
        {
            return db.Meals.ToList();
        }

        public bool Update(Meal entity)
        {
            db.Meals.Update(entity);
            return db.SaveChanges() > 0;
        }
    }
}
