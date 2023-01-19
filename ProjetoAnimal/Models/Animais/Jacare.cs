using ProjetoAnimal.Models.Interfaces;

namespace ProjetoAnimal.Models.Animais
{
    public class Jacare : Reptil, IOviparo, IAquatico
    {
        public Jacare(bool temEscamas, bool temCasco) : base(temEscamas, temCasco)
        {
        }

        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Botar()
        {

        }

        public void Chocar()
        {

        }
    }
}
