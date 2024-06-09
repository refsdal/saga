namespace Saga.Gudrun.Architecture.Tests.Namespace;

public sealed class ApplicationNamespaceTests
{
    [Fact]
    public void AllTypesInApplicationProject_ShouldResideInCorrectNamespace() => Types
        .InAssembly(Assemblies.Application)
        .Should()
        .ResideInNamespaceStartingWith("Saga.Gudrun.Application")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}