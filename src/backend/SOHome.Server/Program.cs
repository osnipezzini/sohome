using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var authDatabase = builder
    .AddPostgres("sohome")
    .WithPgAdmin()
    .WithDataVolume("auth-db")
    .AddDatabase("auth");

builder.AddProject<SOHome_Auth>("authentication")
    .WithReference(authDatabase);

builder
    .Build()
    .Run();
