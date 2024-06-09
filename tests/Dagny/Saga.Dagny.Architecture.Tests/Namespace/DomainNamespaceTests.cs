namespace Saga.Dagny.Architecture.Tests.Namespace;

public sealed class DomainNamespaceTests
{
    [Fact]
    public void AllTypesInDomainProject_ShouldResideInCorrectNamespace() => Types
        .InAssembly(Assemblies.Domain)
        .Should()
        .ResideInNamespaceStartingWith("Saga.Dagny.Domain")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}