using System.Security.Claims;

namespace Think2Solve.CentralizedIdentity.Web.Authorization
{
    public class AuthorizationManager : ClaimsAuthorizationManager
    {
        public override bool CheckAccess(AuthorizationContext context)
        {
            return true;
        }
    }
}