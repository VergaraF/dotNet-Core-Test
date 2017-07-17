using System;
using ServiceStack;
using ServiceStack.Text;
using TechStacks.ServiceModel;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var client = new JsonServiceClient("http://techstacks.io/");
            var response = client.Get(new GetAllTechnologies());

            //Print contents of the first technology to the Console
            response.Results[0].PrintDump();
            Console.ReadLine();
        }
    }
}