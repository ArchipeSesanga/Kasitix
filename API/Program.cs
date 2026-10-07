using Infrastructure.Interfaces;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

var connectionString = builder.Configuration.GetConnectionString("KasiTix")
    ?? throw new InvalidOperationException(
        "Connection string 'MatricCompass' was not found. Run 'dotnet user-secrets set " +
        "ConnectionStrings:MatricCompass \"...\"' inside the API project.");

builder.Services.AddControllers(options =>
{
    options.SuppressAsyncSuffixInActionNames = false;
});

builder.Services.AddOpenApi(); 

builder.Services.AddScoped<IEventRepository, EventRepository>();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
await db.Database.MigrateAsync(); // apply pending migrations
if (!await db.Students.AnyAsync()) // SELECT EXISTS, not load-all
{
var s = new Event("Thandiwe Nkosi", "LRN-2026-00114");
s.EnrollSubject("MATH", 80);
db.Students.Add(s);
await db.SaveChangesAsync();
}
}


app.Run();
