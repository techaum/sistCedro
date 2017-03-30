using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sistCedro.Models;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace sistCedro.ViewModels
{
    public class RestaurantesxPratos
    {
        public List<Restaurante> Restaurantes { get; set; }
        public List<Prato> Pratos { get; set; }
    }
}