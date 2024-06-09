namespace Saga.Dagny.Architecture.Tests;

public static class Assemblies
{
    public static readonly Assembly Application = typeof(IDagnyApplicationAssemblyMarker).Assembly;
    public static readonly Assembly Domain = typeof(IDagnyDomainAssemblyMarker).Assembly;
    public static readonly Assembly Host = typeof(IDagnyHostAssemblyMarker).Assembly;
    public static readonly Assembly Infrastructure = typeof(IDagnyInfrastructureAssemblyMarker).Assembly;
    public static readonly Assembly Presentation = typeof(IDagnyPresentationAssemblyMarker).Assembly;
}