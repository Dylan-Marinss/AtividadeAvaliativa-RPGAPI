using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgApi.Models
{
    public class Habilidade
    {
         public List<PersonagemHabilidade> PersonagemHabilidades {get; set;} = [];
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public int Dano {get; set;}

       
    }
}