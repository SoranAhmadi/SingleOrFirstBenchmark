using BenchmarkDotNet.Running;
using EFCore.BulkExtensions;
using SingleOrFirstBenchmark;
//await InitDb();
BenchmarkRunner.Run<CampareBenchMark>();





 async Task InitDb()
{
    SingleOrFirstDbContext dbContext = new SingleOrFirstDbContext();
    List<Student> students = new List<Student>();
    Random _rdm = new Random();
    for (var index = 0; index < 100000; index++)
    {
        string result = _rdm.Next(10000000, 1000000000).ToString();
        students.Add(new Student()
        {
            FirstName = $"FirstName{index}",
            LastName = $"LastName{index}",
            StudentNumber = result
        });
    }
    dbContext.BulkInsert(students);
}
