using Domain.Models;

namespace Infrastructure.Services;

public class TeacherService
{
    public List<Teacher> teachers = [];
    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }
    public List<Teacher> GetTeacher()
    {
        return teachers;
    }
    public void UpdateStudent(Teacher teacher)
    {
        foreach(var t in teachers)
        {
            if(t.Id == teacher.Id)
            {
                t.FirsName = teacher.FirsName;
                t.LastName = teacher.LastName;
                t.Position = teacher.Position;
                t.ExperienceAmount = teacher.ExperienceAmount;
                break;
            }

        }
    }
    public void Delete(int id)
    {
        var findteacher = teachers.FirstOrDefault(t => t.Id == id);
        teachers.Remove(findteacher);
    }
}
