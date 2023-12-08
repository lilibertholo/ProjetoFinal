using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalLivia.Models
{
    [Table("LocalRealizacao")]
    public class LocalRealizacao
    {
        [Column("Id")]
        [Display(Name = "Código do Local da Realização")]
        public int Id { get; set; }

        [Column("LocalNome")]
        [Display(Name = "Local da Realização")]
        public string LocalNome { get; set; } = string.Empty;


        [ForeignKey("Id")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
