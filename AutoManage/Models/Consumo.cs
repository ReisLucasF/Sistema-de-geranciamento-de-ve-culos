using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoManage.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int ID { get; set; }

        [Display(Name ="Descrição")]
        [Required(ErrorMessage = "É obrigatório informar a descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a data.")]
        public DateTime Data{ get; set; }

        [Required(ErrorMessage = "É obrigatório informar a quilometragem.")]
        public int Km { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "É obrigatório informar o valor.")]
        public decimal Valor { get; set; }

        [Display(Name = "Tipo de combustível")]
        [Required(ErrorMessage = "É obrigatório informar o tipo de combustível.")]
        public TipoCombustivel Tipo { get; set; }

        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "É obrigatório informar o Veículo.")]
        public  int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}
