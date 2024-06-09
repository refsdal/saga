namespace Saga.Gudrun.Architecture.Tests.Dependencies;

public sealed class PresentationDependenciesTests
{
    [Fact]
    public void PresentationProject_ShouldNotHaveReferenceToPresentationProject() => Types
        .InAssembly(Assemblies.Presentation)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Gudrun.Infrastructure")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}