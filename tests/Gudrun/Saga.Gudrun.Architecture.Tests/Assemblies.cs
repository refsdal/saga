namespace Saga.Gudrun.Architecture.Tests;

public static class Assemblies
{
    public static readonly Assembly Application = typeof(IGudrunApplicationAssemblyMarker).Assembly;
    public static readonly Assembly Domain = typeof(IGudrunDomainAssemblyMarker).Assembly;
    public static readonly Assembly Host = typeof(IGudrunHostAssemblyMarker).Assembly;
    public static readonly Assembly Infrastructure = typeof(IGudrunInfrastructureAssemblyMarker).Assembly;
    public static readonly Assembly Presentation = typeof(IGudrunPresentationAssemblyMarker).Assembly;
}