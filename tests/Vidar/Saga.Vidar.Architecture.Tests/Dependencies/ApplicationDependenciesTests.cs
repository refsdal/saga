namespace Saga.Vidar.Architecture.Tests.Dependencies;

public sealed class ApplicationDependenciesTests
{
    [Fact]
    public void ApplicationProject_ShouldNotHaveReferenceToInfrastructureProject() => Types
        .InAssembly(Assemblies.Application)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Vidar.Infrastructure")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
    
    [Fact]
    public void ApplicationProject_ShouldNotHaveReferenceToPresentationProject() => Types
        .InAssembly(Assemblies.Application)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Vidar.Presentation")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}