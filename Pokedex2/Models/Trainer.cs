using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex2.Models
{
    public class Trainer
    {

        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string name { get; set; }

    }
}
