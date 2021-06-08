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
            _service.Test();
            _service.Test2();
            return Ok(_context.Students.ToList());
        }
    }
}
