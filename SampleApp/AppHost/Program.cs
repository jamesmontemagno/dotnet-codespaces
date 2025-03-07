var builder = DistributedApplication.CreateBuilder(args);

var backend = builder.AddProject<Projects.BackEnd>("backend");

builder.AddProject<Projects.FrontEnd>("frontend")
    .WithExternalHttpEndpoints()
    .WithReference(backend);

builder.Build().Run();
