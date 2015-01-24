using System.Runtime.Serialization;

namespace WcfService.Utility
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