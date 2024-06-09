namespace Saga.Vidar.Architecture.Tests;

public static class Assemblies
{
    public static readonly Assembly Application = typeof(IVidarApplicationAssemblyMarker).Assembly;
    public static readonly Assembly Domain = typeof(IVidarDomainAssemblyMarker).Assembly;
    public static readonly Assembly Host = typeof(IVidarHostAssemblyMarker).Assembly;
    public static readonly Assembly Infrastructure = typeof(IVidarInfrastructureAssemblyMarker).Assembly;
    public static readonly Assembly Presentation = typeof(IVidarPresentationAssemblyMarker).Assembly;
}