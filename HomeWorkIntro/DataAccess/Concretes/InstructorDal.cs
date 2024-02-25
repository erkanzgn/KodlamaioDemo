using HomeWorkIntro.DataAccess.Abstracts;
using HomeWorkIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HomeWorkIntro.DataAccess.Concretes;
public class InstructorDal : IInstructorDal
{
    List<Instructor> instructors;


    public InstructorDal()
    {
        Instructor instructor1 = new Instructor();
        instructor1.instructorId = 1;
        instructor1.FirstName = "Engin ";
        instructor1.LastName = "Demiroğ";



        Instructor instructor2 = new Instructor();
        instructor2.instructorId = 2;
        instructor2.FirstName = "Halit Enis ";
        instructor2.LastName = "Kalaycı ";


        instructors = new List<Instructor> { instructor1, instructor2 };
    }
    public List<Instructor> GetAll()
    {
        return instructors;
    }
    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
    }
    public void Update(Instructor instructor)
    {
        Instructor UptadeInstructor = instructors.SingleOrDefault(instructors => instructors.instructorId == instructor.instructorId);
        if (UptadeInstructor != null)
        {
            instructor.FirstName = UptadeInstructor.FirstName;
            instructor.LastName = UptadeInstructor.LastName;
            Console.WriteLine("Güncellendi");
        }
        else
        {
            Console.WriteLine("Eğitmen buluanamadı!!");
        }

    }

    public void Delete(int instructorId)
    {
        Instructor DeleteInstructor = instructors.SingleOrDefault(instructors=>instructors.instructorId == instructorId);
        if (DeleteInstructor != null)
        {
            instructors.Remove(DeleteInstructor);
            Console.WriteLine("Eğitmen silindi");
        }
        else
        {
            Console.WriteLine("Eğitmen bulunamadı!!");
        }
    }
}

