namespace Saga.Tyr.Architecture.Tests.Dependencies;

public sealed class InfrastructureDependenciesTests
{
    [Fact]
    public void InfrastructureProject_ShouldNotHaveReferenceToPresentationProject() => Types
        .InAssembly(Assemblies.Infrastructure)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Tyr.Presentation")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}