using HomeWorkIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkIntro.DataAccess.Abstracts;

public interface ICategoryDal
{
    List<Category> GetAll();
    void Add(Category category);
    void Update(Category category);
    void Delete(int category);

}
