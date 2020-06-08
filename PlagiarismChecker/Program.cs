using LibGit2Sharp;
using System;
using System.Linq;
using System.Net;
using System.Text;

namespace PlagiarismChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clone repository to directory
            //Repository.Clone("https://github.com/seba300/MessageSender.git", @"C:\Users\Sebastian\source\repos\git");
            // Repository.Clone("https://gitlab.com/rics-cafe/rics-cafe.gitlab.io.git", @"C:\Users\Sebastian\source\repos");

            string repositoryPath = @"https://github.com/seba300/MessageSender.git";
            string []splitedRepositoryPath = repositoryPath.Split('/');
            string folderName = splitedRepositoryPath.Last().Remove(splitedRepositoryPath.Last().Length-4,4);
            
        }
    }
}
