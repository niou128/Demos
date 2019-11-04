using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics;
using System.IO;

namespace SingleExe
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName))
            .AddJsonFile("appsettings.json");

            var config = builder.Build();
            var message = config.GetSection("Message").Get<Message>();

            Console.WriteLine(message.Helloworld);
        }
    }
}
