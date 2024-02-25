using HomeWorkIntro.Business.Abstracts;
using HomeWorkIntro.DataAccess.Abstracts;
using HomeWorkIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkIntro.Business.Concretes;

public class InstructorManager:IInstructorManager
{
    private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }
    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }
    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }
    public void Delete(int instructorId)
    {
        _instructorDal.Delete(instructorId);
    }
    public void Update(Instructor instructor)
    {
        _instructorDal.Update(instructor);
    }
}
