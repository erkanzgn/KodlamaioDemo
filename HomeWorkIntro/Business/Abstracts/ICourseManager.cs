using HomeWorkIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkIntro.Business.Abstracts;

public interface ICourseManager
{
    List<Course> GetAll();
    void Add(Course course);
    void Update(Course course);
    void Delete(int courseId);
}
