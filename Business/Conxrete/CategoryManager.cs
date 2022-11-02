using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Conxrete
{
    public class CategoryManager : ICategoryManager
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public List<Category> GetAll()
        {
            //İş Kodları
            return _categorydal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _categorydal.Get(c=>c.CategoryId==categoryId);
        }
    }
}
