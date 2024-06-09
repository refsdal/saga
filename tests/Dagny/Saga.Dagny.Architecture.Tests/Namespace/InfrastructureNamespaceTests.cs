namespace Saga.Dagny.Architecture.Tests.Namespace;

public sealed class InfrastructureNamespaceTests
{
    [Fact]
    public void AllTypesInInfrastructureProject_ShouldResideInCorrectNamespace() => Types
        .InAssembly(Assemblies.Infrastructure)
        .Should()
        .ResideInNamespaceStartingWith("Saga.Dagny.Infrastructure")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}