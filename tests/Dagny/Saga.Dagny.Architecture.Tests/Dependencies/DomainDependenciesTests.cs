namespace Saga.Dagny.Architecture.Tests.Dependencies;

public sealed class DomainDependenciesTests
{
    [Fact]
    public void DomainProject_ShouldNotHaveReferenceToApplicationProject() => Types
        .InAssembly(Assemblies.Domain)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Dagny.Application")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
    
    [Fact]
    public void DomainProject_ShouldNotHaveReferenceToInfrastructureProject() => Types
        .InAssembly(Assemblies.Domain)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Dagny.Infrastructure")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
    
    [Fact]
    public void DomainProject_ShouldNotHaveReferenceToPresentationProject() => Types
        .InAssembly(Assemblies.Domain)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Dagny.Presentation")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}