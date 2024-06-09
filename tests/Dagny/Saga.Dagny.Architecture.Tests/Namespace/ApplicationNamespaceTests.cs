namespace Saga.Dagny.Architecture.Tests.Namespace;

public sealed class ApplicationNamespaceTests
{
    [Fact]
    public void AllTypesInApplicationProject_ShouldResideInCorrectNamespace() => Types
        .InAssembly(Assemblies.Application)
        .Should()
        .ResideInNamespaceStartingWith("Saga.Dagny.Application")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}