namespace Saga.Gudrun.Architecture.Tests.Dependencies;

public sealed class InfrastructureDependenciesTests
{
    [Fact]
    public void InfrastructureProject_ShouldNotHaveReferenceToPresentationProject() => Types
        .InAssembly(Assemblies.Infrastructure)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Gudrun.Presentation")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}