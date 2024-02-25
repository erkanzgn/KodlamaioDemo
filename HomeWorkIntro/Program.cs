using HomeWorkIntro.Business.Concretes;
using HomeWorkIntro.DataAccess.Abstracts;
using HomeWorkIntro.DataAccess.Concretes;
using HomeWorkIntro.Entities;

namespace HomeWorkIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager(new  CategoryDal());
            List<Category> categories = categoryManager.GetAll();
            foreach(var category in categories)
            {
                Console.WriteLine(category.CategoryId+" = "+category.CategoryName);

            }
            Console.WriteLine("------yeni kategory eklendikten sonra---------");

            categories.Add(new Category { CategoryId = 3, CategoryName = "Algorithms" });

            List<Category> categories1 = categoryManager.GetAll();

            foreach(var category in categories)
            {
                Console.WriteLine(category.CategoryId + " = " + category.CategoryName);
            }
            Console.ReadLine();
        }
    }


}
