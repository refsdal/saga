namespace Saga.Vidar.Architecture.Tests.Dependencies;

public sealed class PresentationDependenciesTests
{
    [Fact]
    public void PresentationProject_ShouldNotHaveReferenceToPresentationProject() => Types
        .InAssembly(Assemblies.Presentation)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Vidar.Infrastructure")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}