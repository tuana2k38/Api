
var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddSingleton<Repository>()
    .AddAuthentication().Services // Configure your Authentication here
    .AddAuthorization(o => o.AddPolicy("Librarian", p => p.RequireAssertion(_ => false)))
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddAuthorization()
    .UseField<DomainExceptionMiddleware>();

var app = builder.Build();

app.MapGraphQL();

app.Run();