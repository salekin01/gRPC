using Coordinator.Interfaces;
using Coordinator.Models;
using Grpc.Core;
using ProtoBuf.Grpc.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1", 5001, ChannelCredentials.Insecure);

            try
            {
                var client = channel.CreateGrpcService<ICalculator>();
                var result = await client.MultiplyAsync(new MultiplyRequest { X = 5, Y = 10 });
                Console.WriteLine(result.Result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                await channel.ShutdownAsync();
            }
        }
    }
}
