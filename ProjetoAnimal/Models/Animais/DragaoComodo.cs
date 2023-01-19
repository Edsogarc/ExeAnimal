using ProjetoAnimal.Models.Interfaces;

namespace ProjetoAnimal.Models.Animais
{
    public class DragaoComodo : Reptil, IOviparo
    {
        public DragaoComodo(bool temEscamas, bool temCasco) : base(temEscamas, temCasco)
        {
        }

        public void Botar()
        {

        }

        public void Chocar()
        {
        }
    }
}
