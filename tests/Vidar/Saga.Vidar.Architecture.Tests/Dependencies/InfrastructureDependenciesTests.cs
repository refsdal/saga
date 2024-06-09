namespace Saga.Vidar.Architecture.Tests.Dependencies;

public sealed class InfrastructureDependenciesTests
{
    [Fact]
    public void InfrastructureProject_ShouldNotHaveReferenceToPresentationProject() => Types
        .InAssembly(Assemblies.Infrastructure)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Vidar.Presentation")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}