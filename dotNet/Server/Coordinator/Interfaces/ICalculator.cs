using Coordinator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Coordinator.Interfaces
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        Task<MultiplyResult> MultiplyAsync(MultiplyRequest request);
    }
}
