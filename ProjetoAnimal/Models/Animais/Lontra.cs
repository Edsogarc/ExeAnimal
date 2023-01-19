using ProjetoAnimal.Models.Interfaces;

namespace ProjetoAnimal.Models.Animais
{
    public class Lontra : Mamifero, IAquatico
    {
        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


    }
}
