using Microsoft.AspNetCore.Identity;

namespace WebApplication11.Data.Identity
{
    public class ApplicationIdentityUser : IdentityUser
    {
        public long ApllicationId { get; set; }
    }
}
