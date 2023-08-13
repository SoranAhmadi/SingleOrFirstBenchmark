using System.ComponentModel.DataAnnotations;
namespace SingleOrFirstBenchmark
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string StudentNumber { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
    }
}
