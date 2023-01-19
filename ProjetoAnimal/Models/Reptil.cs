
namespace ProjetoAnimal.Models
{
    public class Reptil : Animal
    {
        public bool TemEscamas { get; set; }
        public bool TemCasco { get; set; }

        public Reptil(bool temEscamas, bool temCasco):base()
        {
            TemEscamas = temEscamas;
            TemCasco = temCasco;
        }
    
        public override void Alimentar()
        {
            throw new NotImplementedException();
        }

        public override void Comunicar()
        {
            throw new NotImplementedException();
        }

        public override void Movimentar()
        {
            throw new NotImplementedException();
        }
    }
}
