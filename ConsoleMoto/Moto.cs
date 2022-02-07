using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMoto
{
    public class Moto
    { 
        public bool Ligado { get; set; }
        public string Nome { get; set; }
        public int Velocidade { get; set; }
        public void LigarMoto() 
        {
            Ligado = true;
        }
        public void DesligarMoto()
        {
            Ligado = false;
        }
        public void AcelerarMoto()
        {
            Velocidade+=2;
        }
        public void FreiarMoto()
        {
            Velocidade-=1;
        }
        public void DefinirNomeMoto(string nome)
        {
           Nome=nome;
        }
        public string RetornaNomeMoto()
        {
            return Nome;
        }
        public string RetornaVelocidadeMoto()
        {
            return Velocidade.ToString() + " KM/H ";
        }
    }
}
