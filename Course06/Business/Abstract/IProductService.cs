using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategory(int id);

        List<Product> GetByUnitPrice(int min, int max);

        List<ProductDetailDto> GetProductDetails();
    }
}
