var builder = DistributedApplication.CreateBuilder(args);

var dagny = builder.AddProject<Saga_Dagny_Host>("dagny")
    .WithHttpEndpoint(10010);

var tyr = builder.AddProject<Saga_Tyr_Host>("tyr")
    .WithHttpEndpoint(10011);

var vidar = builder.AddProject<Saga_Vidar_Host>("vidar")
    .WithHttpEndpoint(10012);

var gudrun = builder.AddProject<Saga_Gudrun_Host>("gudrun")
    .WithHttpEndpoint(10013);

builder.Build().Run();