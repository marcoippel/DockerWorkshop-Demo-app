using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DockerWorkshop_Demo_app
{
    static class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine(args[0]);
            }
        }
    }
}
