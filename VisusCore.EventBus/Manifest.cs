using OrchardCore.Modules.Manifest;
using TenantHostedServiceFeatureIds = VisusCore.TenantHostedService.Constants.FeatureIds;

[assembly: Module(
    Name = "VisusCore EventBus",
    Author = "VisusCore",
    Version = "0.0.1",
    Description = "Tingle.EventBus integration.",
    Category = "VisusCore",
    Website = "https://github.com/visuscore/VisusCore.EventBus",
    Dependencies = new[]
    {
        TenantHostedServiceFeatureIds.Loader,
    }
)]
