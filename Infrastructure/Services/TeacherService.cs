using Dapper;
using Domain.Dtos;
using Npgsql;

namespace Infrastructure.Services
{
    public class TeacherService
    {
        string connectionString = "Server = localhost; Port=5432; Database=Dapper0; User Id = postgres; Password = 233223";
        public TeacherService() 
        {

        }
        public List<TeacherDto>GetTeachers()
        {
            using(var conn =  new NpgsqlConnection(connectionString))
            {
                var sql = "select id, first_name as FirstName, last_name as LastName, email_address as EmailAddress from teachers";
               var resul = conn.Query<TeacherDto>(sql); return resul.ToList(); 
            }
        }
        public List<EnrollmentDto> Join()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                var sql = " select e.id as EnrollmentId," + 
                    " concat(s.first_name,' ', s.last_name) as FullName," +
                    " c.class_name as ClassName  " +
                    " from enrollment as e " +
                    " join classes c on e.class_id = c.id " +
                    " join students as s on e.student_id = s.id " ; 
                    
                var result = conn.Query<EnrollmentDto>(sql); 
                return result.ToList();   
            } 
        }
    }
}
