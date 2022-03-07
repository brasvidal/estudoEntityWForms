namespace Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telefone1 { get; set; }
        public string? Telefone2 { get; set; }
        public string? Telefone3 { get; set; }
        public string? CEP { get; set; }
        public string? Endereco { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public DateTime DataNasc { get; set; }
        public string Sexo { get; set; }
    }
}
