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
    public class AdminBL : ICrud<Admin>
    {
        public AdminBL()
        {
            db = new();
        }

        Team4Context db;
        public Admin Find(int entityId)
        {
            return db.Admins.Find(entityId);
        }

        public List<Admin> GetAll()
        {
            return db.Admins.ToList();
        }

        public bool Add(Admin entity)
        {
            db.Admins.Add(entity);
            return db.SaveChanges()>0;
        }

        public bool Delete(int entityId)
        {
            db.Admins.Remove(Find(entityId));
            return db.SaveChanges()>0;
        }

        public bool Update(Admin entity)
        {
            db.Admins.Update(entity);
            return db.SaveChanges() > 0;
        }

        public int Login(string adminName, string password)
        {
            Admin admin = db.Admins.Where(x => x.Email == adminName && x.Password == password).SingleOrDefault();
            if (admin != null)
            {
                return admin.Id;
            }
            else
            {
                return -1;
            }
        }
    }
}
