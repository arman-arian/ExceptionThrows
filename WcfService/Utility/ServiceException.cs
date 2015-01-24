using System;
using System.ServiceModel;

namespace WcfService.Utility
{
    public class ServiceException : FaultException<ApplicationServiceError>
    {
        public ServiceException(Enum e)
            : base(null, NotifyMsg(e))
        {
           // throw new FaultException<ApplicationServiceError>(null, NotifyMsg(e));
        }

        private static string NotifyMsg(Enum e)
        {
            var description = e.GetEnumDescription();
            var codeNumber = "کد پیغام " + e.GetValue();
            return string.Format("{0} : {1}", codeNumber, description);
        }
    }
}