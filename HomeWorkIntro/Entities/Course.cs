using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkIntro.Entities;

public class Course 
{
    public int courseId { get; set; }
    public string courseName { get; set; }
    public string courseDescription { get; set; }
    public string courseInstructor {  get; set; }
}
