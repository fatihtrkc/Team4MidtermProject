using BusinessLayer.Interfaces;
using DataAccessLayer.Context;
using EntitiyLayer.Entities;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.EntitiesBL
{
    public class CategoryBL : ICrud<Category>
    {
        public CategoryBL()
        {
            db = new();
        }

        Team4Context db;
        public bool Add(Category entity)
        {
            db.Categories.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int entityId)
        {
            db.Categories.Remove(Find(entityId));
            return db.SaveChanges() > 0;
        }

        public Category Find(int entityId)
        {
            return db.Categories.Find(entityId);
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public bool Update(Category entity)
        {
            db.Categories.Update(entity);
            return db.SaveChanges() > 0;
        }
    }
}
