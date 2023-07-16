using Microsoft.Extensions.DependencyInjection;
using VisusCore.EventBus.Core.Services;

namespace VisusCore.EventBus.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddReactiveEventConsumer<TEvent>(this IServiceCollection services)
        where TEvent : class, new()
    {
        services.AddSingleton<ReactiveEventConsumer<TEvent>>();
        services.AddEventBus(builder => builder.AddConsumer<ReactiveEventConsumer<TEvent>>());

        return services;
    }
}
