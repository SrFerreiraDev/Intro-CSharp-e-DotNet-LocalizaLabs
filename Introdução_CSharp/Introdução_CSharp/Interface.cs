using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
   interface IAnimal
    {
        void Nome(string nome);
        void Especie(string especie);
        void Dono(string nomeDono);
    }

    class Animal : IAnimal
    {
        public string Nome { get; set; }
        public string Especie { get; set;}
        public string NomeDono { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }

        void IAnimal.Especie(string especie)
        {
            this.Especie = especie;
        }

        void IAnimal.Dono(string nomeDono)
        {
            this.NomeDono = nomeDono;
        }
    }
}
