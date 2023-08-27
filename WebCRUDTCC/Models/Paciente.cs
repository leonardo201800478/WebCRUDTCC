using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCRUDTCC.Models
{
    [Table("Paciente")]
    public class Paciente
    {
        [Column("Id")]
        [Display(Name ="Código")]

        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name ="Nome do Paciente")]

        public string Nome { get; set; }

        [Column("Cpf")]
        [Display(Name = "CPF")]

        public string Cpf { get; set; }

        [Column("DataNasc")]
        [Display(Name = "Data de Nascimento")]

        public string DataNasc { get; set; }

    }
}
