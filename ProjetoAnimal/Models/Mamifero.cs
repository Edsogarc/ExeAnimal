
namespace ProjetoAnimal.Models
{
    public class Mamifero : Animal
    {
        public int QtdMamas { get; private set; }
        public bool Pelos { get; private set; }
        public string CorPelo { get; private set; }
        public Mamifero() :base(){}
        public Mamifero(string nome, DateTime dataNascimento, char sexo, int idade, bool carnivoro, bool peconhento) 
            :base(nome,dataNascimento,sexo,idade,carnivoro,peconhento)
        {

        }
        public override void Movimentar()
        {

        }
        public override void Comunicar()
        {

        }
        public override void Alimentar()
        {

        }
        public void Amamentar()
        {

        }
    }
}
