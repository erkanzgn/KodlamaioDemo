using HomeWorkIntro.DataAccess.Abstracts;
using HomeWorkIntro.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkIntro.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> courses;

    public CourseDal()
    {
        Course course1 = new Course();
        course1.courseId = 1;
        course1.courseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
        course1.courseInstructor = "Engin Demiroğ";
        course1.courseDescription = "Kodlamaio";

        Course course2 = new Course();
        course2.courseId = 2;
        course2.courseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium";
        course2.courseInstructor = "Halit Enes Kalaycı";
        course2.courseDescription = "Kodlamaio";

        courses= new List<Course> {course1,course2 };
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

    public void Update(Course course)
    {
        Course updateCourse = courses.SingleOrDefault(c => c.courseId == course.courseId);
        if (updateCourse != null)
        {
            updateCourse.courseName = course.courseName;
            updateCourse.courseDescription = course.courseDescription;
            updateCourse.courseInstructor = course.courseInstructor;
            updateCourse.courseId = course.courseId;
            Console.WriteLine("Kurs Güncellendi");
        }
        else
        {
            Console.WriteLine("Kurs bulunamadı!!");
        }
    }

    public void Delete(int courseId)
    {
        Course deleteCourse = courses.SingleOrDefault(c => c.courseId == courseId);
        if (deleteCourse != null)
        {
            deleteCourse.courseId = courseId;
            Console.WriteLine("Kurs Silindi");
        }
        else
        {
            Console.WriteLine("kurs bulunamadı");
        }

    }
}
