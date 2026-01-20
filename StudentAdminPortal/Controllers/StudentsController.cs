using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.Data;
using StudentAdminPortal.Models;
using StudentAdminPortal.Models.Entities;

namespace StudentAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public StudentsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var students = dbContext.Students.ToList();
            return Ok(students);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetStudentById(Guid id)
        {
            var student = dbContext.Students.Find(id);
            if (student is null)
            {
                return NotFound();
            }
            return Ok(student);
        }
        [HttpPost]
        public IActionResult AddStudent(AddStudentDto addStudentDto)
        {
            var studentEntity = new Student()
            {
                Name = addStudentDto.Name,
                Email = addStudentDto.Email,
                Phone = addStudentDto.Phone,
                Fees = addStudentDto.Fees
            };
            dbContext.Students.Add(studentEntity);
            dbContext.SaveChanges();
            return Ok(studentEntity);
        }
        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateStudent(Guid id, UpdateStudentDto updateStudentDto)
        {
            var student = dbContext.Students.Find(id);
            if (student is null)
            {
                return NotFound();
            }
            student.Name = updateStudentDto.Name;
            student.Email = updateStudentDto.Email;
            student.Phone = updateStudentDto.Phone;
            student.Fees = updateStudentDto.Fees;
            dbContext.SaveChanges();
            return Ok(student);
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteStudent(Guid id)
        {
            var student = dbContext.Students.Find(id);
            if (student is null)
            {
                return NotFound();
            }
            dbContext.Students.Remove(student);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
