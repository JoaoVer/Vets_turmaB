using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vets.Models
{   
    /// <summary>
    /// Representa os dados de um 'dono'
    /// </summary>
    public class Donos
    {
        public Donos()
        {
            Animais = new HashSet<Animais>();
        }

        /// <summary>
        /// Identificador do Dono, será PK na tabela da BD
        /// </summary>
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// Nome do Dono
        /// </summary>
        [Required(ErrorMessage ="O Nome é de preenchimento obrigatório")]
        [StringLength(40, ErrorMessage = "O {0} não pode ter mais de {1}.")]
        [RegularExpression("[A-Z][a-z]+(( | d[ao](s)? | e |-|'| d')[A-Z][a-z]+){1,3}", ErrorMessage ="Deve escrever entre 2 e 4 nomes, começados por uma Maiúscula, seguidos de minúsculas.")]
        public string Nome { get; set; }

        /// <summary>
        /// Número de Identificação Fiscal, vulgo 'nº de contribuinte'
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")] // o parâmetro {0} representa o 'nome do atributo'
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Deve escrever exatamente {1} algarismos no {0}.")]
        [RegularExpression("[12567][0-9]{8}", ErrorMessage = "Deve escrever um nº, com 9 algarismos, começando por 1, 2, 5, 6 ou 7.")] // [] representa um conjunto de valores possiveis e aceita apenas um deles.
        public string NIF { get; set; }
        /// <summary>
        /// Lista de Animais de um determinado dono
        /// </summary>
        //Lista de Animais de um determinado dono
        public ICollection<Animais> Animais { get; set; }
    }
}
