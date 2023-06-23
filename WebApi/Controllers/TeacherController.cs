using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("controller")]
    public class TeacherController:ControllerBase
    {
        private TeacherService _teacherService;

        public TeacherController()
        {
            _teacherService= new TeacherService();
        }
        [HttpGet("Get")]
        public List<TeacherDto> GetTeacher()
        {
            return _teacherService.GetTeachers(); 

        }
        [HttpGet("GetJoin")]
        public List<EnrollmentDto> GetJoin()
        {
            return _teacherService.Join();
        }

    }
}
