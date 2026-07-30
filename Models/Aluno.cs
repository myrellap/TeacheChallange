namespace TeacheChallange;

public class Aluno
{
     public int Id { get; set; } // Primary key
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public DateTime DataNascimento { get; set; }
    public DateTime DataCadastro { get; set; }
    public bool Ativo { get; set; }
}