using Microsoft.EntityFrameworkCore;
using TarefasDiaADia.API.Data;   // <--- ESSENCIAL
using TarefasDiaADia.API.Models; // <--- ESSENCIAL

var builder = WebApplication.CreateBuilder(args);

// Configuração do Banco
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=tarefas.db"));

// Configuração de CORS
builder.Services.AddCors(options =>
    options.AddPolicy("PermitirTudo", policy =>
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

var app = builder.Build();

app.UseCors("PermitirTudo");

// --- SUAS ROTAS ---

app.MapGet("/tarefas", async (AppDbContext db) => 
    await db.Tarefas.ToListAsync());

app.MapPost("/tarefas", async (AppDbContext db, Tarefa tarefa) => {
    db.Tarefas.Add(tarefa);
    await db.SaveChangesAsync();
    return Results.Created($"/tarefas/{tarefa.Id}", tarefa);
});

app.MapDelete("/tarefas/{id}", async (AppDbContext db, int id) => {
    var tarefa = await db.Tarefas.FindAsync(id);
    if (tarefa == null) return Results.NotFound();
    db.Tarefas.Remove(tarefa);
    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.Run();