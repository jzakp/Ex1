using Microsoft.AspNetCore.Authorization;

namespace Ex1.Helpers
{
    public class EmailDomainRequirement:IAuthorizationRequirement
    {
        public string EmailDomain { get; }

        public EmailDomainRequirement(string emailDomain)
        {
            EmailDomain = emailDomain;
        }
    }
}
