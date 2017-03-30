using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sistCedro.Models
{
    public class Restaurante
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nome do Restaurante")]
        public string nomeRestaurante { get; set; }

        public ICollection<Prato> Pratos { get; set; }

    }
}