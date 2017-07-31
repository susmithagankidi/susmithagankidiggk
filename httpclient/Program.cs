using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json.Linq;
namespace http
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient h=new HttpClient();
            Student studentobject=new Student
            {
                StudentId=139,
                StudentName="hai"
            };
            Httpgetpost obj=new Httpgetpost();
           Task<string> t1= obj.GetAsync<Student>();
           Console.WriteLine(t1.Result);
          Task<string> t2= obj.PostAsync<Student>(studentobject);
          t1.Wait();
           t2.Wait();
        Console.WriteLine(t2.Result);
        }
    }
    class Student
    {
       public int StudentId;
       public string StudentName;
    }
    class Group
    {
       
    }
}
