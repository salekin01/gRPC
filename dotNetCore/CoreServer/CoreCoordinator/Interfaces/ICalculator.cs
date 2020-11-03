using CoreCoordinator.Models;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CoreCoordinator.Interfaces
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        Task<MultiplyResult> MultiplyAsync(MultiplyRequest request);
    }
}
