using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeiAmigo.Models
{
    /*classe estabelecimento - anderson 17-9-2021 10:30*/
    public class Estab
    {
        public int Id { get; set; }
        public string  RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public int Cnpj { get; set; }

        [Required(ErrorMessage = "O Tel./Cel. é requerido!!")]
        [MaxLength(20)]
        [Display(Name = "Tel./Cel.")]
        [RegularExpression(@"^\d{11}$|^\d{2}-\d{5}-\d{4}$", ErrorMessage = "Celular inválido! Deverá conter só números (ex.11912349999) ou estar no formato 00-00000-0000")]
        public string Tel1 { get; set; }

        [Required(ErrorMessage = "O Tel./Cel. é requerido!!")]
        [MaxLength(20)]
        [Display(Name = "Tel./Cel.")]
        [RegularExpression(@"^\d{11}$|^\d{2}-\d{5}-\d{4}$", ErrorMessage = "Celular inválido! Deverá conter só números (ex.11912349999) ou estar no formato 00-00000-0000")]
        public string Tel2 { get; set; }

        [Required(ErrorMessage = "O campo E-mail é requerido!!")]
        [MaxLength(150, ErrorMessage = "O E-mail não pode exceder 150 caracteres.")]
        [Display(Name = "E-mail")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "E-mail em formato inválido! Corrijar e tente novamente.")]
        //[Index("Pacientes_Email_Index", IsUnique = true)]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo CEP é requerido!!")]
        [MaxLength(8, ErrorMessage = "O CEP não pode exceder 8 caracteres.")]
        [Display(Name = "CEP")]
        public string End_CEP { get; set; }

        [MaxLength(255, ErrorMessage = "O campo Rua não pode exceder 255 caracteres.")]
        [Display(Name = "Av/Rua/Travessa")]
        public string End_Rua { get; set; }

        [MaxLength(10, ErrorMessage = "O campo Número não pode exceder 10 caracteres.")]
        [Display(Name = "Número")]
        public string End_Numero { get; set; }

        [MaxLength(40, ErrorMessage = "O campo Complemento não pode exceder 40 caracteres.")]
        [Display(Name = "Complemento")]
        public string End_Complemento { get; set; }

        [MaxLength(40, ErrorMessage = "O campo Bairro não pode exceder 40 caracteres.")]
        [Display(Name = "Bairro")]
        public string End_Bairro { get; set; }


        [Display(Name = "UF")]
        public int CD_UF { get; set; }

        [Required(ErrorMessage = "O campo CD Município é requerido!!")]
        [Display(Name = "CD Município")]
        [Range(1, double.MaxValue, ErrorMessage = "Selecione um Município!")]
        public int Cd_Municipio { get; set; }

        /*Ativo? se sim, significa que possui um cadastro de prestação de serviço válido conosco*/
        [Display(Name = "Ativo?")]
        public bool Ativo { get; set; }

        /*Bloqueado? se sim, quer dizer que existe algum inadimplência: falta de pagamento ou feriu alguma regra contratual.
         E fica impossibilidade de realizar algumas atividades, até regularização*/
        [Display(Name = "Bloqueado?")]
        public bool Bloqueado { get; set; }

        /*--------------- início bloco controle de cadastro */
        /*cpf será o ID do login. CPF de quem realizou o cadastro deste registro*/
        public int UsuCadastro { get; set; }

        public DateTime DataCadastro { get; set; }

        /*cpf será o ID do login. CPF de quem realizou a última Alteracao deste registro*/
        public int UsuAlteracao { get; set; }

        public DateTime DataAlteracao { get; set; }

        /*--------------- término bloco controle de cadastro */

        public string Observacao { get; set; }

        public string ToqueCampainha1 { get; set; }

        public string ToqueCampainha2 { get; set; }

        public string ToqueCampainha3 { get; set; }
    }
}
