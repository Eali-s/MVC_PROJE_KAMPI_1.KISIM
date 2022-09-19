using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal; 
        }

        public List<Category> GetAllBl()
        {
            return _categoryDal.GetAll();
        }

        public void CategoryAddBL(Category category)
        {
            if (category.CategoryName=="" || category.CategoryName.Length<=3 
                || category.CategoryDescription=="" || category.CategoryName.Length>=51)
            {
                //hata mesajı
            }
            else
            {
                _categoryDal.Insert(category);
            }

        }
    }
}
