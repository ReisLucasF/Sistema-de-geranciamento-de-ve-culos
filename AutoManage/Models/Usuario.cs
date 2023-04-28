using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoManage.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="É obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o tipo de perfil!")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        User
    }
}
