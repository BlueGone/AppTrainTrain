using Flotte.Web;
using Shared.Web;
using Shared.Web.Registration;

namespace Application.Web
{
    public static class BoundedContexts
    {
        public static IBoundedContextRegistration RegisterAllBoundedContexts(IContainer container) =>
            new CompositeBoundedContextRegistration(
                new ContainerRegistration(container));
    }
}