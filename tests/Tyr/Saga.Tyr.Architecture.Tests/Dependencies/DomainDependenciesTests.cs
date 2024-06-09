namespace Saga.Tyr.Architecture.Tests.Dependencies;

public sealed class DomainDependenciesTests
{
    [Fact]
    public void DomainProject_ShouldNotHaveReferenceToApplicationProject() => Types
        .InAssembly(Assemblies.Domain)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Tyr.Application")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
    
    [Fact]
    public void DomainProject_ShouldNotHaveReferenceToInfrastructureProject() => Types
        .InAssembly(Assemblies.Domain)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Tyr.Infrastructure")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
    
    [Fact]
    public void DomainProject_ShouldNotHaveReferenceToPresentationProject() => Types
        .InAssembly(Assemblies.Domain)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Tyr.Presentation")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}