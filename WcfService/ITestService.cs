using System.ServiceModel;
using WcfService.ErrorHandlers;
using WcfService.Utility;

namespace WcfService
{
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        [FaultContract(typeof(ApplicationServiceError))]
        bool DoWork();
    }
}
