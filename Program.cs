using System;
using System.IO;
using System.Threading.Tasks;

namespace AssignmentMod4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string SrcPath = @"C:\Users\vinay singh jadon\Desktop\Promact Intership\AssignmentMod4\A.txt";
            string DestiPath = @"C:\Users\vinay singh jadon\Desktop\Promact Intership\AssignmentMod4\B.txt";

            await ReadAndWriteAsync(SrcPath, DestiPath);
        }

        private static async Task ReadAndWriteAsync(string SrcPath, string DestiPath)
        {
            string Content = await File.ReadAllTextAsync(SrcPath);
            await File.WriteAllTextAsync(DestiPath, Content);
            System.Console.WriteLine("Task Completed");
        }
    }
}
