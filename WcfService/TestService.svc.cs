using System;
using WcfService.ErrorHandlers;
using WcfService.Utility;

namespace WcfService
{
    [ApplicationErrorHandler]
    public class TestService : ITestService
    {
        public bool DoWork()
        {
           // return true;
            // throw new ServiceException(ErrorMessages.UserDeleted);

             throw new StackOverflowException();
        }
    }
}
