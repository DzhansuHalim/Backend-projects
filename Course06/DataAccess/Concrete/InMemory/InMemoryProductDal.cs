using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>() 
            {
                new Product{ CategoryId = 1, ProductName = "Table"}
            };
        }

        public void Create(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product deleteProduct = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(deleteProduct);

        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product updateProduct = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            updateProduct.ProductId = product.ProductId;
            updateProduct.ProductName = product.ProductName;
            updateProduct.UnitPrice = product.UnitPrice;
            updateProduct.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetProductByCategoryId(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }



        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
