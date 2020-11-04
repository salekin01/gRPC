using Coordinator.Interfaces;
using Coordinator.Models;
using Grpc.Core;
using ProtoBuf.Grpc.Server;
using Server.Services;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Program : MyCalculator
    {
        static async Task Main(string[] args)
        {
            const int port = 5001;
            Grpc.Core.Server server = new Grpc.Core.Server
            {
                Ports = { new ServerPort("127.0.0.1", port, ServerCredentials.Insecure) }
            };
            server.Services.AddCodeFirst(new Program());
            server.Start();

            Console.WriteLine("server listening on port " + port);
            Console.ReadKey();

            await server.ShutdownAsync();
        }
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddScoped<ICalculator, MyCalculator>();
        //}
    }
}
