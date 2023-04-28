using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoManage.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="É obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a placa")]
        public string Placa { get; set; }

        public ICollection<Consumo> Consumos { get; set; }
    }
}
