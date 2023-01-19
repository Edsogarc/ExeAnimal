

namespace ProjetoAnimal.Models
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }
        public bool Carnivoro { get; set; }
        public bool Peconhento { get; set; }

        public Animal(){}
        public Animal(string nome, DateTime dataNascimento, char sexo, int idade, bool carnivoro, bool peconhento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Idade = idade;
            Carnivoro = carnivoro;
            Peconhento = peconhento;
        }
        public abstract void Movimentar();
        public abstract void Comunicar();
        public abstract void Alimentar();
    }
}
