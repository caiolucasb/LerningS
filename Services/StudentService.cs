using System;
using Microsoft.AspNetCore.Mvc;
using Test.Models;
using Test.Interfaces;


namespace Test.Services{
    public class StudentService : IStudentService{
        public bool Test(Student student){
            if(student.age < 6 || student.age > 18 || student.name == null|| student.name == "" || student.surName == null || student.surName == "")
                return true;
            return false;
        }
        public void Test2(){
            System.Console.WriteLine("AAAA");
        }
    }
}