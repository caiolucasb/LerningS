using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace Test.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string name { get; set;}
        [Required]
        public string surName{ get; set;}
        [Required]
        [Range(6,18)]
        public int age { get; set;}
        [Required]
        public DateTime entryDate { get; set;}


    }
}
