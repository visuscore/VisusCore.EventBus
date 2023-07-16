using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using VisusCore.EventBus.Services;
using VisusCore.TenantHostedService.Core.Extensions;

namespace VisusCore.EventBus;

public class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services) =>
        services.AddEventBus(
            builder => builder.AddInMemoryTransport(),
            services => services.AddTenantHostedScopedService<ScopedEventBusHost>());
}
