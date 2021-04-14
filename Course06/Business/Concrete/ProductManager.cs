﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //business codes
            if(product.ProductName.Length < 4)
            {
                //magic strings
                return new ErrorResult(Messages.InvalidProductName); 
            }
            _productDal.Create(product);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            // verification code
            if(DateTime.Now.Hour == 13)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Product>>( _productDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategory(int id)
        {
            return new SuccessDataResult<List<Product>>( _productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<List<Product>> GetByUnitPrice(int min, int max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice <= min && p.UnitPrice <= max)); 
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>( _productDal.GetProductDetails());
        }
    }
}
