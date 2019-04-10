using Abp.AutoMapper;
using LoanMelliBank.Authentication.External;

namespace LoanMelliBank.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
