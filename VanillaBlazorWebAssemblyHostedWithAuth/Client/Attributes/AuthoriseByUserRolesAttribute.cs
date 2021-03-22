using System.Linq;
using Client.Enums;
using Microsoft.AspNetCore.Authorization;

namespace Client.Attributes
{
    public class AuthoriseByUserRolesAttribute : AuthorizeAttribute
    {
        public AuthoriseByUserRolesAttribute(params UserRole[] userRoles)
        {
            if (userRoles.Length > 0)
            {
                Roles = string.Join(',', userRoles.Select(x => x.ToString()));
            }
        }
    }
}
