
namespace ProjetoAnimal.Models
{
    public class Ave : Animal
    {
        public bool Rapina { get; set; }
        public bool CorPena { get; set; }

        public Ave(bool rapina, bool corPena):base()
        {
            Rapina = rapina;
            CorPena = corPena;
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
        public void Ciscar()
        {

        }
    }
}
