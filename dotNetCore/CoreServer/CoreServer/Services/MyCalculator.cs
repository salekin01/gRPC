using CoreCoordinator.Interfaces;
using CoreCoordinator.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreServer.Services
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
