using Microsoft.Extensions.DependencyInjection;

namespace RiseOnlineRehber.Core.Utilities.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
