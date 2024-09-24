namespace JovemProgramadorMVC.Models
{
    public class Professor
    {
        public string Registro { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public string Materia { get; set; }

        public string Turmas { get; set; }

        public DateTime HorariosdeAula { get; set; }
    }
}
