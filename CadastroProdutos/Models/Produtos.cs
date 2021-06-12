using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CadastroProdutos.Models
{
    public class Produtos
    {
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Nome { get; set; }

        [StringLength(60, MinimumLength = 5)]
        public string Descricao { get; set; }

        [Range(0.01, 14.00, ErrorMessage = "Peso Obrigatório entre 0,01kg e 14kg")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Categoria { get; set; }

        [Range(5.50, 100.00, ErrorMessage = "Valor obrigatório entre R$ 5,50 e R$ 100,00")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public decimal Vunit { get; set; }
    }
}