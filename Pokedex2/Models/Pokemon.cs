using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex2.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string name { get; set; }

        [Display(Name = "Tipo")]
        public string type { get; set; }

        public int TrainerId { get; set; }
        [Display(Name = "Treinador")]
        public Trainer trainer { get; set; }
    }
}
