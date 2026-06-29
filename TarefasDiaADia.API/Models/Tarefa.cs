namespace TarefasDiaADia.API.Models;

public class Tarefa
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public string CorTag { get; set; } = string.Empty;
    public bool Concluida { get; set; } = false;
    public DateTime DataCriacao { get; set; } = DateTime.Now;
}