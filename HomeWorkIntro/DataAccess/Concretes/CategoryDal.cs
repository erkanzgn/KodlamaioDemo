using HomeWorkIntro.DataAccess.Abstracts;
using HomeWorkIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkIntro.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    List<Category> categories;

    public CategoryDal()
    {
        Category category1 = new Category();
        category1.CategoryId = 1;
        category1.CategoryName = "All";

        Category category2 = new Category();
        category2.CategoryId = 2;
        category2.CategoryName = "Programming";

        categories = new List<Category>{category1, category2};
    }


    public List<Category> GetAll()
    {
        return categories;
    }

    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void Update(Category category)
    {
        Category updateCategory= categories.SingleOrDefault(categories=>categories.CategoryId == category.CategoryId);
        if (updateCategory != null)
        {
          category.CategoryName = updateCategory.CategoryName;
        }
        else
        {
            Console.WriteLine("Kategori buluanamadı!!");
        }

    }

    public void Delete(int categoryId)
    {
        Category deleteCategory = categories.SingleOrDefault(categories=>categories.CategoryId == categoryId);
        if (deleteCategory != null)
        {
           categories.Remove(deleteCategory);
        }
        else 
        {
            Console.WriteLine("Kategori buluanamadı!!");
        }
    }                                   
}
