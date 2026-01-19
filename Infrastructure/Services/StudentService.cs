using Domain.Models;

namespace Infrastructure.Services;

public class StudentService
{
    public List<Student> students = [];
    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    public List<Student> GetStudents()
    {
        return students;
    }
    public void UpdateStudent(Student student)
    {
        foreach(var s in students)
        {
            if(s.Id == student.Id)
            {
                s.FirsName = student.FirsName;
                s.LastName = student.LastName;
                s.Address = student.Address;
                s.BithDate = student.BithDate;
                break;
            }

        }
    }
    public void Delete(int id)
    {
        var deleteuser = students.FirstOrDefault(f => f.Id == id);
        students.Remove(deleteuser);
    }
}
