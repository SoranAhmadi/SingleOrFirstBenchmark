using BenchmarkDotNet.Attributes;

namespace SingleOrFirstBenchmark
{
    public class CompareBenchMark
    {
        private string SepecficStudentNumber = "360252724";

        [Benchmark]
        public async Task FirstOrDefault()
        {
            using (SingleOrFirstDbContext context = new SingleOrFirstDbContext())
            {
                Student student = context.Student.FirstOrDefault(s => s.StudentNumber == SepecficStudentNumber);
            }
        }

        [Benchmark]
        public async Task SingleOrDefault()
        {
            using (SingleOrFirstDbContext context = new SingleOrFirstDbContext())
            {
                Student student = context.Student.SingleOrDefault(s => s.StudentNumber == SepecficStudentNumber);
            }
        }

    }
}
