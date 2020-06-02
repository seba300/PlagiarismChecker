using System;
using System.Net;
using System.Text;

namespace PlagiarismChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new WebClient();
            var res = repo.DownloadString(@"https://raw.githubusercontent.com/seba300/P3/master/3_1/Program.cs");
            res = res.Replace(" ", String.Empty).Replace("\n",String.Empty);
            byte[] a = Encoding.ASCII.GetBytes(res);
            res = String.Empty;
            foreach (var item in a)
            {
                res += item;
            }

            var b = "1171151051101038312111511610110959110971091011151129799101801141111061019911612399108971151158011411110311497109123115116971161059911811110510077971051104011511611410511010391939711410311541123671111101151111081014687114105116101761051101014034721011081081118711111410810033344159125125125";

            Console.WriteLine(b);
            Console.WriteLine();
            Console.WriteLine(res);

        }
    }
}
