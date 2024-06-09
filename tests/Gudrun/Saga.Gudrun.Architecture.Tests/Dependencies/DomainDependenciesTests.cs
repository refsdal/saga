namespace Saga.Gudrun.Architecture.Tests.Dependencies;

public sealed class DomainDependenciesTests
{
    [Fact]
    public void DomainProject_ShouldNotHaveReferenceToApplicationProject() => Types
        .InAssembly(Assemblies.Domain)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Gudrun.Application")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
    
    [Fact]
    public void DomainProject_ShouldNotHaveReferenceToInfrastructureProject() => Types
        .InAssembly(Assemblies.Domain)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Gudrun.Infrastructure")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
    
    [Fact]
    public void DomainProject_ShouldNotHaveReferenceToPresentationProject() => Types
        .InAssembly(Assemblies.Domain)
        .ShouldNot()
        .HaveDependencyOnAny("Saga.Gudrun.Presentation")
        .GetResult()
        .FailingTypeNames.Should().BeNullOrEmpty();
}