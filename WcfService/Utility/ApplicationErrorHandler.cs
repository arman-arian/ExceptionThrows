using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace WcfService.Utility
{
    public sealed class ApplicationErrorHandler : IErrorHandler
    {
        public bool HandleError(Exception error)
        {
            //if (error != null)
            //    LoggerFactory.CreateLog().LogError(..., error);

            //set  error as handled
            return true;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            if (error is FaultException<ApplicationServiceError>)
            {
                fault = ProvideMessage(error.Message, version);
            }
            if (error is StackOverflowException)
            {
                var serviceException = new ServiceException(ErrorMessages.DatabaseLinkDisconnect);
                fault = ProvideMessage(serviceException.Message, version);
            }
        }

        private static Message ProvideMessage(string message, MessageVersion version)
        {
            var defaultFaultException = new FaultException<ServiceException>(null, message);
            var defaultMessageFault = defaultFaultException.CreateMessageFault();
            return Message.CreateMessage(version, defaultMessageFault, defaultFaultException.Action);
        }
    }
}
