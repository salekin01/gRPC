using Coordinator.Interfaces;
using Coordinator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    public class MyCalculator : ICalculator
    {
        public Task<MultiplyResult> MultiplyAsync(MultiplyRequest request)
        {
            return Task.FromResult(new MultiplyResult
            {
                Result = request.X * request.Y
            });
        }
    }
}
