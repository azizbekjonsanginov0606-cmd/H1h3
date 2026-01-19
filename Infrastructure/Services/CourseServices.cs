using Domain.Models;

namespace Infrastructure.Services;

public class CourseServices
{
    List<Course> courses = [];
    public void AddCourse(Course course)
    {
        courses.Add(course);
    }
    public List<Course> GetCourse()
    {
        return courses;
    }
    public void UpdateCourse(Course course)
    {
        foreach(var c in courses)
        {
            if(c.Id == course.Id)
            {
                c.Title = course.Title;
                c.Description = course.Description;
                c.Fee = course.Fee;
                c.HasDiscount = course.HasDiscount;
                break;
            }

        }
    }
    public void Delete(int id)
    {
        var deletecourse = courses.FirstOrDefault(f => f.Id == id);
        courses.Remove(deletecourse);
    }
}

