using Microsoft.EntityFrameworkCore;
using TarefasDiaADia.API.Models;

namespace TarefasDiaADia.API.Data;

public class AppDbContext : DbContext
{
    // Esse construtor passa as configurações (como qual banco usar) para o EF Core
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Esta é a tabela que será criada no banco de dados
    public DbSet<Tarefa> Tarefas { get; set; }
}