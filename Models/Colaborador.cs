using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalLivia.Models
{
    [Table("Colaborador")]
    public class Colaborador
    {
        [Column("Id")]
        [Display(Name = "Código do Colaborador")]
        public int Id { get; set; }

        [Column("ColaboradorNome")]
        [Display(Name = "Colaborador")]
        public string ColaboradorNome { get; set; } = string.Empty;

        [Column("ColaboradorCpf")]
        [Display(Name = "Cpf do Colaborador")]
        public string ColaboradorCpf { get; set; } = string.Empty;

        [Column("ColaboradorSexo")]
        [Display(Name = "Sexo do Colaborador")]
        public string ColaboradorSexo { get; set; } = string.Empty;

        [Column("ColaboradorTelefone")]
        [Display(Name = "Telefone do Colaborador")]
        public string ColaboradorTelefone { get; set; } = string.Empty;

        [ForeignKey("Id")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }

        [ForeignKey("Id")]
        [Display(Name = "Tipo de Colaborador")]
        public int TipoColaboradorId { get; set; }
       
        public TipoColaborador? TipoColaborador { get; set; }
    }
}
