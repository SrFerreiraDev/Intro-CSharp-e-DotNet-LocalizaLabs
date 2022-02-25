using System;
using Primeiro;
using Classes;
using Interface;
using Enum;

namespace Introdução_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Heverton;
            Pessoas pessoa3 = (Pessoas)4;

            Animal animal = new Animal();

            animal.Nome = "Gema";
            animal.Especie = "Cachorro";
            animal.NomeDono = "Edinaldo Ferreira";

            Pessoa person = new Pessoa();

            person.Nome = "Edinaldo Ferreira";
            person.Idade = 26;
            person.Genero = "Masculino";

            var person2 = new Pessoa();
            person2.Nome = "Estefhane Martins";
            person2.Idade = 26;
            person2.Genero = "Feminino";

            var classe = new Classe();
            var classe2 = new Segundo.Classe();

            Console.WriteLine(pessoa3);
        }
    }
}