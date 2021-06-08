using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Test.Interfaces;
using Test.Models;
using Test.Data;

namespace Test.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _context;
        private readonly IStudentService _service;
        public StudentController(StudentContext context, IStudentService service)
        {
            _context = context;
            _service = service;
        }
        [HttpGet("/Students")]
        public IActionResult Get(){
            _service.Test2();
            return Ok(_context.Students.ToList());
        }
        [HttpPost("/Students")]
        public IActionResult Post([FromBody]Student student){
            if(_service.Test(student)){
                return BadRequest("Não foi autorizada a criação do estudante");
            }
            //SRP
            student.entryDate = DateTime.Now;
            _context.Add(student);
            _context.SaveChanges();
            return Ok(student);
        }   
    }
}
