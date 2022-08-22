using BusinnessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class CategoryManager : IGenericService<Category>
    {
        EFCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EFCategoryRepository();
        }

        public void Add(Category entity)
        {
            efCategoryRepository.Add(entity);
        }

        public List<Category> GetAll()
        {
            return efCategoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return efCategoryRepository.GetById(id);
        }

        public void Remove(Category entity)
        {
            efCategoryRepository.Delete(entity);
        }

        public void Update(Category entity)
        {
            efCategoryRepository.Update(entity);
        }
    }
}
