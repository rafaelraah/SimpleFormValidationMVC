using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleFormValidationMVC.Models
{
    public class Filme
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo Nome deve ter entre 2 e 50 caracteres")]
        [Column(TypeName = "varchar(60)")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo Gênero deve ter entre 2 e 50 caracteres")]
        [Required(ErrorMessage = "O campo Gênero é obrigatório")]
        [Column(TypeName = "varchar(60)")]
        public string Genero { get; set; }

        [Display(Name = "Avaliação")]
        [Range(1, 10, ErrorMessage = "A avaliação/nota deve ser entre 1 e 10")]
        [Required(ErrorMessage = "O campo Avaliação é obrigatório")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "O campo Avaliação só aceita números")]
        public int Avaliacao { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "A data está em um formato incorreto")]
        [Display(Name = "Data da Avaliação")]
        public DateTime DataAvaliacao { get; set; }
    }
}
