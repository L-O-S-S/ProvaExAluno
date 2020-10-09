using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace exAluno.Models
{
    public class AlunoModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome: ")]
        [Required(ErrorMessage = "Informe o Nome")]
        public string Nom { get; set; }

        [Display(Name = "Curso: ")]
        [Required(ErrorMessage = "Informe o Curso")]
        public string Curso { get; set; }

        [Display(Name = "Telefone: ")]
        [Required(ErrorMessage = "Informe o Telefone")]
        public string Fone { get; set; }
        [Display(Name = "Endereço: ")]
        [Required(ErrorMessage = "Informe o Endereço")]
        public string Endereco { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Infore E-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Display(Name = "Filiação: ")]
        [Required(ErrorMessage = "Informe a Filiação")]
        public string Fili { get; set; }
    }
}