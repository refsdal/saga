namespace Saga.Gudrun.Architecture.Tests.Namespace;

public sealed class InfrastructureNamespaceTests
{
    [Fact]
    public void AllTypesInInfrastructureProject_ShouldResideInCorrectNamespace() => Types
        .InAssembly(Assemblies.Infrastructure)
        .Should()
        .ResideInNamespaceStartingWith("Saga.Gudrun.Infrastructure")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}