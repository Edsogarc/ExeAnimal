using ProjetoAnimal.Models.Interfaces;

namespace ProjetoAnimal.Models.Animais
{
    public class Arara : Ave, IOviparo, IVoar
    {
        public Arara(bool rapina, bool corPena) : base(rapina, corPena)
        {
        }

        public int AltitudeMaimaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public void Botar()
        {
        }

        public void Chocar()
        {
        }

        public void Voar()
        {
            throw new NotImplementedException();
        }
    }
}
