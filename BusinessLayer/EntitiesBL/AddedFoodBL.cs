using BusinessLayer.Interfaces;
using DataAccessLayer.Context;
using EntitiyLayer.Entities;
using EntityLayer.Entities;
using EntityLayer.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        public IQueryable GetAllByUserId(int userId)
        {
            var table = db.AddedFoods.Where(u => u.UserId == userId).GroupBy(a=> a.FoodId).Select(grp=> new {FoodId =grp.Key, YemekSayisi = grp.Count()});
            return table;
        }

        public List<AddedFood> GetAllByUserIdAndDay(int userId, DateTime date)
        {
            return db.AddedFoods.Where(u => u.UserId == userId && u.CreationDate == date).ToList();
        }

        public List<AddedFood> GetAllByUserIdAndDayAndMeal(int userId, DateTime date, MealType type)
        {
            return db.AddedFoods.Where(u => u.UserId == userId && u.CreationDate == date && u.MealId == type).ToList();
        }

        public bool Update(AddedFood entity)
        {
            db.AddedFoods.Update(entity);
            return db.SaveChanges() > 0;
        }
        public double GetSumColory(int id, DateTime dateTime, MealType type)
        {
            double sum = db.AddedFoods.Where(a => a.UserId == id && a.CreationDate == dateTime && a.MealId == type).Sum(a => a.TotalCalory);
            return sum;
        }
        public double GetTotalCalory(int id, int categoryId, DateTime date)
        {
            return db.AddedFoods.Where(a => a.UserId == id && a.Food.CategoryId == categoryId && a.CreationDate >= date).Sum(a => a.TotalCalory);
        }

        public double GetAverageCalory(int categoryId, DateTime date)
        {
            double sum = db.AddedFoods.Where(a => a.Food.CategoryId == categoryId && a.CreationDate >= date).Sum(a => a.TotalCalory);
            return sum / db.Users.Count();
        }

        public double GetSumCaloryPerMeal(int userId, MealType type, DateTime time)
        {
            return db.AddedFoods.Where(a => a.UserId == userId && a.MealId == type && a.CreationDate >= time).Sum(a => a.TotalCalory);
        }

        public double GetAverageCaloryPerMeal(MealType type, DateTime time)
        {
            double sum = db.AddedFoods.Where(a => a.MealId == type && a.CreationDate >= time).Sum(a => a.TotalCalory);
            return sum / db.Users.Count();
        }

        public int GetCountFood(int userId, int foodId, MealType type)
        {
            return db.AddedFoods.Where(a => a.UserId == userId && a.FoodId == foodId && a.MealId==type).Count();
        }

        public int GetCountFoodTop(int userId, int foodId)
        {
            return db.AddedFoods.Where(a => a.UserId == userId && a.FoodId == foodId).Count();
        }
    }
}
