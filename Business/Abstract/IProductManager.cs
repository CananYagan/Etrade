using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductManager
    {
        List<Product> GetAll();

        List<Product> GetAllByCategoryId(int id);

        List<Product> GetByUnitPrice(decimal min,decimal max);
    }
}
