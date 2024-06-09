namespace Saga.Dagny.Architecture.Tests.Dependencies;

public sealed class PresentationDependenciesTests
{
    [Fact]
    public void PresentationProject_ShouldNotHaveReferenceToPresentationProject() => Types
        .InAssembly(Assemblies.Presentation)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Dagny.Infrastructure")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}