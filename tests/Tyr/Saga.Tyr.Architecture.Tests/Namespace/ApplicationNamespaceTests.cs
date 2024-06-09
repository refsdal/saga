namespace Saga.Tyr.Architecture.Tests.Namespace;

public sealed class ApplicationNamespaceTests
{
    [Fact]
    public void AllTypesInApplicationProject_ShouldResideInCorrectNamespace() => Types
        .InAssembly(Assemblies.Application)
        .Should()
        .ResideInNamespaceStartingWith("Saga.Tyr.Application")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}