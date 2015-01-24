using System;
using System.Linq;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace WcfService.ErrorHandlers
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class ApplicationErrorHandlerAttribute : Attribute, IServiceBehavior
    {
        public void AddBindingParameters(ServiceDescription serviceDescription,
            System.ServiceModel.ServiceHostBase serviceHostBase,
            System.Collections.ObjectModel.Collection<ServiceEndpoint> endpoints,
            System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            //not apply for this sample
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription,
            System.ServiceModel.ServiceHostBase serviceHostBase)
        {
            if (serviceHostBase.ChannelDispatchers.Any())
            {
                //add default error handler to all dispatcher in wcf services
                foreach (var dispatcher in serviceHostBase.ChannelDispatchers.Cast<ChannelDispatcher>())
                {
                    dispatcher.ErrorHandlers.Add(new ApplicationErrorHandler());
                }
            }
        }

        public void Validate(ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase)
        {
            //not apply for this sample
        }
    }
}
