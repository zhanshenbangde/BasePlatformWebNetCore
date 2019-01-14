using Poya.BasePlatform.WebNetCore.Test;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneratorTest ct = new GeneratorTest();
            ct.GeneratorModelForSqlServer();
            Console.WriteLine("Hello World!");
        }
    }
}
