using Acore.SeasonalStats.Application.Queries;
using Acore.SeasonalStats.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<SeasonalStatsDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySqlConnection"),
        new MySqlServerVersion(new Version(8, 4, 3))
    )
);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(GetAllCategoriesQueryHandler).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(GetCategoryQueryHandler).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(GetAllWorldsQueryHandler).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(GetWorldQueryHandler).Assembly);
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<SeasonalStatsDbContext>();
    context.Database.Migrate();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
