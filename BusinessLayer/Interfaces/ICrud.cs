using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    internal interface ICrud<T> where T : class
    {
        public List<T> GetAll();
        public bool Add(T entity);
        public bool Delete(int entityId);
        public bool Update(T entity);
        public T Find(int entityId);
    }
}
