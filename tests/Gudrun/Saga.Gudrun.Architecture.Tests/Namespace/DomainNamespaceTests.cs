namespace Saga.Gudrun.Architecture.Tests.Namespace;

public sealed class DomainNamespaceTests
{
    [Fact]
    public void AllTypesInDomainProject_ShouldResideInCorrectNamespace() => Types
        .InAssembly(Assemblies.Domain)
        .Should()
        .ResideInNamespaceStartingWith("Saga.Gudrun.Domain")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}