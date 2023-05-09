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
    public class AddedFoodBL : ICrud<AddedFood>
    {
        public AddedFoodBL()
        {
            db = new();
        }

        Team4Context db;
        public bool Add(AddedFood entity)
        {
            db.AddedFoods.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int entityId)
        {
            db.AddedFoods.Remove(Find(entityId));
            return db.SaveChanges() > 0;
        }

        public AddedFood Find(int entityId)
        {
            return db.AddedFoods.Find(entityId);
        }

        public List<AddedFood> GetAll()
        {
            return db.AddedFoods.ToList();
        }

        public List<AddedFood> GetAllByUserId(int userId)
        {
            return db.AddedFoods.Where(u => u.UserId == userId).ToList();
        }

        public bool Update(AddedFood entity)
        {
            db.AddedFoods.Update(entity);
            return db.SaveChanges() > 0;
        }
    }
}
