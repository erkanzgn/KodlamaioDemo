using HomeWorkIntro.Business.Abstracts;
using HomeWorkIntro.DataAccess.Abstracts;
using HomeWorkIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkIntro.Business.Concretes;

class CategoryManager:ICategoryManager
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete(int categoryId)
    {
        _categoryDal.Delete(categoryId);
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }
    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }
}
