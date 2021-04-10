using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        //CRUD
        void Create(Product product);
        List<Product> GetAll();
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetProductByCategoryId(int categoryId);

    }
}
