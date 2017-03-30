using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sistCedro.Models
{
    public class Prato
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nome do Prato")]
        public string nomePrato { get; set; }

        [DisplayName("Preço do Prato")]
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public decimal precoPrato { get; set; }

        public int IdRestaurante { get; set; }
        [ForeignKey("IdRestaurante")]
        public virtual Restaurante Restaurante { get; set; }
    }
}