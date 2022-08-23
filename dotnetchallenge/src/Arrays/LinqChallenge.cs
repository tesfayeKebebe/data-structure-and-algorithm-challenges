using System;
using System.Linq;

namespace dotnetchallenge.Arrays
{
    public class LinqChallenge
    {
        public LinqChallenge()
        {
        }
        public static void MethodsInLinQ()
        {

            var highPerformingStudents = from student in GetStudentsFromDb()
                                         where student.Mark >= 80
                                         select student;
            var lamda = GetStudentsFromDb().Where(x => x.Mark >= 80).OrderBy(y => y.Mark).GroupBy(x=>x.City).ToList();
            var select = GetStudentsFromDb().Where(x => x.Mark >= 80).Select(y => new Student {StudentName=y.StudentName, Mark=y.Mark, City=y.City, StudentID=y.StudentID }).ToList();
            var all = GetStudentsFromDb().All(x => x.Mark > 50);
            var any = GetStudentsFromDb().Any(x => x.Mark > 50);

        }
        static IQueryable<Student> GetStudentsFromDb()
        {
            return new[] {
                new Student() { StudentID = 1, StudentName = "John Nigel", Mark = 73, City ="NYC"} ,
                new Student() { StudentID = 2, StudentName = "Alex Roma",  Mark = 51 , City ="CA"} ,
                new Student() { StudentID = 3, StudentName = "Noha Shamil",  Mark = 88 , City ="CA"} ,
                new Student() { StudentID = 4, StudentName = "James Palatte" , Mark = 60, City ="NYC"} ,
                new Student() { StudentID = 5, StudentName = "Ron Jenova" , Mark = 85 , City ="NYC"} }.AsQueryable();
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public decimal Mark { get; set; }
        public string City { get; set; }
    }
}
