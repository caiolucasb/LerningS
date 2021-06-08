using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Data{
    public class StudentContext : DbContext{
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
            
        }
        public virtual DbSet<Student> Students{get;set;}
    }
    
}