using System;

namespace DxRep.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var test=new SqlServerDemo();
            test.AssemblyLoad();
            Console.ReadKey();
        }
    }
}
