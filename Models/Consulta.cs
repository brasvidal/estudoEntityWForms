using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public int IdDentista { get; set; }
        public int IdPaciente { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? HoraMarcada { get; set; }
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraFim { get; set; }
        public string? Observacao { get; set; }

        public string? Status { get; set; }

    }
}
