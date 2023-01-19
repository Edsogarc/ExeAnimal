using ProjetoAnimal.Models.Interfaces;

namespace ProjetoAnimal.Models.Animais
{
    public class Cisne : Ave, IOviparo, IVoar, IAquatico
    {
        public Cisne(bool rapina, bool corPena) : base(rapina, corPena)
        {
        }

        public int AltitudeMaimaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
