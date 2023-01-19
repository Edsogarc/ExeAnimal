using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAnimal.Models.Interfaces
{
    public interface IVoar
    {
        public int AltitudeMaimaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
        public void Voar();
    }
}
