using BusinessLayer.Interfaces;
using DataAccessLayer.Context;
using EntitiyLayer.Entities;
using EntityLayer.Enums;
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

        public List<AddedFood> GetAllByUserIdAndDay(int userId, DateTime date)
        {
            return db.AddedFoods.Where(u => u.UserId == userId && u.CreationDate == date).ToList();
        }

        public List<AddedFood> GetAllByUserIdAndDayAndMeal(int userId, DateTime date, MealType type)
        {
            return db.AddedFoods.Where(u => u.UserId == userId && u.CreationDate == date && u.MealId==type).ToList();
        }

        public bool Update(AddedFood entity)
        {
            db.AddedFoods.Update(entity);
            return db.SaveChanges() > 0;
        }
        public double GetSumColory(int id, DateTime dateTime, MealType type)
        {
            double sum =db.AddedFoods.Where(a => a.UserId == id && a.CreationDate==dateTime && a.MealId == type).Sum(a=> a.TotalCalory);
            return sum;
        }
    }
}
