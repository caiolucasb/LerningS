using Test.Models;
using Microsoft.AspNetCore.Mvc;



namespace Test.Interfaces{
    public interface IStudentService
    {
        bool Test(Student student);
        void Test2();
    
    }
}