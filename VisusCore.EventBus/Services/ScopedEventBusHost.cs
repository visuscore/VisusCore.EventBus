using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Tingle.EventBus.Internal;
using VisusCore.TenantHostedService.Abstractions.Services;
using EventBusBase = Tingle.EventBus.EventBus;

namespace VisusCore.EventBus.Services;

public class ScopedEventBusHost : EventBusHost, ITenantHostedScopedService
{
    public ScopedEventBusHost(IHostApplicationLifetime lifetime, EventBusBase bus, ILogger<EventBusHost> logger)
        : base(lifetime, bus, logger)
    {
    }
}
