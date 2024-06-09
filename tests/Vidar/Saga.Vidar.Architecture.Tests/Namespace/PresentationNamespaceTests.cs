namespace Saga.Vidar.Architecture.Tests.Namespace;

public sealed class PresentationNamespaceTests
{
    [Fact]
    public void AllTypesInPresentationProject_ShouldResideInCorrectNamespace() => Types
        .InAssembly(Assemblies.Presentation)
        .Should()
        .ResideInNamespaceStartingWith("Saga.Vidar.Presentation")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}