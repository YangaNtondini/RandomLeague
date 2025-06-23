using RandomLeague.BackgroundTasks;
using RandomLeague.Repositories;
using RandomLeague.Services;

var builder = WebApplication.CreateBuilder(args);

// services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Dependency Injection -- not sustainable, need to add the dynamically.
builder.Services.AddSingleton<ILeagueRepository, LeagueRepository>();
builder.Services.AddSingleton<ILeagueService, LeagueService>();
builder.Services.AddHostedService<MatchSimulator>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();