var builder = DistributedApplication.CreateBuilder(args);

var tyr = builder.AddProject<Saga_Tyr_Host>("tyr")
    .WithHttpEndpoint(10011);

var vidar = builder.AddProject<Saga_Vidar_Host>("vidar")
    .WithHttpEndpoint(10012);

builder.Build().Run();