using Domain.Models;
using Infrastructure.Services;

Student student = new Student()
{
    
    FirsName = "Umed",
    LastName = "Safarov",
    Id = 1,
    BithDate = DateTime.Now,
    Address = "Rudaki"
};

Student student2 = new Student()
{
    
    FirsName = "Ramazon",
    LastName = "Davlatov",
    Id = 2,
    BithDate = DateTime.Now,
    Address = "Norak"
};

Student student3 = new Student()
{
       
    FirsName = "Azizbek",
    LastName = "Sanginov",
    Id = 3,
    BithDate = DateTime.Now,
    Address = "Isfara" 
};

Student student1_1 = new Student
{
    FirsName = "Ramazonjon",
    LastName = "Davlatov",
    Id = 1,
    BithDate = DateTime.Now,
    Address = "Chalchal"
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



Teacher teacher1 = new()
{
    FirsName = "Goibov",
    LastName = "Aziz",
    Id = 1,
    Position = "Director",
    ExperienceAmount = 10
};
Teacher teacher2 = new()
{
    FirsName = "Musoev",
    LastName = "La",
    Id = 2,
    Position = "Zam-Director",
    ExperienceAmount = 5
};


Teacher teacher1_1 = new()
{
    FirsName = "ALi",
    LastName = "La",
    Id = 2,
    Position = "Zam-Director",
    ExperienceAmount = 3
};



System.Console.WriteLine("------------------------------------------------------");



TeacherService teacherService = new();
teacherService.AddTeacher(teacher1);
teacherService.AddTeacher(teacher2);
teacherService.UpdateStudent(teacher1_1);
teacherService.Delete(1);
var readteacher = teacherService.GetTeacher();

foreach(var t in readteacher)
{
    System.Console.WriteLine($"{t.FirsName} {t.LastName} {t.Position} {t.ExperienceAmount}");
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
    Title = "Dubai",
    Description = "Im in dubai",
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


