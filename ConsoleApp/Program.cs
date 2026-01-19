using Domain.Models;
using Infrastructure.Services;

Student student1 = new Student()
{
    FirsName = "Umed",
    LastName = "Safarov",
    Id = 1,
    BithDate = DateTime.Now,
    Address = "Rudaki"
};

Student student2 = new Student()
{
    
    FirsName = "Sadriddin",
    LastName = "Uzbekov",
    Id = 2,
    BithDate = DateTime.Now,
    Address = "Aini"
};

Student student3 = new Student()
{
       
    FirsName = "Azizbek",
    LastName = "Sanginov",
    Id = 3,
    BithDate = DateTime.Now,
    Address = "Aini" 
};

Student student1_1 = new Student
{
    FirsName = "Sadriddinjon",
    LastName = "Uzbekov",
    Id = 1,
    BithDate = DateTime.Now,
    Address = "Aini"
};

StudentService studentService = new();
studentService.AddStudent(student);
studentService.AddStudent(student2);
studentService.AddStudent(student3);
studentService.UpdateStudent(student1_1);
studentService.Delete(2);
var show = studentService.GetStudents();


foreach(Student s in show)
{
    System.Console.WriteLine($"{s.LastName} {s.FirsName} {s.Id} {s.BithDate} {s.Address}");
}
Course course1 = new()
{
    Id = 1,
    Title = "C#",
    Description = "C# course",
    Fee = 1500,
    HasDiscount = false
};


Course course2 = new()
{
    Id = 2,
    Title = "AmericanSchool",
    Description = "ENglish course",
    Fee = 500,
    HasDiscount = true
};

Course course2_1 = new()
{
    Id = 2,
    Title = "AmericanSchool",
    Description = "English course",
    Fee = 500,
    HasDiscount = true
};



System.Console.WriteLine("------------------------");


CourseServices courseServices = new();
courseServices.AddCourse(course1);
courseServices.AddCourse(course2);
courseServices.UpdateCourse(course2_1);
courseServices.Delete(1);
var fcourse = courseServices.GetCourse();
foreach(Course c in fcourse)
{
    System.Console.WriteLine($"{c.Title} {c.Description} {c.Fee} {course1.HasDiscount}");
}



Post post1 = new Post(){

    Id = 1,
    Title = "Chin",
    Description = "Im in Chin",
    VoteAmount = 100,
    CreatedAt = DateTime.Today
};

Post post2 = new Post(){

    Id = 2,
    Title = "America",
    Description = "Im in america",
    VoteAmount = 10,
    CreatedAt = DateTime.Today
};

Post post2_1 = new Post()
{
    Id = 2,
    Title = "America",
    Description = "New York",
    VoteAmount = 100,
    CreatedAt = DateTime.Today    
};

System.Console.WriteLine("----------------------");

PostServices postServices = new();
postServices.AddPost(post1);
postServices.AddPost(post2);
postServices.UpdatePost(post2_1);
postServices.DeletePost(2);
var readpost = postServices.GetPosts();
foreach(Post p in readpost)
{
    System.Console.WriteLine($"{p.Title} {p.Description} {p.VoteAmount} {p.CreatedAt}");
}


