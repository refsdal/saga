namespace Saga.Tyr.Architecture.Tests.Namespace;

public sealed class DomainNamespaceTests
{
    [Fact]
    public void AllTypesInDomainProject_ShouldResideInCorrectNamespace() => Types
        .InAssembly(Assemblies.Domain)
        .Should()
        .ResideInNamespaceStartingWith("Saga.Tyr.Domain")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}