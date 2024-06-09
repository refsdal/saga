namespace Saga.Dagny.Architecture.Tests.Dependencies;

public sealed class ApplicationDependenciesTests
{
    [Fact]
    public void ApplicationProject_ShouldNotHaveReferenceToInfrastructureProject() => Types
        .InAssembly(Assemblies.Application)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Dagny.Infrastructure")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
    
    [Fact]
    public void ApplicationProject_ShouldNotHaveReferenceToPresentationProject() => Types
        .InAssembly(Assemblies.Application)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Dagny.Presentation")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}