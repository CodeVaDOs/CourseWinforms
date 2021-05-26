//using Course.Config;
//using Course.Entity;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Course.Dao
//{
//    public abstract class AbstractDao<E>: IDao<E> where E : AbstractEntity
//    {
//        string PropetryName = "";

//        protected AbstractDao()
//        {
//            if (typeof(E) == typeof(User)) PropetryName = "Users";
//            if (typeof(E) == typeof(Log)) PropetryName = "Logs";
//        }

//        public void Create(E entity)
//        {
//            Perform<E>(data => data.Add(entity));
//        }

//        public void Delete(E entity)
//        {
//            Perform<E>(data => data.Remove(entity));
//        }

//        public void DeleteById(long id)
//        {
//            Perform<E>(data => data.Remove(data.Single(u => u.ID == id)));
//        }

//        public List<E> GetAll()
//        {
//            return Perform<List<E>>(data => data.ToList<E>());
//        }

//        public E GetById(long id)
//        {
//            return Perform<E>(data => data.SingleOrDefault(u => u.ID == id));
//        }

//        public E Update(E entity)
//        {
//            throw new NotImplementedException();
//        }

//        public O Perform<O>(Func<DbSet<E>, O> func) 
//        {
//            using (var context = new DatabaseContext())
//            {
//                var info = context.GetType().GetProperty(PropetryName);
//                var set = info.GetValue(context) as DbSet<E>;
//                var result = func(set);
//                context.ChangeTracker.DetectChanges();
//                context.SaveChanges();
//                context.Dispose();
//                return result;
//            }
//        }

//    }
//}
