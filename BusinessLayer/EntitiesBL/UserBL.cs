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
    public class UserBL : ICrud<User>
    {
        public UserBL()
        {
            db = new();
        }

        Team4Context db;
        public bool Add(User entity)
        {
            db.Users.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int entityId)
        {
            db.Users.Remove(Find(entityId));
            return db.SaveChanges() > 0;
        }

        public User Find(int entityId)
        {
            return db.Users.Find(entityId);
        }

        public List<User> GetAll()
        {
            return db.Users.ToList();
        }

        public bool Update(User entity)
        {
            db.Users.Update(entity);
            return db.SaveChanges() > 0;
        }

        //public void VKEHesapla(int entityId)
        //{
        //    double weight = db.Users.Find(entityId).Weight;
        //    double height = db.Users.Find(entityId).Height;

        //}
    }
}
