using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();

        IDataResult<List<Product>> GetAllByCategory(int id);

        IDataResult<List<Product>> GetByUnitPrice(int min, int max);

        IDataResult<List<ProductDetailDto>> GetProductDetails();

        IResult Add(Product product);
    }
}
