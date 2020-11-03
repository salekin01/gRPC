using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;
using CoreCoordinator.Interfaces;
using CoreCoordinator.Models;

namespace CoreClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            GrpcClientFactory.AllowUnencryptedHttp2 = true;
            using var http = GrpcChannel.ForAddress("http://127.0.0.1:5001");                  
            var calculator = http.CreateGrpcService<ICalculator>();
            var result = await calculator.MultiplyAsync(new MultiplyRequest { X = 12, Y = 4 });
            Console.WriteLine(result.Result);
            Console.ReadLine();
        }
    }
}
