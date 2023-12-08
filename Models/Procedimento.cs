using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalLivia.Models
{
    [Table("Procedimento")]
    public class Procedimento
    {
        [Column("Id")]
        [Display(Name = "Código do Procedimento")]
        public int Id { get; set; }

        [Column("ProcedimentoNome")]
        [Display(Name = "Procedimento")]
        public string ProcedimentoNome{ get; set; } = string.Empty;

        [Column("ProcedimentoObservacao")]
        [Display(Name = "Observações do Procedimento")]
        public string ProcedimentoObservacao { get; set; } = string.Empty;

        [ForeignKey("Id")]
        [Display(Name = "Tipo de Procedimento")]
        public int TipoProcedimentoId { get; set; }
        public TipoProcedimento? TipoProcedimento { get; set; }
    }
}
