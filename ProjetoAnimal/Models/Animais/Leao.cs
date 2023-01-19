
namespace ProjetoAnimal.Models.Animais
{
    public class Leao : Mamifero
    {
        public Leao():base(){}

        public string AtribuiSexo()
        {
            if (Sexo == 'f'||Sexo == 'F')
            {
                return "Femea";
            }
            return "Macho";
        }
        public string Dieta()
        {
            Carnivoro = true;
            return "Carnivoro";
        }
        public DateTime Nascimento()
        {
            DataNascimento = new DateTime(2002, 2, 1);
            return DataNascimento.Date;
        }
        public int AtribuiIdade()
        {      
            int idade = DateTime.Now.Year - Nascimento().Year;
            return idade;
        }
        public override string ToString()
        {
            Nome = "Leão";
            Sexo = 'F';
            

            return "Nome: " + Nome + "\n"
                + "Data de Nascimento: " + Nascimento().ToString("dd/MM/yyyy") + "\n"
                + "Sexo: " + AtribuiSexo() + "\n"
                + "Idade: " + AtribuiIdade() + "\n"
                + "Dieta: " + Dieta() + "\n";
        }
    }
}
