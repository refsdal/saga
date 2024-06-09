namespace Saga.Tyr.Architecture.Tests;

public static class Assemblies
{
    public static readonly Assembly Application = typeof(ITyrApplicationAssemblyMarker).Assembly;
    public static readonly Assembly Domain = typeof(ITyrDomainAssemblyMarker).Assembly;
    public static readonly Assembly Host = typeof(ITyrHostAssemblyMarker).Assembly;
    public static readonly Assembly Infrastructure = typeof(ITyrInfrastructureAssemblyMarker).Assembly;
    public static readonly Assembly Presentation = typeof(ITyrPresentationAssemblyMarker).Assembly;
}