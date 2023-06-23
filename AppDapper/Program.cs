
using Infrastructure.Services;

var teacherService = new TeacherService();
//Show();
void Show()
{
    var teachers = teacherService.GetTeachers();
    Console.WriteLine("Id-------FirstName-------Last_Name-------EmailAddress");
    foreach(var teacher in teachers)
    {
        Console.WriteLine($"{teacher.Id}-------{teacher.FirstName}------- {teacher.LastName}-------{teacher.EmailAddress}");
    } 
}
//ShowJoin();
void ShowJoin()
{
    var enrollments = teacherService.Join();
    Console.WriteLine("enrollmentId------fullName---------classname");
    foreach (var enrollment in enrollments)
    {
        Console.WriteLine($"{enrollment.EnrollmentId}---------{enrollment.FullName}-------{enrollment.ClassName}");
    }
}