using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

       

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

  
        public List<Category> GetAll()
        {   //buraya is kodlarimi yazarim ben 
            
            return _categoryDal.GetAll();

        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }

        IDataResult<List<Category>> ICategoryService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Category>> ICategoryService.GetById(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
