var builder = DistributedApplication.CreateBuilder(args);

var databaseServer = builder.AddPostgres("postgresql");
var rabbitMq = builder.AddRabbitMQ("rabbitmq");

var dagnyRedis = builder.AddRedis("dagny-redis");
var dagnyPostgresql = databaseServer.AddDatabase("dagny-postgresql", "dagny");
var dagny = builder.AddProject<Saga_Dagny_Host>("dagny")
    .WithReference(dagnyRedis, "redis")
    .WithReference(dagnyPostgresql, "postgresql")
    .WithReference(rabbitMq, "rabbitmq")
    .WithHttpEndpoint(10010);

var tyrRedis = builder.AddRedis("tyr-redis");
var tyrPostgresql = databaseServer.AddDatabase("tyr-postgresql", "tyr");
var tyr = builder.AddProject<Saga_Tyr_Host>("tyr")
    .WithReference(tyrRedis, "redis")
    .WithReference(tyrPostgresql, "postgresql")
    .WithReference(rabbitMq, "rabbitmq")
    .WithHttpEndpoint(10011);

var vidarRedis = builder.AddRedis("vidar-redis");
var vidarPostgresql = databaseServer.AddDatabase("vidar-postgresql", "vidar");
var vidar = builder.AddProject<Saga_Vidar_Host>("vidar")
    .WithReference(vidarRedis, "redis")
    .WithReference(vidarPostgresql, "postgresql")
    .WithReference(rabbitMq, "rabbitmq")
    .WithHttpEndpoint(10012);

var gudrunRedis = builder.AddRedis("gudrun-redis");
var gudrunPostgresql = databaseServer.AddDatabase("gudrun-postgresql", "gudrun");
var gudrun = builder.AddProject<Saga_Gudrun_Host>("gudrun")
    .WithReference(gudrunRedis, "redis")
    .WithReference(gudrunPostgresql, "postgresql")
    .WithReference(rabbitMq, "rabbitmq")
    .WithHttpEndpoint(10013);

builder.Build().Run();