using System.Runtime.Serialization;

namespace WcfService.ErrorHandlers
{
    [DataContract(Name = "ServiceError")]
    public class ApplicationServiceError
    {
        /// <summary>
        /// Error message that flow to client services
        /// </summary>
        [DataMember(Name = "ErrorMessage")]
        public string ErrorMessage { get; set; }
    }
}