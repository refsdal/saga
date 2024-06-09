var builder = DistributedApplication.CreateBuilder(args);

var vidar = builder.AddProject<Saga_Vidar_Host>("vidar")
    .WithHttpEndpoint(10012);

builder.Build().Run();