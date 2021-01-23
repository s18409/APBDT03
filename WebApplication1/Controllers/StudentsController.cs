using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{ 

    [ApiController] 
    [Route("api/students")] 
    public class StudentsController : ControllerBase 
    {

        private IDbService _dbService; 
        public StudentsController(IDbService dbService)
        {
            this._dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {

            return Ok(_dbService.GetStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id) 
        {
            if (id == 1)
            {
                return Ok("Taha");

            }else if (id == 2)
            {
                return Ok("Johny");
            }
            return NotFound("no student ");
        }

      
        [HttpPost]   
        public IActionResult createStudent(Student student) 
        {                                                   

            student.indexnumber = $"s{new Random().Next(1,20000)}";
           
            return Ok(student);
        }

       
  

        Student student = new Student();

        [HttpPut("{id}")]
        public IActionResult PutStudent(int id)
        {
        
            return Ok("Update completed");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {     
         
            return Ok("Delete completed");
        }


    }
}