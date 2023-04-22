using System.Net.WebSockets;

namespace LinqLearning;

public class Program
{
    public static void Main()
    {
        //List<int> list = new List<int>();
        //Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
        //foreach(var i in list)
        //{

        //}

        //foreach(var key in keyValuePairs.Keys)
        //{
        //    Console.WriteLine( keyValuePairs[key] ) ;
        //}

        //IEnumerable<int> ints = list;

        //var stud = new Student()
        //{
        //    Id = 1,
        //    Name = "Ruoyu",
        //    Description = "Fox"
        //};
        //var studReport = new StudentReport()
        //{
        //    Id = 1,
        //    StudentName = stud.Name,
        //    StudentAcademicComments = "not too bad"
        //};


        // Delayed Execution and immediate execution
        string[] names = new string[] { "Chen", "Wei", "Gaode", "Linfeng", "Roger", "Liuboxuan" };
        Console.WriteLine("Deferred");
        var query = names.Where(x => x[0] == 'L'); //.ToList();

        foreach(var item in query)
        {
            Console.WriteLine(item);
            names[5] = "Anderson";
            //Console.WriteLine(item);
        }
    }
}


public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

public class StudentReport
{
    public int Id { get; set; }
    public string StudentName { get; set; }
    public string StudentAcademicComments { get; set;}
    public Dictionary<string, int> Grades { get; set; }
}