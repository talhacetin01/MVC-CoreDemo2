using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        public void Add(Category entity)
        {
            using (Context context = new Context())
            {
                context.Add(entity);
                context.SaveChanges();
            }       
        }

        public void Delete(Category entity)
        {
            using (Context context = new Context())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public List<Category> GetAll()
        {
            using (Context context = new Context())
            {
                return context.Categories.ToList();
            }
        }

        public Category GetById(int id)
        {
            using (Context context = new Context())
            {
                return context.Categories.Find(id);
            }
        }

        public void Update(Category entity)
        {
            using (Context context = new Context())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
